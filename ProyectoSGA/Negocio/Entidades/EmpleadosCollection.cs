using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
   public class EmpleadosCollection
    { 
       private List<Empleados> GenerarListadoEmpleados<List<DALC.Empleados> listEmpleadoDALC)
        {
            List<Empleados> listEmpleados = new List<Empleados>();
            foreach (DALC.Empleados emp in listEmpleadosDALC)
            {
                Empleados empleados = new Empleados();
                empleados.IdEmpleado = emp.Id_empleado;
                empleados.RutEmpleado = emp.Rut_empleado;
                empleados.DireccionEmpleado = emp.Direccion_empleado;
                empleados.Fecha_nacimiento = emp.Fecha_nacimiento;
                empleados.TelefonoEmpleado = emp.Telefono_empleado;
                empleados.CorreoEmpleado = emp.Correo_empleado;
                empleados.Perfil_id_perfil = emp.Perfil_id_perfil;
                empleados.Est_usu_id_estado_usu = emp.Est_usu_id_estado_usu;
                listEmpleados.Add(empleados);
            }
            return listEmpleados;
        }
        private List<Sucursales> GenerarListadoSucursales<List<DALC.Sucursales> listSucursalDALC)
        {
            List<Sucursales> listSucursales = new List<Sucursales>();
            foreach (DALC.Sucursales suc in listSucursalesDALC)
            {
                Sucursales sucursales = new Sucursales();
                sucursales.Id_sucursal = suc.Id_sucursal;
                sucursales.Direccion_sucursal = suc.Direccion_sucursal;
                sucursales.Nombre_sucursal = suc.Nombre_sucursal;
                sucursales.Telefono_sucursal = suc.Telefono_sucursal;
                sucursales.Producto_sucursal_id_prod_suc = suc.Producto_sucursal_id_prod_suc;
                listSucursales.Add(sucursales);
            }
            return listSucursales;
        }
       
       private List<Compra> GenerarListadoCompra<List<DALC.Empleados> listCompraDALC)
        {
            List<Compra> listCompra = new List<Compra>();
            foreach (DALC.Compra com in listDALC)
            {
                Compra compra = new Compra();
                compra.idCompra = com.id_Compra;
                compra.DescCompra = com.desc_compra;
                compra.Total = com.total;
                compra.FechaCreacion = com.Fecha_creacion;
                compra.IdProveedor = com.id_proveedor;
                compra.EstadoOrden = com.estado_orden;
                compra.IdEmpleado = com.id_empleado;
                compra.Contrasena = com.contrasemna;
                listCompra.Add(compra);
            }
            return listCompra;
        }
        public List<Empleados> ObtenerEmpleados()
        {
            var empleados = CommonBC.modeloEmpleados.Empleados();
            return GenerarListadoEmpleados(empleados.ToList());
        }
        public List<Sucursales> ObtenerSucursales()
        {
            var sucursales = CommonBC.modeloSucursales.Sucursales();
            return GenerarListadoSucursales(sucursales.ToList());
        }
        public List<Sucursales> ObtenerSucursales(int idEmpleado)
        {
            var sucursales = CommonBC.modeloSucursales.Sucursales.where(suc=> suc.idEmpleado== idEmpleado);
            return GenerarListadoSucursales(sucursales.ToList());
        }
        public List<Compra> ObtenerCompra()
        {
            var compra = CommonBC.modeloCompra.Compra();
            return GenerarListadoCompra(compra.ToList());
        }
        public List<EstadoEmpleados> ObtenerEstadoEmpleado()
        {
            var estadoEmpleado = CommonBC.modeloEstadoEmpleado.EstadoEmpleado();
            return GenerarListadoEstadoEmpleado(estadoEmpleado.ToList());
        }
        public int EmpleadosPorSucursal(int idSucursal)
        {
            int empleadosPorSucursal = CommonBC.ModeloEmpleados.Empleados.Where(emp => emp.IdSucursal).ToList().Count;
            return empleadosPorSucursal;
        }
        public string EstadoEmpleado(string idEstadoEmpleado)
        {
            string estadoEmpleado = CommonBC.ModeloEmpleados.estadoEmpleado.Where(emp => emp.IdEstadoEmpleado).ToList().Count;
            return estadoEmpleado;
        }
         public string EstadoCompra(string idEstadoCompra)
        {
            string estadoCompra = CommonBC.ModeloCompra.estadoCompra.Where(com => com.IdEstadoCompra).ToList().Count;
            return estadoCompra;
        }
    }
}

