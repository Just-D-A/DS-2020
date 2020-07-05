using System;
using System.IO;
using System.Text;
using NATS.Client;
using NATS.Client.Rx;
using NATS.Client.Rx.Ops;
using System.Linq;
using Microsoft.Extensions.Configuration;
using StackExchange.Redis;
using System.Text.RegularExpressions;

namespace Subscriber
{
    public class RankService
    {
        
        private IConfigurationRoot config;
    

        public IDatabase setDataBase() {
            config = new ConfigurationBuilder()  
                .SetBasePath(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.FullName + "/config")  
                .AddJsonFile("shipitsynConfig.json", optional: false)  
                .Build();
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect($"localhost:{config.GetValue<int>("Redis:port")}");
            return redis.GetDatabase();
        }
        public string getById(string id)
        {
            IDatabase db = setDataBase();
            return db.StringGet(id);
        }

        public void setById(string id, string value)
        {
            IDatabase db = setDataBase();
            db.StringSet(id, value);
        }

        private int calcMessageRating(string message)
        {
            int countVowels = Regex.Matches(message, @"[aeiouаёеуоыиэюя]", RegexOptions.IgnoreCase).Count;
            int countConsonants = Regex.Matches(message, @"[bcdfghjklmnpqrstvwxyzбвгджзйклмнпрстфхцчшщ]", RegexOptions.IgnoreCase).Count;
            int result = countConsonants > 0 ? countVowels / countConsonants : 0;
            return result;
        }

        public void RankTask(string id)
        {
            string val = getById(id + "_text");
            int rating = calcMessageRating(val);
            id += "_rating";
            setById(id, rating.ToString());
            Console.WriteLine("text's: " + val + " rating is: " + rating.ToString());
        }

        public void Run(IConnection connection)
        {
            
            
            var greetings = connection.Observe("JobCreated")
                    .Select(m => Encoding.Default.GetString(m.Data));

            greetings.Subscribe(msg => RankTask(msg));
        }    
    }
}