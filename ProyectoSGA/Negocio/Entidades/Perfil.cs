using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Perfil
    {
        public Perfil()
        {
            this.ObjUsuario = new List<Usuario>();
        }

        public decimal ID_PERFIL { get; set; }
        public string DESCRIPCION { get; set; }
        public string ESTADO { get; set; }
        public decimal ID_MENU { get; set; }
        public virtual Menu ObjMenu { get; set; }
        public virtual List<Usuario> ObjUsuario { get; set; }



        //public Perfil(int idPerfil, string descripcion, char estado, int idMenu)
        //{
        //    this.IdPerfil = idPerfil;
        //    this.Descripcion = descripcion;
        //    this.Estado = estado;
        //    this.IdMenu = idMenu;
        //}

        public bool Create()
        {
            try
            {
                DALC.SGA_PERFIL per = new DALC.SGA_PERFIL();
                per.ID_PERFIL = this.nombre;
                per.DESCRIPCION = this.idCategoria;
                per.ESTADO = this.direccion;
                per.SGA_MENU = this.idComuna;
                alm.Estado = this.estado;
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
            Empleados.DALC.empleados empleados = CommonBC.modeloEmpleados.Empleados.first(emp.Nombre_empleado == this.NombreEmpleado);
            if (empleados.Contrasena == this.Contrasena)
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
  
