using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DetalleOrdenCompra
    {
        public decimal ID_DETALLE_ORDEN_COMPRA { get; set; }
        public decimal ID_ORDEN_COMPRA { get; set; }
        public decimal ID_PRODUCTO { get; set; }
        public decimal CANTIDAD { get; set; }
        public Nullable<decimal> PRECIO_COMPRA { get; set; }

        public virtual OrdenCompra ObjOrdenCompra { get; set; }
        public virtual Producto ObjProducto { get; set; }
    }
}
