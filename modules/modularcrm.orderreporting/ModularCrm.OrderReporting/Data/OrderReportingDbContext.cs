using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace ModularCrm.OrderReporting.Data;

[ConnectionStringName(OrderReportingDbProperties.ConnectionStringName)]
public class OrderReportingDbContext : AbpDbContext<OrderReportingDbContext>, IOrderReportingDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public OrderReportingDbContext(DbContextOptions<OrderReportingDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureOrderReporting();
    }
}
