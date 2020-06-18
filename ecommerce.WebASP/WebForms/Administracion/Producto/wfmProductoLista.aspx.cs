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
    }
}