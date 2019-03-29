using System;

// Note: The RestServer project is deliberatly supplied incomplete. Refer to the 
// Codeproject article. Add the two "Module" .CS files to the project in order to
// implement the html message and stubbed REST Url

// dont forget to run  netsh http add urlacl url=http://+:8088/ user=Everyone
// http://msdn.microsoft.com/en-us/library/ms733768.aspx for some sort of explanation

namespace RestServer
{
	class Program
	{
		// your choice.
		const string DOMAIN = "http://localhost:8088";

		static void Main(string[] args)
		{
			// create a new self-host server
			var nancyHost = new Nancy.Hosting.Self.NancyHost(new Uri(DOMAIN));
			// start
			nancyHost.Start();
			Console.WriteLine("LightREST service listening on " + DOMAIN);
			// stop with an <Enter key press>
			Console.ReadLine();
			nancyHost.Stop();
		}
	}
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
