using RabbitMQ.Client;
using RabbitMQ.Subscriber.Enum;
using RabbitMQ.Subscriber.RabbitMQ.Connection;
using System;
using static RabbitMQ.Subscriber.RabbitMQ.PublisherFactory;

namespace RabbitMQ.Subscriber
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
