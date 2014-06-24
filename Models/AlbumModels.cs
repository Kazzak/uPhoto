using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Para los required y los display
using System.ComponentModel.DataAnnotations;

namespace BuPhoto.Models
{
    public class AlbumModels
    {
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }


        [Display(Name = "Descripción")]
        public string Descripción { get; set; }

        [Display(Name = "NombreAlbum")]
        public string NombreAlbum { get; set; }

        [Display(Name = "idalbum")]
        public int idalbum { get; set; }
    }
}