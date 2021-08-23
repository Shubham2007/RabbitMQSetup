using RabbitMQ.Publisher.Contracts;
using RabbitMQ.Publisher.Enum;
using RabbitMQ.Publisher.RabbitMQ.Publishers;

namespace RabbitMQ.Publisher.RabbitMQ
{
    static class PublisherFactory
    {
        internal static IPublisher GetPublisher(PublishType publishType)
            => publishType switch
            {
                PublishType.WorkQueue => new QueuePublisher(),
                PublishType.DirectExchange => new DirectExchangePublisher(),
                PublishType.TopicExchange => new TopicExchangePublisher(),
                _ => new QueuePublisher()
            };            
    }
}
