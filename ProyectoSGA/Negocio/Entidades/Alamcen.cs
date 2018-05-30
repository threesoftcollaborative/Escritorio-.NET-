
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Almacen
    {
        public Almacen()
        {
            this.ObjOrdenCompra = new List<OrdenCompra>();
            this.ObjBoleta = new List<Boleta>();
            this.ObjCliente = new List<Cliente>();
            this.ObjProveedor = new List<Proveedor>();
            this.ObjUsuario = new List<Usuario>();
        }

        public decimal ID_ALMACEN { get; set; }
        public string NOMBRE { get; set; }
        public decimal ID_CATEGORIA { get; set; }
        public string DIRECCION { get; set; }
        public decimal ID_COMUNA { get; set; }
        public string ESTADO { get; set; }

        public virtual List<OrdenCompra> ObjOrdenCompra { get; set; }
        public virtual List<Boleta> ObjBoleta { get; set; }
        public virtual List<Cliente> ObjCliente { get; set; }
        public virtual List<Proveedor> ObjProveedor { get; set; }
        public virtual List<Usuario> ObjUsuario { get; set; }
        public virtual Categoria ObjCategoria { get; set; }
        public virtual Comuna ObjComuna { get; set;
        }
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
                alm.IdComuna = this.idComuna;
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
  
