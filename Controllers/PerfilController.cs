using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;
using System.Web.Security;

namespace BuPhoto.Controllers
{
    public class PerfilController : Controller
    {
        //
        // GET: /Perfil/

        [Authorize]
        public ActionResult Perfil()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Perfil(PerfilModel model)
        {
            return View(model);
        }

        public void getUser()
        {

        }

        public void getAlbum()
        {

        }

        public void getCountOfAlbums()
        {

        }

        public void getCountOfPhotos()
        {

        }

    }
}
