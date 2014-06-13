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
