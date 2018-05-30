using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Boleta
    {
        public Boleta()
        {
            this.ObjDetalleBoleta = new List<DetalleBoleta>();
        }

        public decimal ID_BOLETA { get; set; }
        public Nullable<System.DateTime> FECHA_BOLETA { get; set; }
        public Nullable<decimal> TOTAL { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_USUARIO { get; set; }
        public Nullable<decimal> ID_CLIENTE { get; set; }
        public decimal ID_ALMACEN { get; set; }

        public virtual Almacen ObjAlmacen { get; set; }
        public virtual List<DetalleBoleta> ObjDetalleBoleta { get; set; }
        public virtual Cliente ObjCliente { get; set; }
        public virtual Usuario ObjUsuario { get; set; }
    }
}
