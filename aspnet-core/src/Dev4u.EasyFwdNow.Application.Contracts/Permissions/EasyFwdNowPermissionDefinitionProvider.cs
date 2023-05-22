using Dev4u.EasyFwdNow.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dev4u.EasyFwdNow.Permissions;

public class EasyFwdNowPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        //var myGroup = context.AddGroup(EasyFwdNowPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EasyFwdNowPermissions.MyPermission1, L("Permission:MyPermission1"));

        var bookStoreGroup = context.AddGroup(EasyFwdNowPermissions.GroupName, L("Permission:EasyFwdNow"));

        var booksPermission = bookStoreGroup.AddPermission(EasyFwdNowPermissions.Servicios.Default, L("Permission:Servicios"));
        booksPermission.AddChild(EasyFwdNowPermissions.Servicios.Create, L("Permission:Servicios.Create"));
        booksPermission.AddChild(EasyFwdNowPermissions.Servicios.Edit, L("Permission:Servicios.Edit"));
        booksPermission.AddChild(EasyFwdNowPermissions.Servicios.Delete, L("Permission:Servicios.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EasyFwdNowResource>(name);
    }
}
