using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;

namespace BuPhoto.Controllers
{
    public class FotografoController : RolController
    {

        public ActionResult Fotografo()
        {
            return View();
        }

        //Modificar la informacion del fotografo
        [HttpPost]
        public ActionResult Fotografo(FotografoModel model)
        {
            return View(model);
        }

        public override ActionResult editPost()
        {
            return View();
        }

    }
}
