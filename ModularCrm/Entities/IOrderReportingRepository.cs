using ModularCrm.Services.Dtos;

namespace ModularCrm.Entities
{
    public interface IOrderReportingRepository
    {
        Task<IEnumerable<OrderReportDto>> GetOrderRetporyAsync();
    }
}
