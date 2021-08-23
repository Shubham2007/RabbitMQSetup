namespace RabbitMQ.Publisher.Enum
{
    enum PublishType : int
    {
        WorkQueue,
        DirectExchange,
        TopicExchange,
        HeaderExchange,
        FanoutExchange
    }
}
