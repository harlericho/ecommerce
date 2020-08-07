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
    public partial class wfmCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void btnFiltro_Click(object sender, EventArgs e)
        {
            loadCliente();
        }



        //buscar clientes
        private void Buscar(string opcion)
        {
            if (!string.IsNullOrEmpty(opcion))
            {
                TBL_CLIENTE _infoClientes = new TBL_CLIENTE();
                var task = Task.Run(() => LogicaCliente.getClientsDni(opcion));
                task.Wait();
                _infoClientes = task.Result;
                if (_infoClientes != null)
                {
                    lblID.Text = _infoClientes.cli_id.ToString();
                    lblDni.Text = _infoClientes.cli_identificacion;
                    lblApellidos.Text = _infoClientes.cli_apellidos;
                    lblNombres.Text = _infoClientes.cli_nombres;
                    lblTelefono.Text = _infoClientes.cli_telefono;
                    lblMensaje.Text = "Cliente encontrado";
                }
                else
                {
                    lblMensaje.Text = "No se encontro resultado";
                    mensaje();
                }
            }
            else
            {
                lblMensaje.Text = "Escriba un DNI";
                mensaje();
            }
        }

        //lsitado cliente
        private void loadCliente()
        {
            Buscar(txtBuscar.Text);
        }



        //mensaje de confirmacion
        private void mensaje()
        {
            txtBuscar.Focus();
            lblID.Text = "";
            lblDni.Text = "";
            lblApellidos.Text = "";
            lblNombres.Text = "";
        }


        //pedido
        private void pedidoCliente()
        {
            if (!string.IsNullOrEmpty(lblDni.Text))
            {
                List<clsCliente> _listaClientes = new List<clsCliente>();
                _listaClientes = (List<clsCliente>)Session["Cliente"];
                clsCliente _infoClientes = new clsCliente();
                _infoClientes.idCliente = int.Parse(lblID.Text);
                _infoClientes.identificacionCliente = lblDni.Text;
                _infoClientes.apellidosCliente = lblApellidos.Text.ToUpper();
                _infoClientes.nombresCliente = lblNombres.Text.ToUpper();
                _infoClientes.telefonoCliente = lblTelefono.Text;
                _listaClientes.Add(_infoClientes);
                Session["Cliente"] = _listaClientes;
                Response.Redirect("wfmPedido.aspx", true);

            }
            else
            {
                lblMensaje.Text = "No existe cliente !!, añadir uno o buscar";
            }
        }
        protected void ImagePedido_Click(object sender, ImageClickEventArgs e)
        {
            pedidoCliente();
        }

        protected void lnkPedido_Click(object sender, EventArgs e)
        {
            pedidoCliente();
        }

        protected void ImbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("wfmCliente.aspx", true);
        }

        protected void lnkGuardar_Click(object sender, EventArgs e)
        {
            Response.Redirect("wfmCliente.aspx", true);
        }
    }
}