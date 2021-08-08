using Sandbox.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Sandbox.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class SandboxPageModel : AbpPageModel
    {
        protected SandboxPageModel()
        {
            LocalizationResourceType = typeof(SandboxResource);
        }
    }
}