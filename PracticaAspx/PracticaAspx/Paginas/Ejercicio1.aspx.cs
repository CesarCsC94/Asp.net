using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaAspx.Paginas
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.cargarCiudades();
        }//Page_Load

       protected void cargarCiudades()
        {
            ListItem item1 = new ListItem("MEXICO");
            this.dropDown.Items.Add(item1);
        }
    }
}