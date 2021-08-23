using RabbitMQ.Client;

namespace RabbitMQ.Log.Subscriber.Contracts
{
    interface IChannelFactory
    {
        IModel CreateChannel();
    }
}
