using Backend;
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
            catch (System.Net.WebException)
            {
                return null;
            }
        }

        #region User
        public List<User> GetUsers(out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/User/all", Server),
                "GET",
                "");

            if (ObjectArray == null) { Error = "no_response"; return null; }

            List<User> result = new List<User>();
            try
            {
                foreach (JObject o in ObjectArray)
                {
                    User u = new User();
                    u.Id = Int32.Parse(o.GetValue("id").ToString());
                    u.Username = o.GetValue("username").ToString();
                    result.Add(u);
                }

                Error = "";
                return result;
            }
            catch (Exception)
            {
                Error = "invalid_response";
                return null;
            }
        }
        public bool AddUser(User User, out string Error)
        {
            JObject req = new JObject();
            req.Add("username", User.Username);

            dynamic ObjectArray = Request(
                string.Format("{0}/User/add", Server),
                "POST",
                req.ToString());

            if (ObjectArray == null) { Error = "no_response"; return false; }

            if (ObjectArray["ok"] != null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }
        public bool UpdateUser(User User, out string Error)
        {
            JObject req = new JObject();
            req.Add("username", User.Username);

            dynamic ObjectArray = Request(
                string.Format("{0}/User/{1}", Server, User.Id),
                "PUT",
                req.ToString());


            if (ObjectArray == null) { Error = "no_response"; return false; }

            if (ObjectArray["ok"] != null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }


        public bool DeleteUser(User User, out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/User/{1}", Server, User.Id),
                "DELETE",
                "");

            if (ObjectArray["ok"] != null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }
        #endregion

        #region Tasklist
        public List<Tasklist> GetTasklists(out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/Tasklist/all", Server),
                "GET",
                "");

            if (ObjectArray == null) { Error = "no_response"; return null; }

            try
            {
                List<Tasklist> result = new List<Tasklist>();
                foreach (JObject o in ObjectArray)
                {
                    Tasklist t = new Tasklist();
                    t.Id = Int32.Parse(o.GetValue("id").ToString());
                    t.Name = o.GetValue("name").ToString();
                    t.Deadline = Int32.Parse(o.GetValue("deadline").ToString());
                    result.Add(t);
                }

                Error = "";
                return result;
            }
            catch (Exception)
            {
                Error = "invalid_response";
                return null;
            }
        }
        public bool AddTasklist(Tasklist Tasklist, out string Error)
        {
            JObject req = new JObject();
            req.Add("name", Tasklist.Name);
            req.Add("deadline", Tasklist.Deadline);

            dynamic ObjectArray = Request(
                string.Format("{0}/Tasklist/add", Server),
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
        public bool UpdateTasklist(Tasklist Tasklist, out string Error)
        {
            JObject req = new JObject();
            req.Add("name", Tasklist.Name);
            req.Add("deadline", Tasklist.Deadline);

            dynamic ObjectArray = Request(
                string.Format("{0}/Tasklist/{1}", Server, Tasklist.Id),
                "PUT",
                req.ToString());

            if (ObjectArray == null) { Error = "no_response"; return false; }

            if (ObjectArray["ok"] != null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }
        public bool DeleteTasklist(Tasklist Tasklist, out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/Tasklist/{1}", Server, Tasklist.Id),
                "DELETE",
                "");

            if (ObjectArray["ok"] != null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }
        #endregion
        
        #region Task
        public List<Task> GetTasks(out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/Task/all", Server),
                "GET",
                "");

            if (ObjectArray == null) { Error = "no_response"; return null; }

            try
            {
                List<Task> result = new List<Task>();
                foreach (JObject o in ObjectArray)
                {
                    Task t = new Task();
                    t.Id = Int32.Parse(o.GetValue("id").ToString());
                    t.Name = o.GetValue("name").ToString();
                    t.Description = o.GetValue("description").ToString();
                    t.Deadline = Int32.Parse(o.GetValue("deadline").ToString());
                    t.Status = Int32.Parse(o.GetValue("status").ToString());
                    t.Owner_Tasklist = Int32.Parse(o.GetValue("owner_Tasklist").ToString());
                    t.Assignee_User = Int32.Parse(o.GetValue("assignee_User").ToString());
                    result.Add(t);
                }

                Error = "";
                return result;
            }
            catch (Exception)
            {
                Error = "invalid_response";
                return null;
            }
        }
        public bool AddTask(Task Task, out string Error)
        {
            JObject req = new JObject();
            req.Add("name", Task.Name);
            req.Add("description", Task.Description);
            req.Add("status", Task.Status);
            req.Add("deadline", Task.Deadline);
            req.Add("assignee_user", Task.Assignee_User);
            req.Add("owner_tasklist", Task.Owner_Tasklist);

            dynamic ObjectArray = Request(
                string.Format("{0}/Task/add", Server),
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
        public bool UpdateTask(Task Task, out string Error)
        {
            JObject req = new JObject();
            req.Add("name", Task.Name);
            req.Add("description", Task.Description);
            req.Add("status", Task.Status);
            req.Add("deadline", Task.Deadline);
            req.Add("assignee_user", Task.Assignee_User);
            req.Add("owner_tasklist", Task.Owner_Tasklist);

            dynamic ObjectArray = Request(
                string.Format("{0}/Task/{1}", Server, Task.Id),
                "PUT",
                req.ToString());

            if (ObjectArray == null) { Error = "no_response"; return false; }

            if (ObjectArray["ok"] != null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }
        public bool DeleteTask(Task Task, out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/Task/{1}", Server, Task.Id),
                "DELETE",
                "");

            if (ObjectArray["ok"] != null)
            {
                Error = "";
                return true;
            }
            Error = ObjectArray["error"];
            return false;
        }
        #endregion
    }
}
