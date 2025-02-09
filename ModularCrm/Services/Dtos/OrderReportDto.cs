namespace ModularCrm.Services.Dtos
{
    public class OrderReportDto
    {
        public Guid OrderId { get; set; }
        public string CustomerName { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
