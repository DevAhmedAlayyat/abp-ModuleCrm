using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModularCrm.OrderReporting.Data;

[ConnectionStringName(OrderReportingDbProperties.ConnectionStringName)]
public interface IOrderReportingDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */
}
