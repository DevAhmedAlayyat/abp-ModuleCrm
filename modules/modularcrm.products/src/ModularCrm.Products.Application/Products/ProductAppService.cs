using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace ModularCrm.Products.Products
{
    public class ProductAppService : ProductsAppService, IProductAppService
    {
        private readonly IRepository<Product, Guid> _repository;

        public ProductAppService(IRepository<Product, Guid> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> CreateAsync(CreateProductDto input)
        {
            var product = ObjectMapper.Map<CreateProductDto, Product>(input);
            await _repository.InsertAsync(product);
            return product.Id;
        }

        public async Task<IEnumerable<ProductDto>> GetListAsync()
        {
            return ObjectMapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(await _repository.GetListAsync());
        }
    }
}
