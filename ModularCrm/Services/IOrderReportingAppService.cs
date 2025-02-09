using ModularCrm.Services.Dtos;

namespace ModularCrm.Services
{
    public interface IOrderReportingAppService
    {
        Task<IEnumerable<OrderReportDto>> GetLatestOrders();
    }
}
