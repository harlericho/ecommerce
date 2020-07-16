using ecommerce.WebASP.Logica;
using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce.WebASP.WebForms.Publico
{
    public partial class wfmCatalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadCatalogo();
            }
        }

        private void loadCatalogo()
        {
            Task<List<TBL_PRODUCTO>> _taskProducto = Task.Run(() => LogicaProducto.getAllProduct());
            _taskProducto.Wait();
            var _listaProdcutos = _taskProducto.Result;

            DataList1.DataSource = _listaProdcutos.Select(data => new
            {
                ID = data.pro_id,
                Nombre = data.pro_nombre,
                Precio = data.pro_precioventa.ToString("0.00"),
                URL = data.pro_imagen
            }).ToList();
            DataList1.DataBind();
        }

        protected void DataList1_ItemCommand(object source, DataListCommandEventArgs e)
        {
            string codigo = Convert.ToString(e.CommandArgument);
            if (e.CommandName == "Comprar")
            {
                //encriptar
                Response.Redirect("wfmProducto.aspx?cod=" + codigo, true);
            }
        }
    }
}