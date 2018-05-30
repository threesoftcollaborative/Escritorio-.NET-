using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Producto
    {
        public Producto()
        {
            this.ObjDetalleOrdenCompra = new List<DetalleOrdenCompra>();
            this.ObjDetalleProducto = new List<DetalleProducto>();
        }

        public decimal ID_PRODUCTO { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<decimal> PRECIO_COMPRA { get; set; }
        public Nullable<decimal> PRECIO_VENTA { get; set; }
        public Nullable<decimal> STOCK { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_MARCA { get; set; }

        public virtual List<DetalleOrdenCompra> ObjDetalleOrdenCompra { get; set; }
        public virtual List<DetalleProducto> ObjDetalleProducto { get; set; }
        public virtual Marca ObjMarca { get; set; }
    }
}
