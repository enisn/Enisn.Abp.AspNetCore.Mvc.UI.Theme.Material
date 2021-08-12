using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.Themes.Material.Components.PublicMenu
{
    public class PublicNavbarMenuViewComponent : AbpViewComponent
    {
        private readonly IMenuManager _menuManager;

        public PublicNavbarMenuViewComponent(IMenuManager menuManager)
        {
            _menuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menu = await _menuManager.GetMainMenuAsync();
            return View("~/Themes/Material/Components/PublicMenu/Default.cshtml", menu);
        }
    }
}
