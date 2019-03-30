using System;
using Nancy.Hosting.Self;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace Server
{
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
