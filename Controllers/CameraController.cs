using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuPhoto.Controllers

{
    public class CameraController : Controller
    {
        //
        // GET: /Camera/

         
        public ActionResult Buscador_camara()
        {
           
            return View();
            
        }
        //[HttpPost]
        //    public ActionResult Buscador_camara (Buscar buscador_camara)
        //{
        //    return View (buscador_camara);
        //}
         
    }
} 


