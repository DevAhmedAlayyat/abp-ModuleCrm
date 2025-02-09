using ModularCrm.OrderReporting.Localization;
using Volo.Abp.Application.Services;

namespace ModularCrm.OrderReporting;

public abstract class OrderReportingAppService : ApplicationService
{
    protected OrderReportingAppService()
    {
        LocalizationResource = typeof(OrderReportingResource);
        ObjectMapperContext = typeof(OrderReportingModule);
    }
}
