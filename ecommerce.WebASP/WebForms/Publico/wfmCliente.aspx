<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmCliente.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Publico.wfmCliente1" %>
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
                            <asp:LinkButton ID="lnkNuevo" runat="server" CausesValidation="false"> Nuevo</asp:LinkButton>
                            <asp:ImageButton ID="ImbNuevo" runat="server" ImageUrl="~/Icons/add.png" Width="30px" Height="30px" CausesValidation="false" />
                        &nbsp;
                        </td>
                        <td>
                            <asp:LinkButton ID="lnkGuardar" runat="server" OnClick="lnkGuardar_Click">Guardar</asp:LinkButton>
                            <asp:ImageButton ID="ImbGuardar" runat="server" ImageUrl="~/Icons/save.png" Width="30px" Height="30px" OnClick="ImbGuardar_Click" />
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
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 150px">Id
            </td>
            <td>
                <asp:Label ID="lblId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Identificacion</td>
            <td>
                <asp:TextBox ID="txtIdentificacion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Dni requerido" ControlToValidate="txtIdentificacion" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Apellidos
            </td>
            <td>
                <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Apellido requerido" ControlToValidate="txtApellidos" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Nombres
            </td>
            <td>
                <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Nombres requerido" ControlToValidate="txtNombres" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Fecha Nacimiento
            </td>
            <td>
                <asp:TextBox ID="txtFechNac" runat="server" TextMode="Date"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Fecha Nacimiento requerido" ControlToValidate="txtFechNac" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Telefono
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Telefono requerido" ControlToValidate="txtTelefono" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Email
            </td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Email requerido" ControlToValidate="txtEmail" ForeColor="Red">*</asp:RequiredFieldValidator>
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
