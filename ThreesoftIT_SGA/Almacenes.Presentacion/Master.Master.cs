using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Almacenes.Presentacion
{
    public partial class Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["usuario"] == null)
                {
                    Salir();
                }
            }

        }

        private void Salir()
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx");
        }

        protected void lgsEstadoAutenticacion_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Salir();
        }
    }
}