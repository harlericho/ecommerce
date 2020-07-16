using ecommerce.WebASP.Logica;
using ecommerce.WebASP.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce.WebASP.WebForms.Administracion.Producto
{
    public partial class wfmProductoNuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request["cod"]!=null)
                {
                    int idProducto = Convert.ToInt32(Request["cod"].ToString());
                    loadProducto(idProducto);
                }
            }
        }

        private void loadProducto(int idProducto)
        {
            TBL_PRODUCTO _infoProducto = new TBL_PRODUCTO();
            var task = Task.Run(()=>LogicaProducto.getProductxId(idProducto));
            task.Wait();
            _infoProducto = task.Result;
            if (_infoProducto!=null)
            {
                lblId.Text = _infoProducto.pro_id.ToString();
                txtCodigo.Text = _infoProducto.pro_codigo;
                UC_Categoria1.DropDownList.SelectedValue = _infoProducto.cat_id.ToString();
                txtNombre.Text = _infoProducto.pro_nombre;
                txtDescripcion.Text = _infoProducto.pro_descripcion;
                txtPrc.Text = _infoProducto.pro_preciocompra.ToString();
                txtPrv.Text = _infoProducto.pro_precioventa.ToString();
                txtStockMin.Text = _infoProducto.pro_stockminimo.ToString();
                txtStockMax.Text = _infoProducto.pro_stockmaximo.ToString();
            }
        }

        private void newProduct()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrc.Text = "";
            txtPrv.Text = "";
            txtStockMax.Text = "";
            txtStockMin.Text = "";
            //Avatar.ImageUrl = "~/Images/preview-icon.png";
            UC_Categoria1.DropDownList.SelectedIndex = 0;
            lblMensaje.Text = "";

        }
        private void saveProduct()
        {
            try
            {
                TBL_PRODUCTO _infoProducto = new TBL_PRODUCTO();
                //_infoProducto.pro_id = 102;
                _infoProducto.cat_id = Convert.ToInt16(UC_Categoria1.DropDownList.SelectedValue);
                _infoProducto.pro_codigo = txtCodigo.Text;
                _infoProducto.pro_nombre = txtNombre.Text;
                _infoProducto.pro_descripcion = txtDescripcion.Text;
                _infoProducto.pro_imagen = "C:/imagen";
                _infoProducto.pro_preciocompra = Convert.ToDecimal(txtPrc.Text);
                _infoProducto.pro_precioventa = Convert.ToDecimal(txtPrv.Text);
                _infoProducto.pro_stockminimo = Convert.ToInt32(txtStockMin.Text);
                _infoProducto.pro_stockmaximo = Convert.ToInt32(txtStockMax.Text);
                Task<bool> _taskSaveProduct = Task.Run(() => LogicaProducto.saveProduct(_infoProducto));
                _taskSaveProduct.Wait();
                var resultado = _taskSaveProduct.Result;
                if (resultado)
                {
                    lblMensaje.Text = "Registro Guardado Correctamente";
                }
            }
            catch (Exception ex)
            {

                lblMensaje.Text = "" + ex.Message;
            }
        }


        private void updateProduct()
        {
            try
            {
                TBL_PRODUCTO _infoProducto = new TBL_PRODUCTO();
                var taskProducto = Task.Run(() => LogicaProducto.getProductxId(int.Parse(lblId.Text)));
                taskProducto.Wait();
                _infoProducto = taskProducto.Result;
                if (_infoProducto!=null)
                {
                    _infoProducto.pro_id = int.Parse(lblId.Text);
                    _infoProducto.cat_id = Convert.ToInt16(UC_Categoria1.DropDownList.SelectedValue);
                    _infoProducto.pro_codigo = txtCodigo.Text;
                    _infoProducto.pro_nombre = txtNombre.Text;
                    _infoProducto.pro_descripcion = txtDescripcion.Text;
                    _infoProducto.pro_imagen = "C:/imagen";
                    _infoProducto.pro_preciocompra = Convert.ToDecimal(txtPrc.Text);
                    _infoProducto.pro_precioventa = Convert.ToDecimal(txtPrv.Text);
                    _infoProducto.pro_stockminimo = Convert.ToInt32(txtStockMin.Text);
                    _infoProducto.pro_stockmaximo = Convert.ToInt32(txtStockMax.Text);
                    Task<bool> _taskSaveProduct = Task.Run(() => LogicaProducto.updateProduct(_infoProducto));
                    _taskSaveProduct.Wait();
                    var resultado = _taskSaveProduct.Result;
                    if (resultado)
                    {
                        lblMensaje.Text = "Registro Modificado Correctamente";
                        Response.Redirect("wfmProductoLista.aspx", true);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }




        protected void ImbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text))
            {
                updateProduct();
            }
            else
            {
                saveProduct();
            }
        }

        protected void ImbNuevo_Click(object sender, ImageClickEventArgs e)
        {
            newProduct();
        }

        protected void lnkGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblId.Text))
            {
                updateProduct();
            }
            else
            {
                saveProduct();
            }
        }

        protected void lnkNuevo_Click(object sender, EventArgs e)
        {
            newProduct();
        }

        //protected void btnMostrar_Click(object sender, EventArgs e)
        //{
        //    uploadImage();
        //}

        //private void uploadImage() 
        //{
        //    int tamaño = fileImagen.PostedFile.ContentLength;//se crea un tamaño de imagen, esto devuelve el tamaño de la imagen que el usuario envia
        //    byte[] imagen = new byte[tamaño];//creamos un arreglo de byte del tamaño de la imagen definida
        //    fileImagen.PostedFile.InputStream.Read(imagen, 0, tamaño);//lee la imagen original a partir del elemento fileupload
        //    Bitmap imagenBinaria = new Bitmap(fileImagen.PostedFile.InputStream);//convierte o prepara la imagen a binaria
        //    string imagendata = "data:image/jpg;base64," + Convert.ToBase64String(imagen);//convierte la imagen a un equivalente a un dato binario de base 64
        //    Avatar.ImageUrl = imagendata;//visualizamos la imagen bianria base 64 al url imagen
        //}

        
    }
}