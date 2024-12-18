using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Infrastructure.MessageBus
{
    public class RabbitMqClient : IMessageBusClient
    {
        public void Publish(object message, string routingKey, string exchange)
        {
            throw new NotImplementedException();
        }
    }
}