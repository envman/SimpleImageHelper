using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleImageHelper.HtmlHelpers
{
    public static class HtmlHelperExtensions
    {
        public static MvcHtmlString Image(this HtmlHelper helper, string image, string alternative)
        {
            var urlHelper = new UrlHelper(helper.ViewContext.RequestContext);
            var url = urlHelper.Action("Image", "Image", new { image });

            var builder = new TagBuilder("img");

            builder.MergeAttribute("src", url);
            builder.MergeAttribute("alt", alternative);

            return MvcHtmlString.Create(builder.ToString(TagRenderMode.SelfClosing));
        } 
    }
}