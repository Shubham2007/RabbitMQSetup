using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using RabbitMQ.Subscriber.Contracts;
using System;
using System.Text;

namespace RabbitMQ.Subscriber.RabbitMQ.Subscribers
{
    class QueueSubscriber : ISubscriber
    {
        public void Subscribe(IModel channel)
        {
            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (sender, ea) =>
            {
                byte[] body = ea.Body.ToArray();
                string message = Encoding.UTF8.GetString(body);
                Console.WriteLine(" [x] Received {0}", message);

                channel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            };

            channel.BasicConsume(queue: "demoqueue",
                                 autoAck: false,
                                 consumer: consumer);
        }
    }
}
