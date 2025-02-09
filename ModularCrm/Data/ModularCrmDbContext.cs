using ModularCrm.Products.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.BlobStoring.Database.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using ModularCrm.Products.Products;
using Volo.Abp.DependencyInjection;
using ModularCrm.Ordering.Data;
using ModularCrm.Ordering.Entities.Orders;

namespace ModularCrm.Data;

[ReplaceDbContext(typeof(IProductsDbContext), typeof(IOrderingDbContext))]
public class ModularCrmDbContext : AbpDbContext<ModularCrmDbContext>, IProductsDbContext, IOrderingDbContext
{

    public const string DbTablePrefix = "App";
    public const string DbSchema = null;

    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    public ModularCrmDbContext(DbContextOptions<ModularCrmDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureProducts();
        builder.ConfigureOrdering();

        /* Include modules to your migration db context */

        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureFeatureManagement();
        builder.ConfigurePermissionManagement();
        builder.ConfigureBlobStoring();
        builder.ConfigureIdentityPro();
        builder.ConfigureOpenIddictPro();

        /* Configure your own entities here */
    }
}

