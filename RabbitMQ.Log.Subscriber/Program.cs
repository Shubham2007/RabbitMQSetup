using RabbitMQ.Client;
using RabbitMQ.Log.Subscriber.Enum;
using RabbitMQ.Log.Subscriber.RabbitMQ.Connection;
using System;
using static RabbitMQ.Log.Subscriber.RabbitMQ.PublisherFactory;

namespace RabbitMQ.Log.Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Channel
            using IModel channel = new ChannelFactory().CreateChannel();

            //Subscribe to Queue/Exchange
            GetSubscriber(SubscribeType.TopicExchange).Subscribe(channel);

            Console.ReadKey();
        }
    }
}
