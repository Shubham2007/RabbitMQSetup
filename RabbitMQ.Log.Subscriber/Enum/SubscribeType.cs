namespace RabbitMQ.Log.Subscriber.Enum
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
