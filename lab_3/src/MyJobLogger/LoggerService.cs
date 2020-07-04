using System;
using System.IO;
using System.Text;
using NATS.Client;
using NATS.Client.Rx;
using NATS.Client.Rx.Ops;
using System.Linq;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;

namespace Subscriber
{
    public class LoggerService
    {
        
        private IConfigurationRoot config;

        public string getDatabaseData(string id)
        {
            var config = new ConfigurationBuilder()  
                        .SetBasePath(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.FullName + "/config")  
                        .AddJsonFile("shipitsynConfig.json", optional: false)  
                        .Build(); 
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect($"localhost:{config.GetValue<int>("Redis:port")}");
            IDatabase db = redis.GetDatabase();
            return db.StringGet(id);
        }

        public void writeLogs(string id)
        {
            string redisVal = getDatabaseData(id);
            Console.WriteLine("Id: " + id + ", Value: " + redisVal);
        }

        public void Run(IConnection connection)
        {
            var greetings = connection.Observe("events")
                    .Select(m => Encoding.Default.GetString(m.Data));

            greetings.Subscribe(msg => writeLogs(msg));
        }    
    }
}