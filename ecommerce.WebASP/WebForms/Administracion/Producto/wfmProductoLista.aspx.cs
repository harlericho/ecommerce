using ecommerce.WebASP.Logica;
using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce.WebASP.WebForms.Administracion.Producto
{
    public partial class wfmProductoLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Task<List<TBL_PRODUCTO>> _taskProductos = Task.Run(() => LogicaProducto.getAllProduct());
                _taskProductos.Wait();
                var _listaProductos = _taskProductos.Result;
                loadProductos(_listaProductos);
            }
            UC_DatosEventos();
        }

        private void UC_DatosEventos()
        {
            GridView gridView = (GridView)this.UC_Datos1.FindControl("GridView1");
            gridView.RowCommand += new GridViewCommandEventHandler(Uc_Datos_RowCommand);
        }

        void Uc_Datos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string codigo = Convert.ToString(e.CommandArgument);
            if (e.CommandName == "Modificar")
            {
                //encriptar
                Response.Redirect("wfmProductoNuevo.aspx?cod=" + codigo, true);
            }
            if (e.CommandName == "Eliminar")
            {
                TBL_PRODUCTO _infoProducto = new TBL_PRODUCTO();
                var taskProducto = Task.Run(() => LogicaProducto.getProductxId(int.Parse(codigo)));
                taskProducto.Wait();
                _infoProducto = taskProducto.Result;
                if (_infoProducto != null)
                {
                    Task<bool> _taskSaveProduct = Task.Run(() => LogicaProducto.deleteProduct(_infoProducto));
                    _taskSaveProduct.Wait();
                    var resultado = _taskSaveProduct.Result;
                    if (resultado)
                    {
                       // Response.Write("<script>alert('Registro Eliminado correctamente');</script>");
                        Task<List<TBL_PRODUCTO>> _taskProductos = Task.Run(() => LogicaProducto.getAllProduct());
                        _taskProductos.Wait();
                        var _listaProductos = _taskProductos.Result;
                        loadProductos(_listaProductos);
                    }
                }
            }
        }



        private void loadProductos(List<TBL_PRODUCTO> _listaProductos)
        {

            if (_listaProductos != null && _listaProductos.Count > 0)
            {
                UC_Datos1.loadData(_listaProductos.Select(data => new
                {
                    ID = data.pro_id,
                    CODIGO = data.pro_codigo,
                    NOMBRE = data.pro_nombre,
                    PRECIO_C = data.pro_preciocompra.ToString("0.00"),
                    PRECIO_V = data.pro_precioventa.ToString("0.00"),
                    STOCK_MIN = data.pro_stockminimo,
                    STOCK_MAX = data.pro_stockmaximo,
                    CATEGORIA = data.TBL_CATEGORIA.cat_nombre,
                    ESTADO = data.pro_status,

                }).ToList());
            }
        }

        protected void imbBuscar_Click(object sender, ImageClickEventArgs e)
        {
            Buscar(ddlBuscar.SelectedValue);
        }

        private void Buscar(string opcion)
        {
            if (!string.IsNullOrEmpty(txtBuscar.Text))
            {
                List<TBL_PRODUCTO> _listaProductos = new List<TBL_PRODUCTO>();
                string dataBuscar = txtBuscar.Text;
                switch (opcion)
                {
                    case "T":
                        Task<List<TBL_PRODUCTO>> _taskProductos = Task.Run(() => LogicaProducto.getAllProduct());
                        _taskProductos.Wait();
                        _listaProductos = _taskProductos.Result;
                        loadProductos(_listaProductos);
                        break;
                    case "C":
                        Task<List<TBL_PRODUCTO>> _taskProductos2 = Task.Run(() => LogicaProducto.searchProductXCode(dataBuscar));
                        _taskProductos2.Wait();
                        _listaProductos = _taskProductos2.Result;
                        loadProductos(_listaProductos);
                        break;
                    case "N":
                        Task<List<TBL_PRODUCTO>> _taskProductos3 = Task.Run(() => LogicaProducto.searchProductXNombre(dataBuscar));
                        _taskProductos3.Wait();
                        _listaProductos = _taskProductos3.Result;
                        loadProductos(_listaProductos);
                        break;
                    case "Ca":
                        Task<List<TBL_PRODUCTO>> _taskProductos4 = Task.Run(() => LogicaProducto.searchProductXCategoria(dataBuscar));
                        _taskProductos4.Wait();
                        _listaProductos = _taskProductos4.Result;
                        loadProductos(_listaProductos);
                        break;
                }
            }
        }

        protected void ImbNuevo_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfmProductoNuevo.aspx", true);
        }

        protected void lnkNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmProductoNuevo.aspx", true);
        }
    }
}