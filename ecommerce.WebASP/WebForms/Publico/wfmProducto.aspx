<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmProducto.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Publico.wfmProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>
        <asp:Label ID="Label1" runat="server" Text="Detalle del Productos"></asp:Label>
    </h3>
    <br />
    <table>
        <tr>
            <td colspan="2">

            </td>
        </tr>
        <tr>
            <td width="45%">
                <asp:Image ID="imgProducto" runat="server" Width="250" Height="250" />
            </td>
            <td>
                <table width="100%">
                    <tr>
                        <td align="center">
                            <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <h5><asp:Label ID="lblDescripcion" runat="server" Text="Label"></asp:Label></h5>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <h5>Precio USD $: <asp:Label ID="lblPrecio" runat="server" Text="Label" ForeColor="Green"></asp:Label></h5>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtCantidad" TextMode="Number" min="2" maxh="20" runat="server"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Button ID="btnComprar" runat="server" Text="Comprar" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
