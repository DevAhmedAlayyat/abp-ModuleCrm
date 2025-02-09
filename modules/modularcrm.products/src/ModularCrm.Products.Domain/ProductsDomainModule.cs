using ModularCrm.Ordering;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.Commercial.SuiteTemplates;

namespace ModularCrm.Products;

[DependsOn(
    typeof(OrderingContractsModule),
    typeof(AbpDddDomainModule),
    typeof(VoloAbpCommercialSuiteTemplatesModule),
    typeof(ProductsDomainSharedModule)
)]
public class ProductsDomainModule : AbpModule
{

}
