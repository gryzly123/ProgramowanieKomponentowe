using Nancy;
using System;
using System.Dynamic;

namespace Server
{
    public class TaskModule : NancyModule
    {
        public TaskModule() : base("/Task")
        {
            Get["/{id}"] = parameter => { return GetById(parameter.id); };
            Delete["/{id}"] = parameter => { return RemoveTask(parameter.id); };
            Put["/{id}"] = parameter => { return UpdateTask(parameter.id, Json.Parse(Request)); };
            Get["/all"] = parameter => { return GetAll(); };
            Post["/add"] = parameter => { return AddTask(Json.Parse(Request)); };
        }

        object GetById(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            foreach (Backend.Task t in db.Query<Backend.Task>(Backend.Task.sqlGet(id)))
            {
                return t;
            }
            return new { error = ErrCode.NotFoundCode };
        }

        object GetAll()
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            return db.Query<Backend.Task>(Backend.Task.sqlGetAll());
        }

        object AddTask(dynamic parameters)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            //check required fields
            if (parameters["name"] == null) return new { error = ErrCode.RequiredField("name") };
            if (parameters["owner_tasklist"] == null) return new { error = ErrCode.RequiredField("owner_tasklist") };
            if (parameters["assignee_user"] == null) return new { error = ErrCode.RequiredField("assignee_user") };

            //create object
            dynamic tasklist = new ExpandoObject();
            tasklist.name = parameters["name"].ToString();
            tasklist.owner_tasklist = (Int32)parameters["owner_tasklist"];
            tasklist.assignee_user  = (Int32)parameters["assignee_user"];

            //add optional fields
            try
            {
                if (parameters["description"] != null) tasklist.description = parameters["description"].ToString();
                if (parameters["deadline"]    != null) tasklist.deadline    = (Int32)parameters["deadline"];
                if (parameters["status"] != null)
                {
                    tasklist.status = (Int32)parameters["status"];
                    if (tasklist.status < 0 || tasklist.status > 1) throw new Exception();
                }
            }
            catch (Exception e) { return new { error = ErrCode.ParseError }; }

            object retval = db.Insert("Tasks", "id", tasklist);
            if (retval is long) return new { ok = retval };
            return new { error = ErrCode.InternalErrorCode };
        }

        object RemoveTask(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            int retval = db.Delete("Tasks", "id", new { id });
            return (retval == 1) ? null : new { error = ErrCode.NotFoundCode };
        }

        object UpdateTask(int id, dynamic parameters)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();
            Backend.Task t = null;

            try { t = (Backend.Task)GetById(id); }
            catch (Exception e) { return new { error = ErrCode.NotFoundCode }; }

            try
            {
                if (parameters["name"]           != null) t.Name        = parameters["name"]       .ToString();
                if (parameters["description"]    != null) t.Description = parameters["description"].ToString();
                if (parameters["deadline"]       != null) t.Deadline    = (Int32)parameters["deadline"];
                if (parameters["status"]         != null) t.Status      = (Int32)parameters["status"];
                if (parameters["owner_tasklist"] != null) t.Owner_Tasklist  = (Int32)parameters["owner_tasklist"];
                if (parameters["assignee_user"]  != null) t.Assignee_User      = (Int32)parameters["assignee_user"];
            }
            catch (Exception e) { return new { error = ErrCode.ParseError }; }

            int retval = db.Update("Tasks", "id", t, t.Id);
            return (retval == 1) ? null : new { error = ErrCode.UpdateFailed };
        }
    }
}
