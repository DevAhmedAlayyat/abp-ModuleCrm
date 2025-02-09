using ModularCrm.Ordering.Entities.Orders;
using ModularCrm.Ordering.Events;
using ModularCrm.Ordering.Orders;
using ModularCrm.Products.Integration;
using NUglify.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus.Distributed;

namespace ModularCrm.Ordering.Application.Orders
{
    public class OrderAppService : OrderingAppService, IOrderAppService
    {
        private readonly IRepository<Order, Guid> _repository;
        private readonly IProductIntegrationService _productIntegrationService;
        private readonly IDistributedEventBus _distributedEventBus;

        public OrderAppService(
            IRepository<Order, Guid> repository,
            IProductIntegrationService productIntegrationService,
            IDistributedEventBus distributedEventBus)
        {
            _repository = repository;
            _productIntegrationService = productIntegrationService;
            _distributedEventBus = distributedEventBus;
        }

        public async Task<Guid> CreateAsync(CreateOrderDto input)
        {
            var result = (await _repository.InsertAsync(ObjectMapper.Map<CreateOrderDto, Order>(input))).Id;
            await _distributedEventBus.PublishAsync(new OrderPlacedEto
            {
                ProductId = input.ProductId
            });
            return result;
        }

        public async Task<IEnumerable<OrderDto>> GetAllAsync()
        {
            var orders = await _repository.GetListAsync();
            var productIds = orders.Select(x => x.ProductId).ToList();
            var products = (await _productIntegrationService.GetListAsync(productIds)).ToDictionary(x => x.Id, x => x.Name);
            var result = ObjectMapper.Map<IEnumerable<Order>, IEnumerable<OrderDto>>(orders);
            result.ForEach(x => x.ProductName = products[x.ProductId]);
            return result;
        }
    }
}
