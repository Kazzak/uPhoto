using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations; 

namespace BuPhoto.Models
{
    public class EtiquetaModels
    {
        [Required]
        [Display(Name = "Nombre de la etiqueta")]
        public string nombreEtiqueta { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string descripcion { get; set; }
    }
}