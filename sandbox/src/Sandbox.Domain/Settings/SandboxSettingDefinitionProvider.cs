using Volo.Abp.Settings;

namespace Sandbox.Settings
{
    public class SandboxSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(SandboxSettings.MySetting1));
        }
    }
}
