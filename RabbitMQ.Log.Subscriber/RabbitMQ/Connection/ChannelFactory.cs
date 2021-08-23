using RabbitMQ.Client;
using RabbitMQ.Log.Subscriber.Contracts;

namespace RabbitMQ.Log.Subscriber.RabbitMQ.Connection
{
    class ChannelFactory : IChannelFactory
    {
        public IModel CreateChannel()
            => CreateConnection().CreateModel();

        private IConnection CreateConnection()
        {
            ConnectionFactory factory = new ConnectionFactory()
            {
                HostName = "localhost"
            };

            return factory.CreateConnection();
        }
    }
}
