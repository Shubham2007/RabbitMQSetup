using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Subscriber.Contracts;
using System;
using System.Text;

namespace RabbitMQ.Subscriber.RabbitMQ.Subscribers
{
    class TopicExchangeSubscriber : ISubscriber
    {
        public void Subscribe(IModel channel)
        {
            channel.ExchangeDeclare("demotopicexchange", ExchangeType.Topic, durable: true);
            string queueName = channel.QueueDeclare("topicexchangequeue", durable: true, exclusive: false, autoDelete: false).QueueName;
            channel.QueueBind(queue: queueName,
                              exchange: "demotopicexchange",
                              routingKey: "demo.topic.*");

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(" [x] Received {0}", message);
            };

            channel.BasicConsume(queue: queueName,
                                 autoAck: true,
                                 consumer: consumer);
        }
    }
}
