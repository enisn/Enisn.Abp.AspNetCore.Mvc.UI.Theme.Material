using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace Enisn.Abp.AspNetCore.Mvc.UI.Theme.Material.TagHelpers
{
    [HtmlTargetElement("abp-input", TagStructure = TagStructure.NormalOrSelfClosing)]
    public class MaterialInputTagHelper : AbpTagHelper<MaterialInputTagHelper, MaterialInputTagHelperService>
    {
        public MaterialInputTagHelper(MaterialInputTagHelperService service) : base(service)
        {
        }

        public ModelExpression AspFor { get; set; }

        public string Label { get; set; }

        [HtmlAttributeName("info")]
        public string InfoText { get; set; }

        [HtmlAttributeName("disabled")]
        public bool IsDisabled { get; set; } = false;

        [HtmlAttributeName("readonly")]
        public bool? IsReadonly { get; set; } = false;

        public bool AutoFocus { get; set; }

        [HtmlAttributeName("type")]
        public string InputTypeName { get; set; }

        public AbpFormControlSize Size { get; set; } = AbpFormControlSize.Default;

        [HtmlAttributeName("required-symbol")]
        public bool DisplayRequiredSymbol { get; set; } = true;

        [HtmlAttributeName("asp-format")]
        public string Format { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }

        public bool SuppressLabel { get; set; }

        public CheckBoxHiddenInputRenderMode CheckBoxHiddenInputRenderMode { get; set; }
    }
}
