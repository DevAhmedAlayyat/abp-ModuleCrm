using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ModularCrm.Ordering.Orders
{
    public interface IOrderAppService : IApplicationService
    {
        Task<Guid> CreateAsync(CreateOrderDto input);
        Task<IEnumerable<OrderDto>> GetAllAsync();
    }
}
