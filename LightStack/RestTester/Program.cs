using System;
using System.IO;
using System.Net;
using System.Text;

namespace RestTester
{
	class Program
	{
		// Code derived from http://msdn.microsoft.com/en-us/library/456dfw4f(v=vs.100).aspx
		// Arguments verb url post data
		// if 1 arg assume get
		static void Main(string[] args)
		{
			int argsL = args.Length;
			if (argsL == 1)
			{
				String testUrl1 = args[0];
				TestGet(testUrl1);
				return;
			}
			if (argsL == 0)
			{
				String help = @"
Usage is either:
RestTester Url 
   where a GET request is sent for the Url
or 
RestTester Verb Url [Jsondatafile]
   where Verb is GET POST PUT or DELETE
          Url is the Resource URL and
 Jsondatafile is a file containing the json data
";
				Console.WriteLine(help);
				return;
			}

			String verb = parseVerb(args[0]);
			if (String.IsNullOrWhiteSpace(verb))
			{
				String help = @"
when there is more than 1 parameter the first one is expected
to be either GET POST PUT or DELETE
";
				Console.WriteLine(help);
				return; // done
			}

			String testUrl = args[1];

			string jsonDataFileName = "";
			string jsonData = "";
			if (verb == "POST" || verb == "PUT")
			{
				if (argsL < 3)
				{
					String help = @"
when the verb is POST or PUT there should a third parameter giving
the name of the file that contains the data to be POSTed or PUT
in JSON.
";
					Console.WriteLine(help);
					return; // done
				
				}
				jsonDataFileName = args[2];
				bool fileIsGood = false;
				try
				{
					if (File.Exists(jsonDataFileName))
					{
						fileIsGood = true;
					}
				}
				catch (Exception) {} 

				if (!fileIsGood)
				{
					String help = @"
Parameter 3 is expected to be a the name of a file containing the datat
to be POSTed or PUT. 
{0} was not found.
		";
					String msg = String.Format(help, jsonDataFileName);
					Console.WriteLine(msg);
					return;
				}
				jsonData = ReadJsonData(jsonDataFileName);
			}

			switch (verb)
			{
				case "GET": TestGet(testUrl); break;
				case "POST": TestPost(testUrl, jsonData); break;
				case "PUT": TestPut(testUrl, jsonData); break;
				case "DELETE": TestDel(testUrl); break;
			}
		}

		private static string ReadJsonData(string jsonDataFileName)
		{
			String jsonData = "";
			using (StreamReader sr = File.OpenText(jsonDataFileName))
			{
				String input;
				while ((input = sr.ReadLine()) != null)
				jsonData += input;
				sr.Close();
			}
			return jsonData;
		}


		private static string parseVerb(string parm)
		{
			switch (parm.ToUpper())
			{
				case "G":
				case "GET": return "GET";
				case "P":
				case "POST": return "POST";
				case "PUT": return "PUT";
				case "D":
				case "DEL":
				case "DELETE": return "DELETE";
				default:
					return "";
			}
		}

		static void TestGet(String testUrl)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(testUrl);
			request.Accept = "application/json";
			try
			{
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				// Display the status.
				Console.WriteLine(((HttpWebResponse)response).StatusDescription);
				Console.WriteLine(ReadResponseData(response));
			}
			catch (System.Net.WebException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("for: {0}", testUrl);
			}
		}

		private static void TestPost(string testUrl, string jsonData)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(testUrl);
			request.AllowWriteStreamBuffering = true;
			request.Method = "POST";
			request.ContentType = "application/json";

			try
			{
				AddBodyContent(jsonData, request);

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();

				// Display the status.
				Console.WriteLine(((HttpWebResponse)response).StatusDescription);
				// write the resource uri

				// write the return data
				Console.WriteLine(ReadResponseData(response));
			}
			catch (System.Net.WebException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("for: {0}", testUrl);
			}
		}


		private static void TestPut(string testUrl, string jsonData)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(testUrl);
			request.AllowWriteStreamBuffering = true;
			request.Method = "PUT";
			request.ContentType = "application/json";

			try
			{
				AddBodyContent(jsonData, request);
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				// Display the status. 
				Console.WriteLine(((HttpWebResponse)response).StatusDescription);
			}
			catch (System.Net.WebException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("for: {0}", testUrl);
			}
		}

		private static void AddBodyContent(string jsonData, HttpWebRequest request)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(jsonData);
			request.ContentLength = bytes.Length;
			using (Stream requestStream = request.GetRequestStream())
			{
				requestStream.Write(bytes, 0, bytes.Length);
			}
		}


		private static void TestDel(string testUrl)
		{
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(testUrl);
			request.Accept = "application/json";
			request.Method = "DELETE";
			try
			{
				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				// Display the status.
				Console.WriteLine(((HttpWebResponse)response).StatusDescription);
			}
			catch (System.Net.WebException e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine("for: {0}", testUrl);
			}

		}

		static String ReadResponseData(HttpWebResponse response)
		{
			// Get the stream containing content returned by the server.
			Stream dataStream = response.GetResponseStream();
			// Open the stream using a StreamReader for easy access.
			StreamReader reader = new StreamReader(dataStream);
			// Read the content.
			string responseFromServer = reader.ReadToEnd();
			// Clean up the streams and the response.
			reader.Close();
			response.Close();
			return responseFromServer;
		}

	}
}
