using RabbitMQ.Client;

namespace RabbitMQ.Subscriber.Contracts
{
    interface ISubscriber
    {
        void Subscribe(IModel channel);
    }
}
