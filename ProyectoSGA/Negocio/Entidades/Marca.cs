using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Marca
    {
        public Marca()
        {
            this.ObjProducto = new List<Producto>();
        }

        public decimal ID_MARCA { get; set; }
        public string MARCA { get; set; }
        public string ESTADO { get; set; }
        public Nullable<decimal> ID_CATEGORIA { get; set; }
        public Nullable<decimal> ID_PROVEEDOR { get; set; }

        public virtual Categoria ObjCategoria { get; set; }
        public virtual List<Producto> ObjProducto { get; set; }
        public virtual Proveedor ObjProveedor { get; set; }
    }
}
