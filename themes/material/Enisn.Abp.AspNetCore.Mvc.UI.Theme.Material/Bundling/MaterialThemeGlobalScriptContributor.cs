using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.Bundling
{
    public class MaterialThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/material/js/mdb.min.js");
            context.Files.Add("/themes/material/js/admin.js");
        }
    }
}