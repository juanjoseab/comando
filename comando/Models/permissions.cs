//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace comando.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class permissions
    {
        public int ID { get; set; }
        public int rolid { get; set; }
        public int moduleid { get; set; }
        public int actionid { get; set; }
    
        public virtual actions actions { get; set; }
        public virtual modules modules { get; set; }
        public virtual roles roles { get; set; }
    }
}