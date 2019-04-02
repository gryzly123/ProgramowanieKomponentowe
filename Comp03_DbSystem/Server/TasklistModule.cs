using Nancy;
using System;
using System.Collections.Generic;
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

        internal static object GetById(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            foreach (Backend.Tasklist t in db.Query<Backend.Tasklist>(Backend.Tasklist.sqlGet(id)))
            {
                return t;
            }
            return new { error = ErrCode.NotFoundCode };
        }

        internal static object GetAll()
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            return db.Query<Backend.Tasklist>(Backend.Tasklist.sqlGetAll());
        }

        internal static object AddTasklist(dynamic parameters)
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
            catch(Exception) { return new { error = ErrCode.ParseError}; }

            object retval = db.Insert("Tasklists", "id", tasklist);
            if (retval is long) return new { ok = retval };
            return new { error = ErrCode.InternalErrorCode };
        }

        internal static object RemoveTasklist(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            foreach (Backend.Task t in (IEnumerable<Backend.Task>)TaskModule.GetAll())
            {
                if (t.Owner_Tasklist == id)
                    return new { error = ErrCode.DependenciesExist };
            }

            int retval = db.Delete("Tasklists", "id", new { id });
            if (retval == 1) return new { ok = id };
            return new { error = ErrCode.NotFoundCode };
        }

        internal static object UpdateTasklist(int id, dynamic parameters)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();
            Backend.Tasklist t = null;

            try { t = (Backend.Tasklist)GetById(id); }
            catch (Exception) { return new { error = ErrCode.NotFoundCode }; }

            try
            {
                if (parameters["name"]     != null) t.Name     = parameters["name"].ToString();
                if (parameters["deadline"] != null) t.Deadline = (Int32)parameters["deadline"];
            }
            catch (Exception) { return new { error = ErrCode.ParseError }; }

            int retval = db.Update("Tasklists", "id", t, t.Id);
            if (retval == 1) return new { ok = id };
            return new { error = ErrCode.UpdateFailed };
        }
    }
}
