using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    class Menu
    {
        public Menu()
        {
            this.ObjPerfil = new List<Perfil>();
        }

        public decimal ID_MENU { get; set; }
        public string DESCRIPCION { get; set; }
        public Nullable<decimal> PADRE_MENU { get; set; }
        public Nullable<decimal> DESTINO { get; set; }
        public string ESTADO { get; set; }

        public virtual List<Perfil> ObjPerfil { get; set; }
    }
}
}
