using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.IO;
using FrontendTask;

namespace PostForm
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


                    webBuilder.UseUrls($"https://localhost:{config.GetValue<int>("FrontendTask:port")}");
                    webBuilder.UseStartup<Startup>();
                });
    }
}
