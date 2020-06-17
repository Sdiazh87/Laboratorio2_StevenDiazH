using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio2_SDH
{
    public partial class login : System.Web.UI.Page
    {
        Cliente objUsuario = new Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            List<Cliente> clientes = new List<Cliente>();
            objUsuario.usuario = "sdiazh";
            objUsuario.clave = "12345";
            objUsuario.nombre = "Steven Díaz Hernández";
            clientes.Add(objUsuario);
            
            Session["ListadoClientes"] = clientes;
                       
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == objUsuario.usuario && txtPassword.Text == objUsuario.clave)
            {
                Response.Redirect("Pagina1.aspx");
            }
            else
            {
                txtUsuario.Text = "";
                txtPassword.Text = ""; 
            }


        }

        
    }
}