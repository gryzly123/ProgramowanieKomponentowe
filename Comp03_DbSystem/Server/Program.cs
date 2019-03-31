using System;
using Nancy;
using Nancy.Extensions;
using Nancy.Hosting.Self;

namespace Server
{
    public static class Json
    {
        public static dynamic Parse(string Json) { return Newtonsoft.Json.JsonConvert.DeserializeObject(Json); }
        public static dynamic Parse(Request Req) { return Newtonsoft.Json.JsonConvert.DeserializeObject(Req.Body.AsString()); }
    }

    public static class ErrCode
    {
        public const string NotFoundCode = "not_found";
        public const string InternalErrorCode = "internal_error";
        public const string UpdateFailed = "update_failed";
        public const string ParseError = "value_parse_error";
    }

    class Program
    {
        private const string Domain = "http://localhost:31415";

        static void Main(string[] args)
        {
            HostConfiguration Config = new HostConfiguration()
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };

            NancyHost NancyServer = new NancyHost(
                new Uri(Domain),
                new DefaultNancyBootstrapper(),
                Config);

            NancyServer.Start();

            Console.WriteLine("Initialized server on " + Domain);
            Console.WriteLine("Press enter to kill process.");
            Console.ReadLine();
            NancyServer.Stop();
        }
    }
}
