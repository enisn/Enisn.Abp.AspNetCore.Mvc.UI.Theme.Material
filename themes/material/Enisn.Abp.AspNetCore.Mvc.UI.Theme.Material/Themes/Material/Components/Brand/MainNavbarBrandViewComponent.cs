using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.Themes.Material.Components.Brand
{
    public class MainNavbarBrandViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Material/Components/Brand/Default.cshtml");
        }
    }
}
