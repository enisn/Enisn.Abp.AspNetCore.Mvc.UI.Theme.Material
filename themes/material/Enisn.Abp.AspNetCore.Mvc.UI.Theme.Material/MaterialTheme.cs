using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material
{
    [ThemeName(Name)]
    public class MaterialTheme : ITheme, ITransientDependency
    {
        public const string Name = "Material";

        public virtual string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case StandardLayouts.Application:
                    return "~/Themes/Material/Layouts/Application.cshtml";
                case StandardLayouts.Account:
                    return "~/Themes/Material/Layouts/Account.cshtml";
                case StandardLayouts.Public:
                    return "~/Themes/Material/Layouts/Public.cshtml";
                case StandardLayouts.Empty:
                    return "~/Themes/Material/Layouts/Empty.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/Material/Layouts/Application.cshtml" : null;
            }
        }
    }
}
