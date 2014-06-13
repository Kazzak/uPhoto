﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uPhoto.Models;

namespace uPhoto.Controllers
{
    public class LoginController : Controller
    {

        public static bool ValidateUser(string user, string password)
        {
            //Simulación de campos en una tabla de la base de datos
            //uPhotoEntities db = new uPhotoEntities();
            var bd2 = new uPhotoEntities();
            var usuario = bd2.sesion.FirstOrDefault(x => x.idsesion == user && x.password == password);

            //const string validateUser = "pepe";
            //const string validatePass = "123";
            if (usuario != null)
            {
                //Si el nombre de usuario y la contraseña coinciden se devuelve true
                //return (validateUser == user & validatePass == password);
                return true;
            }
            return false;
        }

        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Login/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Login/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Login/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Login/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Login/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Login/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Login/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
