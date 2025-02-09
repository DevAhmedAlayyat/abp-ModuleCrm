using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ModularCrm.OrderReporting.Services.Orders
{
    public class OrdersReportingAppService : OrderReportingAppService, IOrdersReportingAppService
    {
        public OrdersReportingAppService()
        {

        }

        public Task<OrderDto> GetListAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
