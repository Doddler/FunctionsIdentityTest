
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
    public static class Function1
    {
        [FunctionName("Function1")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)]HttpRequest req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

	        var options = new DbContextOptionsBuilder<TestDbIdentityContext>();
	        options.UseInMemoryDatabase("TestingIdentityDB");

	        using (var context = new TestDbIdentityContext(options.Options))
	        {

	        }

			return new OkResult();
        }
    }
}
