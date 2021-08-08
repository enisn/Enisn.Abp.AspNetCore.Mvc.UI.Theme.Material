using Sandbox.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Sandbox.Permissions
{
    public class SandboxPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(SandboxPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(SandboxPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<SandboxResource>(name);
        }
    }
}
