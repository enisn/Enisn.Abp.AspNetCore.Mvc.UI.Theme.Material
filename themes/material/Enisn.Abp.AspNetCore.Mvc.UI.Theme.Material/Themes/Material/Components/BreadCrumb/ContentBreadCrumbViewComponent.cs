using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.Themes.Material.Components.BreadCrumb
{
    public class ContentBreadCrumbViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Material/Components/BreadCrumb/Default.cshtml");
        }
    }
}