using RabbitMQ.Client;
using RabbitMQ.Publisher.Contracts;

namespace RabbitMQ.Publisher.RabbitMQ.Publishers
{
    class TopicExchangePublisher : IPublisher
    {
        public void PublishMessage(IModel channel, byte[] message)
        {
            channel.ExchangeDeclare("demotopicexchange", ExchangeType.Topic, durable: true);
            channel.BasicPublish("demotopicexchange", routingKey: "demo.topic.any", body: message);
        }
    }
}
