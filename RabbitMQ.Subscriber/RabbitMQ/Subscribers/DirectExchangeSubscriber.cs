using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Subscriber.Contracts;
using System;
using System.Text;

namespace RabbitMQ.Subscriber.RabbitMQ.Subscribers
{
    class DirectExchangeSubscriber : ISubscriber
    {
        public void Subscribe(IModel channel)
        {
            channel.ExchangeDeclare("demodirectexchange", ExchangeType.Direct, durable: true);
            string queueName = channel.QueueDeclare("directexchangequeue", durable: true, exclusive: false, autoDelete: false).QueueName;
            channel.QueueBind(queue: queueName,
                              exchange: "demodirectexchange",
                              routingKey: "demo.direct.key");

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
