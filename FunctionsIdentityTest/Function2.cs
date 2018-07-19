
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FunctionsIdentityTest
{
	public static class Function2
	{
		[FunctionName("Function2")]
		public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
		{
			log.Info("C# HTTP trigger function processed a request.");

			var options = new DbContextOptionsBuilder<TestDbContext>();
			options.UseInMemoryDatabase("TestingDB");

			using (var context = new TestDbContext(options.Options))
			{

			}

			return new OkResult();
		}
	}
}
