using System;

namespace ModularCrm.Ordering.Orders
{
    public class CreateOrderDto
    {
        public string Customer { get; set; }
        public Guid ProductId { get; set; }
    }
}
