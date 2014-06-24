using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;

namespace BuPhoto.Controllers
{
    public class FotografiaController : Controller
    {
        //
        // GET: /Fotografia/
        [HttpGet]
        public ActionResult Fotografia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Fotografia(FotografiaModel model)
        {
            return View(model);
        }

        public void addPhoto()
        {

        }

        public void deletePhoto()
        {

        }

    }
}
