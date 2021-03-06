using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;

namespace BackendApi
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
                {
                    var config = new ConfigurationBuilder()  
                        .SetBasePath(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.FullName + "/Config")  
                        .AddJsonFile("shipitsynConfig.json", optional: false)  
                        .Build(); 
                    webBuilder.ConfigureKestrel(options =>
                    {
                        // Setup a HTTP/2 endpoint without TLS.
                        options.ListenLocalhost(config.GetValue<int>("BackendApi:port"), o => o.Protocols = HttpProtocols.Http2);
                    });

                    webBuilder.UseStartup<Startup>();
                });

    }
}
