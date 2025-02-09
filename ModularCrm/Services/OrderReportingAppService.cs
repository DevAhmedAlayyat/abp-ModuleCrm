using Microsoft.AspNetCore.Mvc;
using ModularCrm.Entities;
using ModularCrm.Services.Dtos;

namespace ModularCrm.Services
{
    [Route("/orders")]
    public class OrderReportingAppService : ModularCrmAppService, IOrderReportingAppService
    {
        private readonly IOrderReportingRepository _orderReportingRepository;

        public OrderReportingAppService(IOrderReportingRepository orderReportingRepository)
        {
            _orderReportingRepository = orderReportingRepository;
        }

        [HttpGet]
        [Route("include-details")]
        public async Task<IEnumerable<OrderReportDto>> GetLatestOrders()
        {
            return await _orderReportingRepository.GetOrderRetporyAsync();
        }
    }
}
