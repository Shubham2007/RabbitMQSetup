using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Publisher.Enum;
using RabbitMQ.Publisher.RabbitMQ.Connection;
using System.Text;
using System.Threading;
using static RabbitMQ.Publisher.RabbitMQ.PublisherFactory;

namespace RabbitMQ.Publisher
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;

            // Channel
            using IModel channel = new ChannelFactory().CreateChannel();
         
            while (true)
            {
                Thread.Sleep(3000);

                // Message
                byte[] message = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(new { Id = ++id, Name = "Shubham", Age = 25 }));

                //Publish Message
                GetPublisher(PublishType.TopicExchange).PublishMessage(channel, message);
            }
            
            //Console.ReadKey();
        }
    }
}
