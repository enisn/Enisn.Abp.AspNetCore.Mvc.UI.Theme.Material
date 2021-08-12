using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.Themes.Material.Components.PublicNavbar
{
    public class PublicNavbarViewComponent: AbpViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("~/Themes/Material/Components/PublicNavbar/Default.cshtml");
        }
    }
}