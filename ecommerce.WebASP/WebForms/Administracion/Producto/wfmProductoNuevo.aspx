<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmProductoNuevo.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Administracion.Producto.wfmProductoNuevo" %>
<%@ Register Src="~/UserControl/ucCategoria.ascx" TagName="UC_Categoria" TagPrefix="Uc1" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
    <table>
        <tr>
            <td colspan="2" style="text-decoration: underline">
                Producto
            </td>
        </tr>
        <tr>
            <td colspan="2">
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Id
            </td>
            <td style="width: 130px">
                <asp:Label ID="lblId" runat="server" Text="#"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Categoria
            </td>
            <td style="width: 130px">
               <%--<asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>--%>
                <Uc1:uc_categoria ID="UC_Categoria1" runat="server"></Uc1:uc_categoria>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Codigo
            </td>
            <td style="width: 130px">
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Nombre
            </td>
            <td style="width: 130px">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Precio de compra
            </td>
            <td style="width: 130px">
                <asp:TextBox ID="txtPrc" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Precio de venta
            </td>
            <td style="width: 130px">
                <asp:TextBox ID="txtPrv" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Imagen
            </td>
            <td style="width: 130px">
                <asp:FileUpload  ID="fileuImagen" runat="server"/>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Descripcion
            </td>
            <td style="width: 130px">
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Stock minino
            </td>
            <td style="width: 130px">
                <asp:TextBox ID="txtStockMin" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                Stock maximo
            </td>
            <td style="width: 130px">
                <asp:TextBox ID="txtStockMax" runat="server"></asp:TextBox>
            </td>
        </tr>

    </table>


</asp:Content>
