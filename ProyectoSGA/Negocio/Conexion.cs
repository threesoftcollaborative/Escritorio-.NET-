using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALC;

namespace Negocio
{
    public static class Conexion
    {
        private static DefaultConnection _conexionNegocio;

        public static DefaultConnection ConexionNegocio
        {
            get
            {
                if (_conexionNegocio == null)
                {
                    _conexionNegocio = new DefaultConnection();
                }

                return _conexionNegocio;
            }
        }
    }
}
