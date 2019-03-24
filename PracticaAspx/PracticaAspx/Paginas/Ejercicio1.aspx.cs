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
        #region Protected Methods
        /// <summary>
        /// Metodo para cargar los datos de la pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.cargarCiudades();
            }
        }//Page_Load
        /// <summary>
        /// Cargar los datos de la ciudades en el DropDawnList
        /// </summary>
       protected void cargarCiudades()
        {
            ListItem item1 = new ListItem("MEXICO");
            this.dropDown.Items.Add(item1);
        }

        #endregion
    }
}