using ecommerce.WebASP.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce.WebASP.WebForms.Publico
{
    public partial class wfmDetalleCompra : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Carrito"] != null)
                {
                    List<clsCarrito> _listaCarrito = new List<clsCarrito>();
                    _listaCarrito = (List<clsCarrito>)Session["Carrito"];
                    loadCarrito(_listaCarrito);
                }
            }
        }

        private void loadCarrito(List<clsCarrito> _listaCarrito)
        {

            int contador = 1;
            decimal subtotal = 0; decimal iva0 = 0; decimal iva12 = 0; decimal total = 0;
            foreach (var item in _listaCarrito)
            {
                item.numeroProducto = contador;
                item.valorTotal = item.precioProducto * item.cantidadProducto;
                subtotal = subtotal + item.valorTotal;

                contador++;
            }

            iva12 = (subtotal * Convert.ToDecimal("0.12"));
            total = subtotal + iva12;

            int id = 0; int cant = 0;

            if (_listaCarrito.Count > 0 && _listaCarrito != null)
            {
                grVDetalleCompra.DataSource = _listaCarrito.Select(data => new
                {
                    No = data.numeroProducto,
                    Codigo = data.codigoProducto,
                    Cantidad = data.cantidadProducto,
                    Producto = data.nombreProducto,
                    Precio = data.precioProducto,
                    Valor_Total = data.valorTotal
                }).ToList();
                grVDetalleCompra.DataBind();
            }

            lblSubTotal.Text = subtotal.ToString("0.00");
            lblIva12.Text = iva12.ToString("0.00");
            lblTotal.Text = total.ToString("0.00");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (!lblTotal.Text.Equals("0.00"))
            {
                List<clsDetalleCompra> _listaCompras = new List<clsDetalleCompra>();
                _listaCompras = (List<clsDetalleCompra>)Session["Compras"];
                clsDetalleCompra _infoCompras = new clsDetalleCompra();
                _infoCompras.subTotalCompra = decimal.Parse(lblSubTotal.Text);
                _infoCompras.TotalCompra = decimal.Parse(lblTotal.Text);
                _listaCompras.Add(_infoCompras);
                Session["Compras"] = _listaCompras;
                Response.Redirect("wfmBuscarCliente.aspx", true);
            }
            else
            {
                lblMensaje.Text = "Realize una compra al carrito";
            }
        }




    }
}