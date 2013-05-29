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

            var imageString = String.Format("<img src='{0}' alt='{1}'/>", url, alternative);
            return MvcHtmlString.Create(imageString);
        } 
    }
}