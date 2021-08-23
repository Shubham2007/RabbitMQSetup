using RabbitMQ.Log.Subscriber.Contracts;
using RabbitMQ.Log.Subscriber.Enum;
using RabbitMQ.Log.Subscriber.RabbitMQ.Subscribers;

namespace RabbitMQ.Log.Subscriber.RabbitMQ
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
