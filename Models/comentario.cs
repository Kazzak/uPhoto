//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace uPhoto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class comentario
    {
        public comentario()
        {
            this.fotografia = new HashSet<fotografia>();
            this.publicacion = new HashSet<publicacion>();
        }
    
        public string comentario1 { get; set; }
        public int idusuario { get; set; }
        public System.DateTime fechacreacion { get; set; }
    
        public virtual usuario usuario { get; set; }
        public virtual ICollection<fotografia> fotografia { get; set; }
        public virtual ICollection<publicacion> publicacion { get; set; }
    }
}
