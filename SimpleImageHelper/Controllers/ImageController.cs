using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleImageHelper.Controllers
{
    public class ImageController : Controller
    {
        public ActionResult Image(string image)
        {
            var imagePath = Server.MapPath("/Images");
            var imageLocation = Path.Combine(imagePath, image);

            return File(imageLocation, "image/jpeg");
        }
    }
}
