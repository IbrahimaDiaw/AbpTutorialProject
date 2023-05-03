using AbpTutorialProject.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpTutorialProject.Permissions;

public class AbpTutorialProjectPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpTutorialProjectPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpTutorialProjectPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpTutorialProjectResource>(name);
    }
}
