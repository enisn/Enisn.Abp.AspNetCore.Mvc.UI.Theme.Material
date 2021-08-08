using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Sandbox.Web
{
    [Dependency(ReplaceServices = true)]
    public class SandboxBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Sandbox";
    }
}
