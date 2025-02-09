using AutoMapper;
using ModularCrm.Products.Products;
using System.Collections.Generic;

namespace ModularCrm.Products;

public class ProductsApplicationAutoMapperProfile : Profile
{
    public ProductsApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Product, CreateProductDto>().ReverseMap();
        //CreateMap<IEnumerable<Product>, IEnumerable<CreateProductDto>>().ReverseMap();
    }
}
