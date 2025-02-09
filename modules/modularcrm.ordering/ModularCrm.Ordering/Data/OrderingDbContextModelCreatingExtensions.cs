using Microsoft.EntityFrameworkCore;
using ModularCrm.Ordering.Entities.Orders;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace ModularCrm.Ordering.Data;

public static class OrderingDbContextModelCreatingExtensions
{
    public static void ConfigureOrdering(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(OrderingDbProperties.DbTablePrefix + "Questions", OrderingDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Order>(b =>
        {
            b.ToTable(OrderingDbProperties.DbTablePrefix + "Orders", OrderingDbProperties.DbSchema);
            b.ConfigureByConvention();
            b.Property(x => x.Customer).IsRequired().HasMaxLength(100);
        });
    }
}
