using System;

namespace RestServer
{
	public class IndexModule : Nancy.NancyModule
	{
		public IndexModule()
		{
			// http://localhost:8088 ie. Home page. Used just for ping purposes in this server
			Get["/"] = parameter =>
			{
				return IndexPage;
			};
		}

		const String IndexPage = @"
<html><body>
<h1>Yehaw. The server is running</h1>
</body></html>
";
	}
}
