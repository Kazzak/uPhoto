using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;

namespace BuPhoto.Controllers
{
    public class InicioController : Controller
    {
        //
        // GET: /Inicio/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CameraSearch()
        {
            return View();
        }

        public ActionResult Foro()
        {
            return View();
        }

        public ActionResult AcercaDe()
        {
            return View();
        }

        public ActionResult Contacto()
        {
            return View();
        }

    }
}
