using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.Bundling
{
	public class MaterialThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add(CultureHelper.IsRtl ? "/themes/material/css/mdb.rtl.min.css" : "/themes/material/css/mdb.min.css");
            context.Files.Add("/themes/material/css/theme.css");
        }
    }
}
