using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Proveedor
    {
        public Proveedor()
        {
            this.ObjMarca = new List<Marca>();
            this.ObjOrdenCompra = new List<OrdenCompra>();
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

        public virtual Almacen ObjAlmacen { get; set; }
        public virtual Comuna ObjComuna { get; set; }
        public virtual List<Marca> ObjMarca { get; set; }
        public virtual List<OrdenCompra> ObjOrdenCompra { get; set; }
    }
}
