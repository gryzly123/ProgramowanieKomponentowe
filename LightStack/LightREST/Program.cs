using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightREST
{
	/*
		The main program creates self-hosting Nancy REST server. The Nancy module
		will search thie assembly for types inherited from Nancy.NancyModule and 
		automatically route requests to them following coding by convention.
	*/
	class Program
	{
		// Your choice.
		const string DOMAIN = "http://localhost:8088";

		// Minimum lines to get the server listening.
		static void Main(string[] args)
		{
			// create a new self-host server
			var nancyHost = new Nancy.Hosting.Self.NancyHost(new Uri(DOMAIN));
			// start
			nancyHost.Start();
			Console.WriteLine("Badges service listening on " + DOMAIN);
			// stop with an <Enter key press>
			Console.ReadLine();
			nancyHost.Stop();
		}
	}

	// utterly basic configuration of the Nancy server. Other configuration not researched.
	public class Bootstrapper : Nancy.DefaultNancyBootstrapper
	{
		protected virtual Nancy.Bootstrapper.NancyInternalConfiguration InternalConfiguration
		{
			get
			{
				return Nancy.Bootstrapper.NancyInternalConfiguration.Default;
			}
		}
	}
		

}
