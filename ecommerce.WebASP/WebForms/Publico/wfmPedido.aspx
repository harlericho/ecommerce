<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmPedido.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Publico.wfmPedido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <table>
        <tr>
            <td colspan="2" style="text-decoration: underline">Pedido</td>
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
                            <asp:LinkButton ID="lnkGuardar" runat="server" OnClick="lnkGuardar_Click">Guardar</asp:LinkButton>
                            <asp:ImageButton ID="ImbGuardar" runat="server" ImageUrl="~/Icons/pedido.png" Width="40px" Height="30px" OnClick="ImbGuardar_Click" />
                        &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lnkNuevoPedido" runat="server" CausesValidation="false" OnClick="lnkNuevoPedido_Click">Nuevo pedido</asp:LinkButton>
                            <asp:ImageButton ID="lmbNuevoPedido" runat="server" ImageUrl="~/Icons/add.png" Width="40px" Height="30px" CausesValidation="false" OnClick="lmbNuevoPedido_Click" />
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
            <td style="width: 150px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">Id
            </td>
            <td>
                <asp:Label ID="lblId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Numero pedido</td>
            <td>
                <asp:TextBox ID="txtNumeroPed" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Numero requerido" ControlToValidate="txtNumeroPed" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Fecha pedido
            </td>
            <td>
                <asp:TextBox ID="txtFechaPed" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Fecha requerido" ControlToValidate="txtFechaPed" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Identificacion cliente
            </td>
            <td>
                <asp:TextBox ID="txtIdCliente" runat="server" Visible="false"></asp:TextBox>
                <asp:TextBox ID="txtIdentificacion" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 150px">Nombres cliente
            </td>
            <td>
                <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 150px">Direccion cliente
            </td>
            <td>
                <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Direccion requerido" ControlToValidate="txtDireccion" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Telefono cliente
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 150px">SubTotal compra
            </td>
            <td>
                <asp:TextBox ID="txtSubtotal" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 150px">Total compra
            </td>
            <td>
                <asp:TextBox ID="txtTotal" runat="server"></asp:TextBox>

            </td>
        </tr>
        <tr>
            <td style="width: 150px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>

        <tr>
            <td style="width: 150px">Mensaje</td>
            <td>
                <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
        </tr>

    </table>
</asp:Content>
