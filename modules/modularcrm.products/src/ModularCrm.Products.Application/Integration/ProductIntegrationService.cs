using ModularCrm.Products.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;

namespace ModularCrm.Products.Integration
{
    [IntegrationService]
    public class ProductIntegrationService : ProductsAppService, IProductIntegrationService
    {
        private readonly IRepository<Product, Guid> _repository;

        public ProductIntegrationService(IRepository<Product, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ProductDto>> GetListAsync(IEnumerable<Guid> ProductIds)
        {
            return ObjectMapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(await _repository.GetListAsync(x => ProductIds.Any(p => p == x.Id)));
        }
    }
}
