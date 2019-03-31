using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

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

        private dynamic Request(string Url, string Method)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Accept = "application/json";
            request.Method = Method;
            try
            {
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
                "GET");

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

        public List<Backend.Tasklist> GetTasklists(out string Error)
        {
            dynamic ObjectArray = Request(
                string.Format("{0}/Tasklist/all", Server),
                "GET");

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
                "GET");

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
