//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuPhoto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class usuario
    {
        public usuario()
        {
            this.comentario = new HashSet<comentario>();
            this.producto = new HashSet<producto>();
            this.publicacion = new HashSet<publicacion>();
            this.rolporusuario = new HashSet<rolporusuario>();
        }
    
        public int idusuario { get; set; }
        public string idsesion { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string foto { get; set; }
        public System.DateTime fecharegistro { get; set; }
        public string email { get; set; }
        public string nacionalidad { get; set; }
        public Nullable<System.DateTime> fechanacimiento { get; set; }
    
        public virtual ICollection<comentario> comentario { get; set; }
        public virtual ICollection<producto> producto { get; set; }
        public virtual ICollection<publicacion> publicacion { get; set; }
        public virtual ICollection<rolporusuario> rolporusuario { get; set; }
        public virtual sesion sesion { get; set; }
    }
}
