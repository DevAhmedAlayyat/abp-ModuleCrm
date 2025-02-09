using System;

namespace ModularCrm.Ordering.Orders
{
    public class OrderDto
    {
        public Guid Id { get; set; }
        public string Customer { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
