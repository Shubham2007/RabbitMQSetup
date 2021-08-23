using RabbitMQ.Client;

namespace RabbitMQ.Log.Subscriber.Contracts
{
    interface ISubscriber
    {
        void Subscribe(IModel channel);
    }
}
