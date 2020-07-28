<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmDetalleCompra.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Publico.wfmDetalleCompra" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>
        <asp:Label ID="Label1" runat="server" Text="Detalle de la compra"></asp:Label>
    </h3>
    <br />
    <table>
        <tr>
            <td>
                <asp:GridView ID="grVDetalleCompra" runat="server" Width="296%">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
               <strong>Subtotal $: </strong> <asp:Label ID="lblSubTotal" runat="server" Text="0.00" ForeColor="Blue"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
               <u>Iva 0%: </u> <asp:Label ID="lblIva0" runat="server" Text="0.00"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
              <u>Iva 12%: </u> <asp:Label ID="lblIva12" runat="server" Text="0.00" ForeColor="Gray"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
              <b>Total compra $: </b>  <asp:Label ID="lblTotal" runat="server" Text="0.00" ForeColor="Green"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
