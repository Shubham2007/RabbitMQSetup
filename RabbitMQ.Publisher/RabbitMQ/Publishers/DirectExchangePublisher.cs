using RabbitMQ.Client;
using RabbitMQ.Publisher.Contracts;

namespace RabbitMQ.Publisher.RabbitMQ.Publishers
{
    class DirectExchangePublisher : IPublisher
    {
        public void PublishMessage(IModel channel, byte[] message)
        {
            //channel.ExchangeDeclare("demodirectexchange", ExchangeType.Direct, durable: true);
            channel.BasicPublish("demodirectexchange", routingKey: "demo.direct.key", body: message);
        }
    }
}
