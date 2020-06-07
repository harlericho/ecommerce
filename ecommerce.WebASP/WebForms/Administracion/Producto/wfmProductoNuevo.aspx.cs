﻿using ecommerce.WebASP.Logica;
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
    public partial class wfmProductoNuevo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            UC_Categoria1.DropDownList.SelectedIndex = 0;
        }
        private void saveProduct()
        {
            try
            {
                TBL_PRODUCTO _infoProducto = new TBL_PRODUCTO();
                _infoProducto.PRO_ID = 100;
                _infoProducto.CAT_ID = Convert.ToInt16(UC_Categoria1.DropDownList.SelectedValue);
                _infoProducto.PRO_CODIGO = txtCodigo.Text;
                _infoProducto.PRO_NOMBRE = txtNombre.Text;
                _infoProducto.PRO_DESCRIPCION = txtDescripcion.Text;
                _infoProducto.PRO_IMAGEN = "C:/imagen";
                _infoProducto.PRO_PRECIOCOMPRA = Convert.ToDecimal(txtPrc.Text);
                _infoProducto.PRO_PRECIOVENTA = Convert.ToDecimal(txtPrv.Text);
                _infoProducto.PRO_STOCKMINIMO = Convert.ToInt32(txtStockMin.Text);
                _infoProducto.PRO_STOCKMAXIMO = Convert.ToInt32(txtStockMax.Text);
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


        protected void ImbGuardar_Click(object sender, ImageClickEventArgs e)
        {
            saveProduct();
        }

        protected void ImbNuevo_Click(object sender, ImageClickEventArgs e)
        {
            newProduct();
        }

        protected void lnkGuardar_Click(object sender, EventArgs e)
        {
            saveProduct();
        }

        protected void lnkNuevo_Click(object sender, EventArgs e)
        {
            newProduct();
        }
    }
}