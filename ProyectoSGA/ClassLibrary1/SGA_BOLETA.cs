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
    
    public partial class SGA_BOLETA
    {
        public SGA_BOLETA()
        {
            this.SGA_DETALLE_BOLETA = new HashSet<SGA_DETALLE_BOLETA>();
        }
    
        public decimal ID_BOLETA { get; set; }
        public Nullable<System.DateTime> FECHA_BOLETA { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_USUARIO { get; set; }
        public Nullable<decimal> ID_CLIENTE { get; set; }
        public decimal ID_ALMACEN { get; set; }
    
        public virtual SGA_ALMACEN SGA_ALMACEN { get; set; }
        public virtual ICollection<SGA_DETALLE_BOLETA> SGA_DETALLE_BOLETA { get; set; }
        public virtual SGA_CLIENTE SGA_CLIENTE { get; set; }
        public virtual SGA_USUARIO SGA_USUARIO { get; set; }
    }
}
