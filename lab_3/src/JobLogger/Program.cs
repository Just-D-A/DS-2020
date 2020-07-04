using System;
using NATS.Client;
using Subscriber;

namespace JobLogger
{
    class Program
    {
        static void Main(string[] args)
        {
           var loggerservice = new LoggerService();

            try {
            using(IConnection connection = new ConnectionFactory().CreateConnection(ConnectionFactory.GetDefaultOptions())){
                loggerservice.Run(connection);
                Console.WriteLine("Logger tasks");
                Console.ReadKey();
            }
            } catch(NATS.Client.NATSNoServersException e) {
                Console.WriteLine("Not connected to NATS server");
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
