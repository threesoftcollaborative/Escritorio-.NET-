using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almacenes.Datos;

namespace Almacenes.Negocio
{
    public static class Conexion
    {
        private static DefaultConnection _conexionNegocio;

        private static DefaultConnection ConexionNegocio
        {
            get
            {
                if(_conexionNegocio == null)
                {
                    _conexionNegocio = new DefaultConnection();
                }
                return _conexionNegocio;
            }
        }
    }
}
