<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmBuscarCliente.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Publico.wfmCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <table>
        <tr>
            <td colspan="2" style="text-decoration: underline">Cliente</td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <table>
                    <tr>
                        <td>
                            <asp:LinkButton ID="lnkGuardar" runat="server" CausesValidation="false" OnClick="lnkGuardar_Click">Añadir</asp:LinkButton>
                            <asp:ImageButton ID="ImbGuardar" runat="server" ImageUrl="~/Icons/addClientes.png" Width="40px" Height="30px" CausesValidation="false" OnClick="ImbGuardar_Click" />
                            &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lnkPedido" runat="server" CausesValidation="false" OnClick="lnkPedido_Click">Pedido</asp:LinkButton>
                            <asp:ImageButton ID="ImagePedido" runat="server" ImageUrl="~/Icons/pedido.png" Width="40px" Height="30px" CausesValidation="false" OnClick="ImagePedido_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Buscar DNI cliente
            </td>
            <td>
                <asp:TextBox ID="txtBuscar" runat="server" TextMode="Number"></asp:TextBox>
                <asp:Button ID="btnFiltro" runat="server" Text="Buscar" CausesValidation="false" OnClick="btnFiltro_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 150px">DNI
            </td>

            <td>
                <asp:Label ID="lblID" runat="server" Text="" Visible="false"></asp:Label>
                <asp:Label ID="lblDni" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Apellidos
            </td>
            <td>
                <asp:Label ID="lblApellidos" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Nombres:
            </td>
            <td>
                <asp:Label ID="lblNombres" runat="server" Text=""></asp:Label>
                <asp:Label ID="lblTelefono" runat="server" Text="" Visible="false"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">Mensaje</td>
            <td>
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
