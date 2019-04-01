using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Frontend
{
    public class Api
    {
        private string Server;

        public Api(string _Server)
        {
            Server = _Server;
        }

        public static dynamic Parse(string Json) { return Newtonsoft.Json.JsonConvert.DeserializeObject(Json); }

        private dynamic Request(string Url, string Method, string Body)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Accept = "application/json";
            request.Method = Method;
            bool bIsGet = Method.ToUpper().Equals("GET");

            try
            {
                if(!bIsGet)
                {
                    request.AllowWriteStreamBuffering = true;

                    byte[] bytes = Encoding.UTF8.GetBytes(Body);
                    request.ContentLength = bytes.Length;
                    using (Stream requestStream = request.GetRequestStream())
                        requestStream.Write(bytes, 0, bytes.Length);
                }

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string ResponseBody = reader.ReadToEnd();
                reader.Close();

                response.Close();
                return Parse(ResponseBody);
            }
            catch (System.Net.WebException e)
            {
                return null;
            }
        }

        public List<Backend.User> GetUsers(out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/User/all", Server),
                "GET",
                "");

            List<Backend.User> result = new List<Backend.User>();

            foreach (JObject o in ObjectArray)
            {
                Backend.User u = new Backend.User();
                u.Id = Int32.Parse(o.GetValue("id").ToString());
                u.Username = o.GetValue("username").ToString();
                result.Add(u);
            }

            Error = "not implemented";
            return result;
        }

        public bool UpdateUser(Backend.User User, out string Error)
        {
            JObject req = new JObject();
            req.Add("username", User.Username);

            dynamic ObjectArray = Request(
                string.Format("{0}/User/{1}", Server, User.Id),
                "PUT",
                req.ToString());

            if (ObjectArray == null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }

        public bool AddUser(Backend.User User, out string Error)
        {
            JObject req = new JObject();
            req.Add("username", User.Username);

            dynamic ObjectArray = Request(
                string.Format("{0}/User/add", Server),
                "POST",
                req.ToString());

            if (ObjectArray["ok"] != null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }
        public bool DeleteUser(Backend.User User, out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/User/{1}", Server, User.Id),
                "DELETE",
                "");

            if (ObjectArray == null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }

        public List<Backend.Tasklist> GetTasklists(out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/Tasklist/all", Server),
                "GET",
                "");

            List<Backend.Tasklist> result = new List<Backend.Tasklist>();

            foreach (JObject o in ObjectArray)
            {
                Backend.Tasklist t = new Backend.Tasklist();
                t.Id = Int32.Parse(o.GetValue("id").ToString());
                t.Name = o.GetValue("name").ToString();
                t.Deadline = Int32.Parse(o.GetValue("deadline").ToString());
                result.Add(t);
            }

            Error = "not implemented";
            return result;
        }

        public List<Backend.Task> GetTasks(out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/Task/all", Server),
                "GET",
                "");

            List<Backend.Task> result = new List<Backend.Task>();

            foreach (JObject o in ObjectArray)
            {
                Backend.Task t = new Backend.Task();
                t.Id = Int32.Parse(o.GetValue("id").ToString());
                t.Name = o.GetValue("name").ToString();
                t.Description = o.GetValue("description").ToString();
                t.Deadline = Int32.Parse(o.GetValue("deadline").ToString());
                t.Status = Int32.Parse(o.GetValue("status").ToString());
                t.Owner_Tasklist = Int32.Parse(o.GetValue("owner_Tasklist").ToString());
                t.Assignee_User = Int32.Parse(o.GetValue("assignee_User").ToString());
                result.Add(t);
            }

            Error = "not implemented";
            return result;
        }
    }
}
