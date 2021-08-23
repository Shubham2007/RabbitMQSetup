using RabbitMQ.Client;

namespace RabbitMQ.Publisher.Contracts
{
    interface IPublisher
    {
        void PublishMessage(IModel channel, byte[] message);
    }
}
