using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DetalleProducto
    {
        public DetalleProducto()
        {
            this.ObjDetalleBoleta = new List<DetalleBoleta>();
        }

        public string COD_BARRA { get; set; }
        public Nullable<decimal> ID_PRODUCTO { get; set; }
        public Nullable<System.DateTime> FECHA_CADUCIDAD { get; set; }
        public string ESTADO { get; set; }

        public virtual List<DetalleBoleta> ObjDetalleBoleta { get; set; }
        public virtual Producto ObjProdcuto { get; set; }
    }
}
