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
    
    public partial class album
    {
        public album()
        {
            this.fotografo = new HashSet<fotografo>();
            this.etiqueta = new HashSet<etiqueta>();
            this.fotografia = new HashSet<fotografia>();
        }
    
        public int idalbum { get; set; }
        public string nombrealbum { get; set; }
        public string descripcion { get; set; }
        public string ubicacionfotos { get; set; }
        public System.DateTime fechacreacion { get; set; }
    
        public virtual ICollection<fotografo> fotografo { get; set; }
        public virtual ICollection<etiqueta> etiqueta { get; set; }
        public virtual ICollection<fotografia> fotografia { get; set; }
    }
}
