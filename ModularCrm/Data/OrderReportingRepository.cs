using Microsoft.EntityFrameworkCore;
using ModularCrm.Entities;
using ModularCrm.Services.Dtos;
using Volo.Abp.DependencyInjection;

namespace ModularCrm.Data
{
    public class OrderReportingRepository : IOrderReportingRepository, ITransientDependency
    {
        private readonly ModularCrmDbContext _dbContext;

        public OrderReportingRepository(ModularCrmDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<OrderReportDto>> GetOrderRetporyAsync()
        {
            var orders = _dbContext.Orders;
            var products = _dbContext.Products;

            var latestOrders = await (from order in orders
                                      join product in products on order.ProductId equals product.Id
                                      orderby order.CreationTime descending
                                      select new OrderReportDto
                                      {
                                          OrderId = order.Id,
                                          CustomerName = order.Customer,
                                          ProductId = product.Id,
                                          ProductName = product.Name
                                      })
                .Take(10)
                .ToListAsync();

            return latestOrders;
        }
    }
}
