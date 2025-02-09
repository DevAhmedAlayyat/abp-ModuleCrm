using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.EntityFrameworkCore;
using ModularCrm.OrderReporting.Data;
using Volo.Abp.AspNetCore.Mvc;

namespace ModularCrm.OrderReporting;

[DependsOn(
    typeof(OrderReportingContractsModule),
    typeof(AbpDddApplicationModule),
    typeof(AbpAutoMapperModule),
    typeof(AbpAspNetCoreMvcModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class OrderReportingModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAutoMapperObjectMapper<OrderReportingModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<OrderReportingModule>(validate: true);
        });
        
        context.Services.AddAbpDbContext<OrderReportingDbContext>(options =>
        {
            options.AddDefaultRepositories(includeAllEntities: true);
            
            /* Add custom repositories here. Example:
             * options.AddRepository<Question, EfCoreQuestionRepository>();
             */
        });
    }
}
