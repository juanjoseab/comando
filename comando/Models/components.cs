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
    
    public partial class components
    {
        public components()
        {
            this.modules = new HashSet<modules>();
        }
    
        public int ID { get; set; }
        public string name { get; set; }
        public string path { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<modules> modules { get; set; }
    }
}