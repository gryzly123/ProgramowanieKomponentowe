using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Nancy;
using Nancy.ModelBinding;  // for JSON magic
using Nancy.Responses;

namespace LightREST
{
	public class BadgeModule : Nancy.NancyModule
	{
		// The interface to the Badges service is defined in its constructor.
		// note the parameter to the base to set the root for this service to http://localhost:8088/Badges
		// you could make it /API/Badges 

		public BadgeModule() : base("/Badges")
		{
			// TODO: Think about versioning. This would mean replacing the strings below
			// eg. Get["/{id}"] = ... to Get["/1.0/{id}"] = ... or Get["/V1/{id}"] = ... etc.

			// http://localhost:8088/Badges
			Get["/"] = parameter => { return GetAll(); };

			// http://localhost:8088/Badges/99
			Get["/{id}"] = parameter => { return GetById(parameter.id); };

			// http://localhost:8088/Badges       POST: Badge JSON in body
			Post["/"] = parameter => { return this.AddBadge(); };

			// http://localhost:8088/Badges/99    PUT: Badge JSON in body
			Put["/{id}"] = parameter => { return this.UpdateBadge(parameter.id); };

			// http://localhost:8088/Badges/99    DELETE:  
			Delete["/{id}"] = parameter => { return this.DeleteBadge(parameter.id); };
		}

		// Below is the implementation.

		private object GetAll()
		{
			try
			{
				// create a connection to the PetaPoco orm and try to fetch and object with the given Id
				BadgeContext ctx = new BadgeContext();
				// Get all (or rather the first 999) objects
                IList<Badge> res = ctx.Get(999, 0, ""); // future development parameters are: top, from, filter
				// Nancy will convert this into an array of JSON objects.
                return res;
			}
			catch (Exception e)
			{
				return HandleException(e, String.Format("BadgesModule.GetAll()"));
			}
		}

		// GET /Badges/99
		private object GetById(int id)
		{
			try
			{
				// create a connection to the PetaPoco orm and try to fetch and object with the given Id
				BadgeContext ctx = new BadgeContext();
				Badge res = ctx.GetById(id);
				if (res == null)   // a null return means no object found
				{
					// return a reponse conforming to REST conventions: a 404 error
					return ErrorBuilder.ErrorResponse(this.Request.Url.ToString(), "GET", HttpStatusCode.NotFound, String.Format("A Badge with Id = {0} does not exist", id));
				}
				else
				{
					// success. The Nancy server will automatically serialise this to JSON
					return res;
				}
			}
			// Please, please handle exceptions in a way that provides information about the context of the error.
			catch (Exception e)
			{
				return HandleException(e, String.Format("BadgesModule.GetById({0})", id));
			}
		}

		// POST /Badges
		Nancy.Response AddBadge()
		{
			// debug code only
			// capture actual string posted in case the bind fails (as it will if the JSON is bad)
			// need to do it now as the bind operation will remove the data
			String rawBody = this.GetBodyRaw(); 

			Badge badge = null;
			try
			{
				// bind the request body to the object via a Nancy module.
				badge = this.Bind<Badge>();

				// check exists. Return 409 if it does
				if (badge.Id > 0)
				{
					return ErrorBuilder.ErrorResponse(this.Request.Url.ToString(), "POST", HttpStatusCode.Conflict, String.Format("Use PUT to update an existing Badge with Id = {0}", badge.Id));
				}

				BadgeContext ctx = new BadgeContext();
				ctx.Add(badge);

				// 201 - created
				Nancy.Response response = new Nancy.Responses.JsonResponse<Badge>(badge, new DefaultJsonSerializer());
				response.StatusCode = HttpStatusCode.Created;
				// uri
				string uri = this.Request.Url.SiteBase + this.Request.Path + "/" + badge.Id.ToString();
				response.Headers["Location"] = uri;

				return response;
			}
			catch (Exception e)
			{
				Console.WriteLine(rawBody);
				String operation = String.Format("BadgesModule.AddBadge({0})", (badge == null) ? "No Model Data" : badge.Title);
				return HandleException(e, operation);
			}
		}


		// put /Badges/1
		// http://stackoverflow.com/questions/2342579/http-status-code-for-update-and-delete 
		Nancy.Response UpdateBadge(int id)
		{
			Badge badge = null;
			try
			{
				// bind the request body to the object
				badge = this.Bind<Badge>();

				BadgeContext ctx = new BadgeContext();

				badge.Id = id;
				Badge res = ctx.GetById(id);
				if (res == null)
				{
					return 404;
				}

				ctx.update(badge);
				return 204; // no content response
			}
			catch (Exception e)
			{
				String operation = String.Format("BadgesModule.UpdateBadge({0})", (badge == null) ? "No Model Data" : badge.Title);
				return HandleException(e, operation);
			}
		}

		// DELETE /Badge/5
		Nancy.Response DeleteBadge(int id)
		{
			try
			{
				BadgeContext ctx = new BadgeContext();
				Badge res = ctx.GetById(id);

				if (res == null)
				{
					return ErrorBuilder.ErrorResponse(this.Request.Url.ToString(), "DELETE", HttpStatusCode.NotFound, String.Format("A Badge with Id = {0} does not exist", id));
				}
				Badge ci = new Badge();
				ci.Id = id;
				ctx.delete(ci);
				return 204;
			}
			catch (Exception e)
			{
				return HandleException(e, String.Format("\nBadgeController.Delete({0})", id));
			}
		}

		Nancy.Response HandleException(Exception e, String operation)
		{
			// we were trying this operation
			String errorContext = String.Format("{1}:{2}: {3} Exception caught in: {0}", operation, DateTime.UtcNow.ToShortDateString(), DateTime.UtcNow.ToShortTimeString(),e.GetType()); 
			// write detail to the server log. 
			Console.WriteLine("----------------------\n{0}\n{1}\n--------------------", errorContext, e.Message);
			if (e.InnerException != null)
				Console.WriteLine("{0}\n--------------------", e.InnerException.Message);
			// but don't be tempted to return detail to the caller as it is a breach of security.
			return ErrorBuilder.ErrorResponse(this.Request.Url.ToString(), "GET", HttpStatusCode.InternalServerError, "Operational difficulties");
		}

		private String GetBodyRaw()
		{
			// discover the body as a raw string
			byte[] b = new byte[this.Request.Body.Length];
			this.Request.Body.Read(b, 0, Convert.ToInt32(this.Request.Body.Length));
			System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
			String bodyData = encoding.GetString(b);
			return bodyData;
		}


	}
}
