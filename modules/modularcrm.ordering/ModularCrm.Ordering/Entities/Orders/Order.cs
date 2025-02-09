using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ModularCrm.Ordering.Entities.Orders
{
    public class Order : CreationAuditedAggregateRoot<Guid>
    {
        public string Customer { get; set; }
        public Guid ProductId { get; set; }
    }
}
