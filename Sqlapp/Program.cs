using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sqlapp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                webBuilder.ConfigureAppConfiguration(config =>
                {
                    var settings = config.Build();
                    config.AddAzureAppConfiguration("Endpoint=https://appconfig0001.azconfig.io;Id=Nb32-l0-s0:k1pKUMrZZ8BnLZZ5YBcU;Secret=tGfUsAp9vEjDq+RKdO1bUTJUwPe0G1Fw3sF/Aug7eL0=");
                })
                   .UseStartup<Startup>());
    }
}
