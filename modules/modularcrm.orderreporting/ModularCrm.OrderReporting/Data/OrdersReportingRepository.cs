using ModularCrm.OrderReporting.Services.Orders;
using System.Threading.Tasks;

namespace ModularCrm.OrderReporting.Data
{
    public class OrdersReportingRepository : IOrdersReportingRepository
    {
        private readonly IOrderReportingDbContext _dbContext;

        public OrdersReportingRepository(IOrderReportingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<OrderDto> GetListAsync()
        {
        }
    }
}
