using RabbitMQ.Client;
using RabbitMQ.Publisher.Contracts;

namespace RabbitMQ.Publisher.RabbitMQ.Publishers
{
    class QueuePublisher : IPublisher
    {
        public void PublishMessage(IModel channel, byte[] message)
        {
            channel.QueueDeclare("demoqueue", durable: true, exclusive: false, autoDelete: false);
            channel.BasicPublish(string.Empty, "demoqueue", body: message);
        }
    }
}
