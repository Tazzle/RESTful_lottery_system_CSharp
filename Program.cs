using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace LotteryApiServer
{
	class MainClass
	{
		static readonly Uri _baseAddress = new Uri("http://localhost:8080");

		public static void Main(string[] args)
		{
			HttpSelfHostConfiguration config = new HttpSelfHostConfiguration(_baseAddress);

			config.Routes.MapHttpRoute(
			  name: "DefaultApi",
			  routeTemplate: "api/{controller}/{id}",
			  defaults: new { id = RouteParameter.Optional }
);

			var server = new HttpSelfHostServer(config);
			server.OpenAsync().Wait();
			Console.WriteLine("Web API Self hosted on " + _baseAddress + " Hit ENTER to exit...");
			Console.ReadLine();
			server.CloseAsync().Wait();

		}
	}
}
