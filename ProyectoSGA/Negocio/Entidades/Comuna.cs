
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Comuna
    {
        public Comuna()
        {
            this.ObjAlmacen = new List<Almacen>();
            this.ObjProveedor = new List<Proveedor>();
        }

        public decimal ID_COMUNA { get; set; }
        public string COMUNA { get; set; }
        public string ESTADO { get; set; }

        public virtual List<Almacen> ObjAlmacen { get; set; }
        public virtual List<Proveedor> ObjProveedor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>


        public bool Create()
        {
            try
            {
                DALC.sga_alamcen alm = new DALC.sga_alamcen();
                alm.Nombre = this.nombre;
                alm.IdCategoria = this.idCategoria;
                alm.Direccion = this.direccion;
                alm.IdComuna = this.IdComuna;
                alm.Estado = this.Estado;
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
  
