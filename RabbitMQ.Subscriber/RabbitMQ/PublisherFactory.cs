using RabbitMQ.Subscriber.Contracts;
using RabbitMQ.Subscriber.Enum;
using RabbitMQ.Subscriber.RabbitMQ.Subscribers;

namespace RabbitMQ.Subscriber.RabbitMQ
{
    static class PublisherFactory
    {
        internal static ISubscriber GetSubscriber(SubscribeType publishType)
            => publishType switch
            {
                SubscribeType.WorkQueue => new QueueSubscriber(),
                SubscribeType.DirectExchange => new DirectExchangeSubscriber(),
                SubscribeType.TopicExchange => new TopicExchangeSubscriber(),
                _ => new QueueSubscriber()
            };            
    }
}
