//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class SGA_PERFIL
    {
        public SGA_PERFIL()
        {
            this.SGA_USUARIO = new HashSet<SGA_USUARIO>();
        }
    
        public decimal ID_PERFIL { get; set; }
        public string DESCRIPCION { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_MENU { get; set; }
    
        public virtual SGA_MENU SGA_MENU { get; set; }
        public virtual ICollection<SGA_USUARIO> SGA_USUARIO { get; set; }
    }
}
