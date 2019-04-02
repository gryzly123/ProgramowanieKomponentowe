using Nancy;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Server
{
    public class UserModule : NancyModule
    {
        public UserModule() : base("/User")
        {
            Get["/{id}"] = parameter => { return GetById(parameter.id); };
            Get["/{id}/summary"] = parameter => { return GetSummary(parameter.id); };
            Delete["/{id}"] = parameter => { return RemoveUser(parameter.id); };
            Put["/{id}"] = parameter => { return UpdateUser(parameter.id, Json.Parse(Request)); };
            Get["/all"] = parameter => { return GetAll(); };
            Post["/add"] = parameter => { return AddUser(Json.Parse(Request)); };
        }

        object GetById(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            foreach (Backend.User u in db.Query<Backend.User>(Backend.User.sqlGet(id)))
            {
                return u;
            }
            return new { error = ErrCode.NotFoundCode };
        }

        object GetSummary(int id)
        {
            JObject user = new JObject();
            PetaPoco.Database db = Backend.Sysdata.Get();

            foreach (Backend.User u in db.Query<Backend.User>(Backend.User.sqlGet(id)))
            {
                user.Add("username", u.Username);
                break;
            }

            //get user tasks and their unique tasklists
            List<long> tasklist_ids = new List<long>();
            IEnumerable<Backend.Task> tasks_arr = db.Query<Backend.Task>("SELECT * FROM Tasks WHERE assignee_user=" + id.ToString());
            foreach (Backend.Task t in tasks_arr)
            {
                if (!tasklist_ids.Contains(t.Owner_Tasklist)) tasklist_ids.Add(t.Owner_Tasklist);
            }

            //get tasklists
            List<Backend.Tasklist> Tasklists = new List<Backend.Tasklist>();
            foreach(long tid in tasklist_ids)
            {
                foreach (Backend.Tasklist t in db.Query<Backend.Tasklist>(Backend.Tasklist.sqlGet(tid)))
                {
                    Tasklists.Add(t);
                    break;
                }
            }

            JArray tasklists = new JArray();
            foreach (Backend.Tasklist t in Tasklists)
            {
                JObject tasklist = new JObject();
                tasklist.Add("name", t.Name);
                tasklist.Add("deadline", t.Deadline);
                JArray tasks = new JArray();
                foreach(Backend.Task tt in tasks_arr)
                {
                    if (tt.Owner_Tasklist != t.Id) continue;
                    JObject task = new JObject();
                    task.Add("name", tt.Name);
                    task.Add("description", tt.Description);
                    task.Add("status", tt.Status);
                    task.Add("deadline", tt.Deadline);
                    tasks.Add(task);
                }
                tasklist.Add("tasks", tasks);
                tasklists.Add(tasklist);

            }
            user.Add("tasklists", tasklists);

            return user.ToString();
        }

        object GetAll()
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            return db.Query<Backend.User>(Backend.User.sqlGetAll());
        }

        object AddUser(dynamic parameters)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            object retval = db.Insert("Users", "id", new { username = parameters["username"] });
            if(retval is long) return new { ok = retval };
            return new { error = ErrCode.InternalErrorCode };
        }

        object RemoveUser(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            int retval = db.Delete("Users", "id", new { id });
            if (retval == 1) return new { ok = id };
            return new { error = ErrCode.NotFoundCode };
        }

        object UpdateUser(int id, dynamic parameters)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();
            Backend.User u = null;

            try { u = (Backend.User)GetById(id); }
            catch(Exception) { return new { error = ErrCode.NotFoundCode }; }


            try
            {
                if (parameters["username"] != null) u.Username = parameters["username"].ToString();
            }
            catch(Exception) { return new { error = ErrCode.ParseError }; }

            int retval = db.Update("Users", "id", u, u.Id);
            if (retval == 1) return new { ok = id };
             return new { error = ErrCode.UpdateFailed };
        }
    }
}
