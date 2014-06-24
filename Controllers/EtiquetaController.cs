using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;

namespace BuPhoto.Controllers
{
    public class EtiquetaController : Controller
    {

        //Muestra el view de creacion de etiqueta
        public ActionResult Etiqueta()
        {
            return View();
        }

        //Obtiene los datos ingresados para agregar la etiqueta nueva
        [HttpPost]
        public ActionResult Etiqueta(EtiquetaModels model)
        {
            return View(model);
        }

        public ActionResult editEtiqueta()
        {
            return View();
        }

    }
}
