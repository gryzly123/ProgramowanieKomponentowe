
namespace RestServer
{
	/*
		Very simple implementation of a REST module that returns a JSON object
	*/ 
	public class BadgeModule : Nancy.NancyModule
	{
		public BadgeModule() : base("/Badges")
		{
			// http://localhost:8088/Badges/99
			Get["/{id}"] = parameter => { return GetById(parameter.id); };
		}

		private object GetById(int id)
		{
			// fake a return
			return new {Id = id, Title="Valued member", Level=3};
		}
	}
}
