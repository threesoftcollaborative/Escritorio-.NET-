using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WPF_RegistroFerme
{
    public partial class ListadoEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarDatosGridView();
            }
        }
        private void CargarDatosGridView()
        {
            List<Empleados> listEmpleados = new EmpleadosCollection().ObtenerEmpleados();
            gvEmpleados.DataSource = listEmpleados;
            gvEmpleados.DataBind();

        }
    }
}