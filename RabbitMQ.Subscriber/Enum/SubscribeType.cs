namespace RabbitMQ.Subscriber.Enum
{
    enum SubscribeType : int
    {
        WorkQueue,
        DirectExchange,
        TopicExchange,
        HeaderExchange,
        FanoutExchange
    }
}
