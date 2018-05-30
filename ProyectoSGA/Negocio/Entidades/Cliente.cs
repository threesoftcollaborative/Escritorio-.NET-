using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Cliente
    {
        public Cliente()
        {
            this.ObjBoleta = new List<Boleta>();
        }

        public decimal ID_CLIENTE { get; set; }
        public string RUT { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public Nullable<decimal> TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public Nullable<System.DateTime> FECHA_NACIMIENTO { get; set; }
        public string DIRECCION { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_ALMACEN { get; set; }
        public decimal ID_COMUNA { get; set; }

        public virtual Almacen ObjAlamacen { get; set; }
        public virtual List<Boleta> ObjBoleta { get; set; }
    }
}
