using Volo.Abp.Reflection;

namespace ModularCrm.OrderReporting.Permissions;

public class OrderReportingPermissions
{
    public const string GroupName = "OrderReporting";

    public static string[] GetAll()
    {
        return ReflectionHelper.GetPublicConstantsRecursively(typeof(OrderReportingPermissions));
    }
}
