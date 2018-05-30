using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class OrdenCompra
    {
        public OrdenCompra()
        {
            this.ObjDetalleOrdenCompra = new List<DetalleOrdenCompra>();
        }

        public decimal ID_ORDEN_COMPRA { get; set; }
        public Nullable<System.DateTime> FECHA_ORDEN_COMPRA { get; set; }
        public Nullable<System.DateTime> FECHA_RECEPCION { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_USUARIO { get; set; }
        public Nullable<decimal> ID_PROVEEDOR { get; set; }
        public decimal ID_ALMACEN { get; set; }

        public virtual Almacen ObjAlamcen { get; set; }
        public virtual List<DetalleOrdenCompra> ObjDetalleOrdenCompra { get; set; }
        public virtual Proveedor ObjProveedor { get; set; }
        public virtual Usuario ObjUsuario { get; set; }
    }
}
