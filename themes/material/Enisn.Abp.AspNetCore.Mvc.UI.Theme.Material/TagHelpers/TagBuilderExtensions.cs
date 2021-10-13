using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers
{
    public static class TagBuilderExtensions
    {
        public static string ToHtmlString(this TagBuilder tagBuilder)
        {
            return tagBuilder.ToHtmlString(HtmlEncoder.Default);
        }

        public static string ToHtmlString(this TagBuilder tagBuilder, HtmlEncoder htmlEncoder)
        {
            using (var writer = new StringWriter())
            {
                tagBuilder.WriteTo(writer, htmlEncoder);
                return writer.ToString();
            }
        }
    }
}
