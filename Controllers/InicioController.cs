using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;
using System.IO;

namespace BuPhoto.Controllers
{
    public class InicioController : Controller
    {
        //
        // GET: /Inicio/

        public ActionResult Index()
        {
            ////System.Guid.NewGuid().ToString();
            var ruta = "tati";
            var ghgh = "vamos";

            if (!Directory.Exists(ruta))
            {
                System.IO.Directory.CreateDirectory(Server.MapPath(ruta + '/' + ghgh));
            }
            
            else
            {

                System.IO.Directory.CreateDirectory(Server.MapPath(ruta));

            }


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
