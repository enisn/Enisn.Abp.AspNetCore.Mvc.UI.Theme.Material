using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.Bundling
{
    public class MaterialThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/material/css/mdb.min.css");
            context.Files.Add("/themes/material/css/admin.css");
        }
    }
}
