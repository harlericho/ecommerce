﻿using ecommerce.WebASP.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ecommerce.WebASP
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Session["Carrito"] == null) && (Session["Compras"]==null))
                {
                    List<clsCarrito> _listaCarrito = new List<clsCarrito>();
                    Session["Carrito"] = _listaCarrito;
                    List<clsDetalleCompra> _listaCompras = new List<clsDetalleCompra>();
                    Session["Compras"] = _listaCompras;
                    List<clsCliente> _listaClientes = new List<clsCliente>();
                    Session["Cliente"] = _listaClientes;
                }
                else
                {
                    List<clsCarrito> _listaCarrito = new List<clsCarrito>();
                    _listaCarrito = (List<clsCarrito>)Session["Carrito"];
                    if (_listaCarrito.Count > 0 && _listaCarrito != null)
                    {
                        lblContador.Text = _listaCarrito.Count.ToString();
                    }
                }
            }
        }

        protected void imbCompras_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/WebForms/Publico/wfmDetalleCompra.aspx", true);
        }
    }
}