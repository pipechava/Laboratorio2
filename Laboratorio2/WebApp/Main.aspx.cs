using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.ServiceReference1;

namespace WebApp
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Productos> prodL = new List<Productos>();
            Service1Client service1 = new Service1Client();

            GridView1.DataSource = service1.MostrarProductos();
            GridView1.DataBind();

        }

        protected void btnSelect_Click(object sender, EventArgs e)
        {
            List<Productos> prodL = new List<Productos>();
            Productos prod = new Productos();

            prod.NombreProducto = txtNombreProducto.Text;
            prod.FechaFacturaInicio = txtFechaInicio.Text;
            prod.FechaFacturaFin = txtFechaFin.Text;
 

            Service1Client service1 = new Service1Client();
            GridView1.DataSource = service1.GetProductos();
            GridView1.DataBind();
            

        }
    }
}