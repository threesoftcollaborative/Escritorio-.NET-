using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALC;

namespace Negocio
{
    public class Usuario
    {
        public Usuario()
        {
            this.ObjBoleta = new List<Boleta>();
            this.ObjOrdenCompra = new List<OrdenCompra>();
        }

        public decimal ID_USUARIO { get; set; }
        public string USUARIO { get; set; }
        public string PASS { get; set; }
        public string EMAIL { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_PERFIL { get; set; }
        public decimal ID_ALMACEN { get; set; }

        public virtual Almacen ObjAlmacen { get; set; }
        public virtual List<Boleta> ObjBoleta { get; set; }
        public virtual List<OrdenCompra> ObjOrdenCompra { get; set; }
        public virtual Perfil ObjPerfil { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>


        public bool Create()
        {
            try
            {
                DALC.SGA_USUARIO USU = new DALC.SGA_USUARIO();
                USU.USUARIO = this.nombre;
                USU.IdCategoria = this.idCategoria;
                USU.Direccion = this.direccion;
                USU.IdComuna = this.idComuna;
                USU.Estado = this.estado;
                Conexion.ConexionNegocio.
                CommonBC.resgistroFerme.AddToEmpleados(alm);
                CommonBC.resgistroFerme.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Read()
        {
            try
            {
                DALC.Empleados empleado = CommonBC.resgistroFerme.Empleados.first(
                     emp => emp.Id == this.idEmpleado
                     );

                this.IdEmpleado = empleado.Id_empleado;
                this.RutEmpleado = empleado.Rut_empleado;
                this.DireccionEmpleado = empleado.Direccion_empleado;
                this.TelefonoEmpleado = empleado.Telefono_empleado;
                this.CorreoEmpleado = empleado.Correo_empleado;
                this.idEmpleado = empleado.id_empleado;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Update()
        {
            try
            {
                DALC.Empleados empleado = CommonBC.resgistroFerme.Locales.first(
                    emp => emp.Id == this.idEmpleado
                    );
                empleado.Id_empleado = this.IdEmpleado;
                empleado.Rut_empleado = this.RutEmpleado;
                empleado.Nombre_empleado = this.NombreEmpleado;
                empleado.Direccion_empleado = this.DireccionEmpleado;
                empleado.Telefono_empleado = this.TelefonoEmpleado;
                empleado.Correo_empleado = this.CorreoEmpleado;
                empleado.id_empleado = this.idEmpleado;
                empleado.Contrasena = this.Contrasena;
                CommonBC.resgistroFerme.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool isValid()
        {
            Usuario.DALC.usuario usuario = CommonBC.modeloUsuario.Usuario.first(usu.usuario == this.usuario);
            if (usuario.pass == this.pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete()
        {
            try
            {
                DALC.Empleados empleados = CommonBC.resgistroFerme.Locales.first(
                    emp => emp.Id == this.idEmpleado
                    );
                CommonBC.resgistroFerme.DelateObject(empleados);
                CommonBC.resgistroFerme.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
  
