using RabbitMQ.Client;

namespace RabbitMQ.Publisher.Contracts
{
    interface IChannelFactory
    {
        IModel CreateChannel();
    }
}
