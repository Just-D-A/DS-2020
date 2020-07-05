using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;
using NATS.Client;
using System.Threading;

namespace BackendApi.Services
{
    public class JobService : Job.JobBase
    {
        private readonly static Dictionary<string, string> _jobs = new Dictionary<string, string>();
        private readonly ILogger<JobService> _logger;
    

        public JobService(ILogger<JobService> logger)
        {
            _logger = logger;
          
        }
        private IDatabase setDatabase() {
            var config = new ConfigurationBuilder()  
                .SetBasePath(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.FullName + "/config")  
                .AddJsonFile("shipitsynConfig.json", optional: false)  
                .Build();
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect($"localhost:{config.GetValue<int>("Redis:port")}");
            return redis.GetDatabase();
        }
        public override Task<RegisterResponse> Register(RegisterRequest request, ServerCallContext context)
        {
            string id = Guid.NewGuid().ToString();
            string descriptionId = id + "_val";
            string textId = id + "_text";
            string description = request.Description;
            string text = request.Text;
             //Console.WriteLine("Text: " + text);
           
            addToDatabase(descriptionId, description);
            addToDatabase(textId, text);
            publishVal(id);
            publishText(id);

            var resp = new RegisterResponse()
            {
                Id = id, 
                Text = text
            };
            _jobs[id] = description;
            return Task.FromResult(resp);
        }

        private void publishText(string id)
        {
            IConnection connection = new ConnectionFactory().CreateConnection(ConnectionFactory.GetDefaultOptions());
            byte[] payload = Encoding.Default.GetBytes(id);
            connection.Publish("JobCreated", payload);
        }

        public void publishVal(string id) 
        {
            IConnection connection = new ConnectionFactory().CreateConnection(ConnectionFactory.GetDefaultOptions());
            byte[] payload = Encoding.Default.GetBytes(id);
            connection.Publish("events", payload);
        }

        public void addToDatabase(string id, string value)
        {
            IDatabase db = setDatabase(); 
            db.StringSet(id, value);
        }

        private string getById(string id)
        {
            IDatabase db = setDatabase(); 
            return db.StringGet(id);
        }

        public override Task<ProcessingResult> GetProcessingResult(RegisterResponse registerResponse, ServerCallContext context)
        {
            string idResult = registerResponse.Id + "_rating";
            var result = new ProcessingResult {Status = "Processing", Response = "no response"};
            
            for (int i = 0; i < 3; i++)
            {
                string response = getById(idResult);
                if (response != null) {
                    result.Status = "Completed";
                    result.Response = response;
                    break;
                }
                Thread.Sleep(1000);
            }
            return Task.FromResult(result);
        }
    }
}
