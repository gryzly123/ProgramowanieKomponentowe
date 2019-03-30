using System.Collections.Generic;
using Nancy;

namespace Server
{
    public class UserModule : NancyModule
    {
        public UserModule() : base("/User")
        {
            Get["/{id}"] = parameter => { return GetById(parameter.id); };
            Get["/all"] = parameter =>  { return GetAll(); };
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

            List<Dictionary<string, string>> result = new List<Dictionary<string, string>>();

            foreach (Backend.User u in db.Query<Backend.User>(Backend.User.sqlGetAll()))
            {
                Dictionary<string, string> userdict = new Dictionary<string, string>();
                userdict.Add("id", u.Id.ToString());
                userdict.Add("username", u.Username);
                result.Add(userdict);
            }

            if(result.Count == 0) return new { error = "no_users" };
            return result;
        }
    }
}
