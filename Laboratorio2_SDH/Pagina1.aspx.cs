using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio2_SDH
{
    public partial class Pagina1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cliente> aux = (List<Cliente>)Session["ListadoClientes"];

            foreach (Cliente item in aux)
            {
                Login.InnerHtml = item.nombre;
            }
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            Func<double, double> doble = Gestion.multiplicar;
            double numero = Convert.ToDouble(txtNum1.Text);
            double respuesta = doble(numero);
            txtRespuesta.Text = respuesta.ToString();

            Action<string> salvar = Gestion.bitacorasalvada;
            string bitacora = String.Format("Al multiplicar el número {0} por 2, da como resultado {1}.", numero, respuesta);
            salvar(bitacora);

        }
    }
}