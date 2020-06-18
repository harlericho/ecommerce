<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmProductoLista.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Administracion.Producto.wfmProductoLista" %>

<%@ Register Src="~/UserControl/ucGridviewDatos.ascx" TagName="UC_Datos" TagPrefix="Uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <div width="95%">
        <center>
            <table width="95% >
                <tr>
                    <td colspan="3">
                        <h3 class="text-center"><strong>Lista de Productos</strong></h3>
                    </td>
                </tr>
                <tr>
                    <td>
                        <center>
                            <table>
                            <tr>
                                <td>
                                    Buscar por: 
                                </td>
                                <td>
                                    <asp:DropDownList ID="ddlBuscar" runat="server">
                                        <asp:ListItem Value="T">Todos</asp:ListItem>
                                        <asp:ListItem Value="C">Codigo</asp:ListItem>
                                        <asp:ListItem Value="N">Nombre</asp:ListItem>
                                        <asp:ListItem Value="Ca">Categoria</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:ImageButton ID="imbBuscar" runat="server" ImageUrl="~/Icons/lupa.png" OnClick="imbBuscar_Click"></asp:ImageButton>
                                </td>
                            </tr>
                        </table>
                        </center>
                    </td>
                </tr>
            </table>
        <br />
    <Uc1:UC_Datos ID="UC_Datos1" runat="server"></Uc1:UC_Datos>
        </center>
    </div>
</asp:Content>
