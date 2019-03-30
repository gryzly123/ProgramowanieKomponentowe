using Nancy;
using Nancy.Extensions;
using System;

namespace Server
{
    public class Json
    {
        public static dynamic Parse(string Json) { return Newtonsoft.Json.JsonConvert.DeserializeObject(Json); }
        public static dynamic Parse(Request Req) { return Newtonsoft.Json.JsonConvert.DeserializeObject(Req.Body.AsString()); }
    }

    public class UserModule : NancyModule
    {
        public UserModule() : base("/User")
        {
            Get["/{id}"] = parameter => { return GetById(parameter.id); };
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
            return new { error = "user_not_found" };
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
            return new { error = "internal_error" };
        }

        object RemoveUser(int id)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            int retval = db.Delete("Users", "id", new { id = id });
            return (retval == 1) ? null : new { error = "user_doesnt_exist" };
        }

        object UpdateUser(int id, dynamic parameters)
        {
            PetaPoco.Database db = Backend.Sysdata.Get();

            Backend.User u = null;
            try
            {
                u = (Backend.User)GetById(id);
                if (parameters["username"] != null) u.Username = parameters["username"].ToString();
            }
            catch(Exception e)
            {
                return new { error = "user_doesnt_exist" };
            }

            int retval = db.Update("Users", "id", u, u.Id);
            return (retval == 1) ? null : new { error = "update_failed" };
        }
    }
}
