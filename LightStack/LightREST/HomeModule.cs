using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LightREST
{
	// Index module to handle / and basically testing from a browser 
	public class IndexModule : Nancy.NancyModule
	{
		public IndexModule() 
		{
            // http://localhost:8088/
            Get["/"] = parameter =>
            {
				return IndexPage;
            };
		}

		const String IndexPage = @"
<html><body>
<h1>Yep. The server is running</h1>
</body></html>
";
	}
}
