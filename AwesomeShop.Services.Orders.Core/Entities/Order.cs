using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Orders.Core.Entities
{
    public class Order :AggregateRoot
    {
        public decimal TotalPrice { get; private set; }
        public Customer customer {get; private set;}
        public DateTime CreatedAt { get; private set; }
        public List<OrderItem> Items {get; private set;}
        public PaymentInfo PaymentInfo {get; private set;}
        public DeliveryAdress DeliveryAdress{get; private set}
        public PaymentAddress PaymentAddress{get; private set;}
    }
}