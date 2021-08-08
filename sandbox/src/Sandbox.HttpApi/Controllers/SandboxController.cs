using Sandbox.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Sandbox.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class SandboxController : AbpController
    {
        protected SandboxController()
        {
            LocalizationResource = typeof(SandboxResource);
        }
    }
}