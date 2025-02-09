using ModularCrm.OrderReporting.Services.Orders;
using System.Threading.Tasks;

namespace ModularCrm.OrderReporting.Data
{
    public interface IOrdersReportingRepository
    {
        Task<OrderDto> GetListAsync();
    }
}
