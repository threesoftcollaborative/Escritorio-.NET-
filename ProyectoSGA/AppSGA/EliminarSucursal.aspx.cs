using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace WPF_RegistroFerme
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();
            sucursales.Read();
            lblIdSuc.Text = sucursales.IdSucursal.ToString();
            lblNomSuc.Text = sucursales.NombreSucursal.ToString();
            lblTeleSuc.Text = sucursales.TelefonoSucursal.ToString();
            lblHorEntra.Text = sucursales.HorarioEntrada.ToString();
            lblHoraSal.Text = sucursales.HorarioSalida.ToString();
            lblDirecSuc.Text = sucursales.DireccionSucursal.ToString();
        }
        private void limpiarCampos()
        {
            txtIdSucursal.Text = "";
            lblIdSuc.Text = "";
            lblNomSuc.Text = "";
            lblTeleSuc.Text = "";
            lblHorEntra.Text = "";
            lblHoraSal.Text = "";
            lblDirecSuc.Text = "";
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Sucursales sucursales = new Sucursales();
            sucursales.IdSucursal = int.Parse(lblIdSuc.Text);

            bool seElimino = sucursales.Delete();

            if (seElimino)
            {
                lblResultados.Text = "La sucursal fue eliminada de forma correcta";
            }
            else
            {
                lblResultados.Text = "La sucursal no se logro eliminar, intente nuevamente";
            }
            limpiarCampos();
        }
    }
}