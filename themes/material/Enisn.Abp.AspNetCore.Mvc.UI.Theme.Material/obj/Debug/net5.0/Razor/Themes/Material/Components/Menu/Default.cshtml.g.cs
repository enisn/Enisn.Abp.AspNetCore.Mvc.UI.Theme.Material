#pragma checksum "/Users/enisnecipoglu/Projects/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/themes/material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/Themes/Material/Components/Menu/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80ebeb71c9930f1db6b9efa7f178e814462c32fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Themes_Material_Components_Menu_Default), @"mvc.1.0.view", @"/Themes/Material/Components/Menu/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/enisnecipoglu/Projects/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/themes/material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/Themes/Material/_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/enisnecipoglu/Projects/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/themes/material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/Themes/Material/Components/Menu/Default.cshtml"
using Volo.Abp.UI.Navigation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80ebeb71c9930f1db6b9efa7f178e814462c32fd", @"/Themes/Material/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4774f01943f02a49507315c0ef1cabe5607aa081", @"/Themes/Material/_ViewImports.cshtml")]
    public class Themes_Material_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationMenu>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/enisnecipoglu/Projects/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/themes/material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/Themes/Material/Components/Menu/Default.cshtml"
 foreach (var menuItem in Model.Items)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/enisnecipoglu/Projects/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/themes/material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/Themes/Material/Components/Menu/Default.cshtml"
Write(await Html.PartialAsync("~/Themes/Material/Components/Menu/_MenuItem.cshtml", menuItem));

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/enisnecipoglu/Projects/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/themes/material/Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material/Themes/Material/Components/Menu/Default.cshtml"
                                                                                            
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationMenu> Html { get; private set; }
    }
}
#pragma warning restore 1591
