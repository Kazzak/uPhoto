using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;

namespace BuPhoto.Controllers
{
    public class PerfilController : Controller
    {
        //
        // GET: /Perfil/

        public ActionResult Perfil()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Perfil(PerfilModel model)
        {
            return View(model);
        }

    }
}
