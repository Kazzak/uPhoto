using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace uPhoto.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Bienvenido a uPhoto, el sitio para fotógrafos";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Perfil()
        {
            return View();
        }
    }
}
