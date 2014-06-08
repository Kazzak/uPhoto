using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using uPhoto.Models;

namespace uPhoto.Models
{
    public class UserServices
    {

        private Exception ex;

        public static bool ValidateUser(string user, string password)
        {
            //Simulación de campos en una tabla de la base de datos
            //uPhotoEntities db = new uPhotoEntities();
            var bd2 = new uPhotoEntities();
            var usuario = bd2.sesion.FirstOrDefault(x=>x.usuario == user && x.password == password);

            //const string validateUser = "pepe";
            //const string validatePass = "123";
            if(usuario != null)
            {
                //Si el nombre de usuario y la contraseña coinciden se devuelve true
                //return (validateUser == user & validatePass == password);
                return true;
            }
            return false;
        }


        //Guarda los cambios realizados en la base de datos
        public static bool Save(uPhotoEntities db)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            return true;
        }


    }
}
