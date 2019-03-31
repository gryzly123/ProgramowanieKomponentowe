using Nancy;
using System;
using System.Dynamic;

namespace Server
{
    public class TasklistModule : NancyModule
    {
        public TasklistModule() : base("/Tasklist")
        {
            Get["/{id}"] = parameter => { return GetById(parameter.id); };
            Delete["/{id}"] = parameter => { return RemoveTasklist(parameter.id); };
            Put["/{id}"] = parameter => { return UpdateTasklist(parameter.id, Json.Parse(Request)); };
            Get["/all"] = parameter => { return GetAll(); };
            Post["/add"] = parameter => { return AddTasklist(Json.Parse(Request)); };
        }

        object GetById(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            foreach (Backend.Tasklist t in db.Query<Backend.Tasklist>(Backend.Tasklist.sqlGet(id)))
            {
                return t;
            }
            return new { error = ErrCode.NotFoundCode };
        }

        object GetAll()
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            return db.Query<Backend.Tasklist>(Backend.Tasklist.sqlGetAll());
        }

        object AddTasklist(dynamic parameters)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            //check required fields
            if (parameters["name"] == null) return new { error = ErrCode.RequiredField("name") };

            //create object
            dynamic tasklist = new ExpandoObject();
            tasklist.name = parameters["name"].ToString();

            //add optional fields
            try
            {
                if (parameters["deadline"] != null) tasklist.deadline = (Int32)parameters["deadline"];
            }
            catch(Exception e) { return new { error = ErrCode.ParseError}; }

            object retval = db.Insert("Tasklists", "id", tasklist);
            if (retval is long) return new { ok = retval };
            return new { error = ErrCode.InternalErrorCode };
        }

        object RemoveTasklist(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            int retval = db.Delete("Tasklists", "id", new { id });
            return (retval == 1) ? null : new { error = ErrCode.NotFoundCode };
        }

        object UpdateTasklist(int id, dynamic parameters)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();
            Backend.Tasklist t = null;

            try { t = (Backend.Tasklist)GetById(id); }
            catch (Exception e) { return new { error = ErrCode.NotFoundCode }; }

            try
            {
                if (parameters["name"]     != null) t.Name     = parameters["name"].ToString();
                if (parameters["deadline"] != null) t.Deadline = (Int32)parameters["deadline"];
            }
            catch (Exception e) { return new { error = ErrCode.ParseError }; }

            int retval = db.Update("Tasklists", "id", t, t.Id);
            return (retval == 1) ? null : new { error = ErrCode.UpdateFailed };
        }
    }
}
