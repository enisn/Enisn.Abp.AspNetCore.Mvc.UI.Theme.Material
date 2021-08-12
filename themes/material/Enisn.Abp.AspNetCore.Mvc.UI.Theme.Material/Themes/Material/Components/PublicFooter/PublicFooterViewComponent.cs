using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.UI.Navigation;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.Themes.Material.Components.PublicFooter
{
    public class PublicFooterViewComponent : ViewComponent
    {
        protected IMenuManager MenuManager { get; }
        
        public PublicFooterViewComponent(IMenuManager menuManager)
        {
            MenuManager = menuManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menu = await MenuManager.GetAsync("Footer");
            return View("~/Themes/Material/Components/PublicFooter/Default.cshtml", menu);
        }
    }
}