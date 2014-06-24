using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BuPhoto.Models;
using System.IO;

//Aqui se genera el controlador para el album

namespace BuPhoto.Controllers
{
    public abstract class AlbController : Controller
    {
        //
        // GET: /Album/

        [HttpGet]
        public ActionResult Alb()
        {
            return View();
        }


        //Toma los datos de la vista
        [HttpPost]
        public ActionResult Alb(AlbumModels album)
        {
            {
                if (!Directory.Exists(album.Nombre))
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath('a' + '/' + album.Nombre));
                }

                else
                {

                    System.IO.Directory.CreateDirectory(Server.MapPath('a' + '/' + album.Nombre + '/'));

                }
            }

            try
            {
                var bd = new uPhotoEntities();
                album albu = new album
                {
                    fechacreacion = (DateTime.Now),
                    descripcion = (album.Descripción),
                    nombrealbum = (album.NombreAlbum),
                    idalbum = (album.idalbum)
                };

                bd.album.Add(albu);

                bd.SaveChanges();

                //return View(model);
            }
            catch (Exception e) { }
            return View();
        }
    }
}







//public void getPhotos()
//{

//}


//[HttpGet]
//public ActionResult User()
//{
//    return View();
//}

//        [HttpPost]
//        public ActionResult Usuario (usuario usuario)
//        {

//            if (ModelState.IsValid)
//            {
//                try
//                {
//                    var bd = new uPhotoEntities();
//                    usuario Usuario = new usuario
//                    {
//                        idsesion = usuario.idsesion,
//                        fecharegistro = DateTime.Now,
//                    };
//                    bd.usuario.Add(usuario);



//                   if (Save(bd) == true)
//                    {
//                        FormsAuthentication.SetAuthCookie(usuario.nombre, false /* createPersistentCookie */);
//                        return RedirectToAction("Index", "Inicio");
//                    }
//                    else
//                    {
//                        ModelState.AddModelError("", "Error al registrar al usuario, verificar los datos ingresados.");
//                    }
//                }
//                catch (Exception exc)
//                {
//                    Console.WriteLine(exc);
//                }
//            }




