using DDRScoring;
using DDRScoring.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TestDDRScoring.Controllers
{
    [TestClass]
    public class TestDDRFileController : TestBase
    {
        private static IWebHostBuilder _webHostBuilder;
        private static TestServer _server;
        private static HttpClient _client;
        private static string _token;

        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            _webHostBuilder = new WebHostBuilder()
                .ConfigureAppConfiguration((ctx, builder) => {
                    builder.Sources.Clear();
                    builder.AddJsonFile("config.json", false, true)
                           .AddEnvironmentVariables();
                })
                .UseStartup<Startup>();
            _server = new TestServer(_webHostBuilder);
            _client = _server.CreateClient();
            var data = new LoginViewModel() { Email = "contact@sylvrec.com", Password = "P@$$w0rd!" };
            var httpContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = _client.PostAsync("/api/account", httpContent)
                .Result;
            var message = response.Content.ReadAsStringAsync().Result;
            var auth = JsonConvert.DeserializeObject<AuthViewModel>(message);
            _token = auth.token;
        }

        [TestMethod]
        public async Task TestPostAsync()
        {
            var xmlStat = File.ReadAllText(@"C:\Projects\olympp\DDRScoringOlympp\TestDDRScoring\Ressources\Stats.xml");
            var httpContent = new StringContent(xmlStat, Encoding.UTF8);
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/xml");
            var result = await _client.PostAsync("/api/ddrfile", httpContent);
            Assert.AreEqual(System.Net.HttpStatusCode.OK, result.StatusCode);
        }

    }
}
