using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ModularCrm.OrderReporting.Services.Orders
{
    public interface IOrdersReportingAppService : IApplicationService
    {
        Task<OrderDto> GetListAsync();
    }
}
