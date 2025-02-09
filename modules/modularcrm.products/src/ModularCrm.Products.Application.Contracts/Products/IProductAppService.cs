using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace ModularCrm.Products.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<Guid> CreateAsync(CreateProductDto input);
        Task<IEnumerable<ProductDto>> GetListAsync();
    }
}
