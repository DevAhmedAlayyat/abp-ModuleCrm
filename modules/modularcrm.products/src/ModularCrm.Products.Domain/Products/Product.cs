using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace ModularCrm.Products.Products
{
    public class Product : AuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        public int StockCount { get; set; }
    }
}
