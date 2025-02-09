using ModularCrm.OrderReporting.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ModularCrm.OrderReporting.Permissions;

public class OrderReportingPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OrderReportingPermissions.GroupName, L("Permission:OrderReporting"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OrderReportingResource>(name);
    }
}
