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
    
    public partial class profiles
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string addrress { get; set; }
        public string phones { get; set; }
        public string email { get; set; }
        public int useid { get; set; }
    
        public virtual users users { get; set; }
    }
}
