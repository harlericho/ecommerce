using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce.WebASP.UserControl
{
    public partial class ucGridviewDatos : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public GridView GridView 
        {
            get 
            {
                return GridView1;
            }
            set
            {
                GridView1 = value;
            }
        }
        public void loadData(dynamic _lista) 
        {
            if (_lista!=null)
            {
                GridView1.DataSource =_lista;
                GridView1.DataBind();
            }
        }

    }
}