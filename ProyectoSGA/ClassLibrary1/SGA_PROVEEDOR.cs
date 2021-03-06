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
    
    public partial class SGA_PROVEEDOR
    {
        public SGA_PROVEEDOR()
        {
            this.SGA_MARCA = new HashSet<SGA_MARCA>();
            this.SGA_ORDEN_COMPRA = new HashSet<SGA_ORDEN_COMPRA>();
        }
    
        public decimal ID_PROVEEDOR { get; set; }
        public string NOMBRE { get; set; }
        public string RUT { get; set; }
        public Nullable<decimal> FONO { get; set; }
        public string EMAIL { get; set; }
        public string DIRECCION { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_COMUNA { get; set; }
        public decimal ID_ALMACEN { get; set; }
    
        public virtual SGA_ALMACEN SGA_ALMACEN { get; set; }
        public virtual SGA_COMUNA SGA_COMUNA { get; set; }
        public virtual ICollection<SGA_MARCA> SGA_MARCA { get; set; }
        public virtual ICollection<SGA_ORDEN_COMPRA> SGA_ORDEN_COMPRA { get; set; }
    }
}
