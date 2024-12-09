using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AwesomeShop.Services.Orders.Core.Entities;

namespace AwesomeShop.Services.Orders.Core.Events
{
    public interface IDomainEvent : IEntityBase
    {
       
        public Guid Id {get; protected set;}
    }
}