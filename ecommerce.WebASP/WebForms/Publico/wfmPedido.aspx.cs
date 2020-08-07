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
    public partial class wfmPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Cliente"] != null) && (Session["Compras"] != null))
            {
                List<clsCliente> _listaCliente = new List<clsCliente>();
                _listaCliente = (List<clsCliente>)Session["Cliente"];

                List<clsDetalleCompra> _listaCompras = new List<clsDetalleCompra>();
                _listaCompras = (List<clsDetalleCompra>)Session["Compras"];

                loadPedido(_listaCliente, _listaCompras);

            }
        }

        private void loadPedido(List<clsCliente> _listaCliente, List<clsDetalleCompra> _listaCompras)
        {
            foreach (var item in _listaCliente)
            {
                txtIdCliente.Text = item.idCliente.ToString();
                txtIdentificacion.Text = item.identificacionCliente;
                txtNombres.Text = item.apellidosCliente + " " + item.nombresCliente;
                txtTelefono.Text = item.telefonoCliente;
            }

            foreach (var item in _listaCompras)
            {
                txtSubtotal.Text = item.subTotalCompra.ToString();
                txtTotal.Text = item.TotalCompra.ToString();
            }
        }



        //guardar pedido
        private void savePedido()
        {

            try
            {
                TBL_PEDIDO _infoPedido = new TBL_PEDIDO();
                _infoPedido.ped_cliente = txtNombres.Text.ToUpper();
                _infoPedido.ped_direccion = txtDireccion.Text.ToUpper();
                _infoPedido.ped_fecha = DateTime.Parse(txtFechaPed.Text);
                _infoPedido.ped_identificacion = txtIdentificacion.Text;
                _infoPedido.ped_numero = Convert.ToInt32(txtNumeroPed.Text);
                _infoPedido.ped_subtotal = Convert.ToDecimal(txtSubtotal.Text);
                _infoPedido.ped_telefono = txtTelefono.Text;
                _infoPedido.ped_total = Convert.ToDecimal(txtTotal.Text);
                _infoPedido.cli_id = int.Parse(txtIdCliente.Text);
                Task<bool> _taskSavePedido = Task.Run(() => LogicaPedido.savePedido(_infoPedido));
                _taskSavePedido.Wait();
                var resultado = _taskSavePedido.Result;
                if (resultado)
                {
                    lblMensaje.Text = "Pedido Guardado Correctamente";
                    lnkGuardar.Attributes.Add("disabled", "disabled");
                    lnkGuardar.Enabled = false;
                    ImbGuardar.Attributes["disabled"] = "disabled";
                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = "" + ex.Message;
            }
        }

        //limpiar sessiones crear nuevo pedido
        private void newSession()
        {

            Session.Clear();
            Session.RemoveAll();
            Response.Redirect("wfmCatalogo.aspx", true);
        }

        protected void ImbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            savePedido();
        }

        protected void lnkGuardar_Click(object sender, EventArgs e)
        {
            savePedido();
        }

        protected void lmbNuevoPedido_Click(object sender, ImageClickEventArgs e)
        {
            newSession();
        }

        protected void lnkNuevoPedido_Click(object sender, EventArgs e)
        {
            newSession();
        }
    }
}