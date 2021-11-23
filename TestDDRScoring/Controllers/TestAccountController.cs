using DDRScoring;
using DDRScoring.Data.Entities;
using DDRScoring.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestDDRScoring.Controllers
{
    [TestClass]
    public class TestAccountController : TestBase
    {
        private static IWebHostBuilder webHostBuilder;
        private static TestServer server;
        private static HttpClient client;

        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            webHostBuilder = new WebHostBuilder()
                .ConfigureAppConfiguration((ctx, builder) => {
                    builder.Sources.Clear();
                    builder.AddJsonFile("config.json", false, true)
                           .AddEnvironmentVariables();
                })
                .UseStartup<Startup>();
            server = new TestServer(webHostBuilder);
            client = server.CreateClient();
        }

        [TestMethod]
        public async Task TestAccountTest()
        {
            var result = await client.GetStringAsync("/api/account");

            Assert.AreEqual(result, "HelloWorld!!!");
        }


        [TestMethod]
        public async Task TestCreateTokenNotExist()
        {
            var data = new LoginViewModel() { Email = "email@unknow.fr", Password = "motdepassbidon" };
            var httpContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await client.PostAsync("/api/account", httpContent);

            Assert.AreEqual(System.Net.HttpStatusCode.BadRequest, result.StatusCode);
        }

        [TestMethod]
        public async Task TestCreateTokenExist()
        {
            var data = new LoginViewModel() { Email = "contact@sylvrec.com", Password = "P@$$w0rd!" };
            var httpContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await client.PostAsync("/api/account", httpContent);
            Assert.AreEqual(System.Net.HttpStatusCode.Created, result.StatusCode);
        }
    }
}
