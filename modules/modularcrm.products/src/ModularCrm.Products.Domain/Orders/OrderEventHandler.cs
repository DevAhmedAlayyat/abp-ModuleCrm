using ModularCrm.Ordering.Events;
using ModularCrm.Products.Products;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace ModularCrm.Products.Orders
{
    public class OrderEventHandler : IDistributedEventHandler<OrderPlacedEto>, ITransientDependency
    {
        private readonly IRepository<Product> _productRepository;

        public OrderEventHandler(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task HandleEventAsync(OrderPlacedEto eventData)
        {
            var product = await _productRepository.FindAsync(x => x.Id == eventData.ProductId);
            if (product == null)
                return;

            product.StockCount = product.StockCount > 0 ? --product.StockCount : 0;
            await _productRepository.UpdateAsync(product);
        }
    }
}
