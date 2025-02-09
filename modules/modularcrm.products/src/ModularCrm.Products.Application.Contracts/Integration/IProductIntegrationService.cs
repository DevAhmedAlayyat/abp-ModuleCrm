using ModularCrm.Products.Products;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace ModularCrm.Products.Integration
{
    [IntegrationService]
    public interface IProductIntegrationService : IApplicationService
    {
        Task<IEnumerable<ProductDto>> GetListAsync(IEnumerable<Guid> ProductIds);
    }
}
