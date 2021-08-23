using RabbitMQ.Client;

namespace RabbitMQ.Subscriber.Contracts
{
    interface IChannelFactory
    {
        IModel CreateChannel();
    }
}
