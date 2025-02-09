namespace ModularCrm.OrderReporting;

public static class OrderReportingDbProperties
{
    public static string DbTablePrefix { get; set; } = "OrderReporting";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "OrderReporting";
}
