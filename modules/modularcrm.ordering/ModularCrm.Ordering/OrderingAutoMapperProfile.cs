using AutoMapper;
using ModularCrm.Ordering.Entities.Orders;
using ModularCrm.Ordering.Orders;
using System.Collections.Generic;

namespace ModularCrm.Ordering;

public class OrderingAutoMapperProfile : Profile
{
    public OrderingAutoMapperProfile()
    {
        //CreateMap<IEnumerable<Order>, IEnumerable<OrderDto>>().ReverseMap();
        CreateMap<Order, CreateOrderDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ForMember(x => x.ProductName, opt => opt.Ignore()).ReverseMap();
    }
}
