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
    public partial class wfmCliente1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }


        //guardar clientes
        private void saveClients()
        {
            try
            {
                TBL_CLIENTE _infoClientes = new TBL_CLIENTE();
                _infoClientes.cli_identificacion = txtIdentificacion.Text;
                _infoClientes.cli_tipoidentificacion = char.ToString('C');
                _infoClientes.cli_apellidos = txtApellidos.Text;
                _infoClientes.cli_nombres = txtNombres.Text;
                _infoClientes.cli_fechanacimiento = DateTime.Parse(txtFechNac.Text);
                _infoClientes.cli_genero = char.ToString('M');
                _infoClientes.cli_telefono = txtTelefono.Text;
                _infoClientes.cli_email = txtEmail.Text.ToLower();
                Task<bool> _taskSaveClients = Task.Run(() => LogicaCliente.saveClients(_infoClientes));
                _taskSaveClients.Wait();
                var resultado = _taskSaveClients.Result;
                if (resultado)
                {
                    //lblMensaje.Text = "Cliente Guardado Correctamente";
                    List<clsCliente> _listaClientes = new List<clsCliente>();
                    _listaClientes = (List<clsCliente>)Session["Cliente"];
                    clsCliente _infoClientes1 = new clsCliente();
                    _infoClientes1.idCliente = int.Parse(_infoClientes.cli_id.ToString());
                    _infoClientes1.identificacionCliente = txtIdentificacion.Text;
                    _infoClientes1.apellidosCliente = txtApellidos.Text;
                    _infoClientes1.nombresCliente = txtNombres.Text;
                    _infoClientes1.telefonoCliente = txtTelefono.Text;
                    _listaClientes.Add(_infoClientes1);
                    Session["Cliente"] = _listaClientes;
                    Response.Redirect("wfmPedido.aspx", true);

                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = "" + ex.Message;
            }
        }

        protected void ImbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            saveClients();
        }

        protected void lnkGuardar_Click(object sender, EventArgs e)
        {
            saveClients();
        }

        //nuevo cliente
        private void newClients()
        {
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtIdentificacion.Text = "";
            txtFechNac.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }




    }
}