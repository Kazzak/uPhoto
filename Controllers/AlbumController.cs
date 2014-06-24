using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;

namespace BuPhoto.Controllers
{
    public abstract class AlbumController : Controller
    {
        //
        // GET: /Album/

        [HttpGet]
        public ActionResult Album()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Album(AlbumModel model)
        {
            return View(model);
        }

        public void deleteAlbum()
        {

        }

        public void addAlbum()
        {

        }

        public void getPhotos()
        {

        }

        public void getUser()
        {

        }

    }
}
