using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class DetalleBoleta
    {
        public decimal ID_DETALLE_BOLETA { get; set; }
        public decimal ID_BOLETA { get; set; }
        public string COD_BARRA { get; set; }
        public Nullable<decimal> PRECIO_VENTA { get; set; }

        public virtual Boleta ObjBoleta { get; set; }
        public virtual DetalleProducto ObjDetalleProducto { get; set; }
    }
}
