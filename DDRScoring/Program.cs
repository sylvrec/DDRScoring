using DDRScoring.Data;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DDRScoring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = BuildWebHost(args);
            if (args.Length > 0)
            {
                bool seed = args.Any(arg => arg == "/seed");
                if (seed)
                {
                    RunSeeding(host);
                }
            }
            else
            {
                host.Run();
            }
        }

        private static void RunSeeding(IWebHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
            using (var scope = scopeFactory.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetService<DDRScoringSeeder>();
                seeder.SeedAsync().Wait();
            }
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((ctx, builder) => {
                builder.Sources.Clear();
                builder.AddJsonFile("config.json", false, true)
                       .AddEnvironmentVariables();
            })
            .UseStartup<Startup>()
            .Build();
    }
}
