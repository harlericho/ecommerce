﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="wfmProductoNuevo.aspx.cs" Inherits="ecommerce.WebASP.WebForms.Administracion.Producto.wfmProductoNuevo" %>

<%@ Register Src="~/UserControl/ucCategoria.ascx" TagName="UC_Categoria" TagPrefix="Uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <table>
        <tr>
            <td colspan="2" style="text-decoration: underline">Producto
            </td>
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
                            <asp:LinkButton ID="lnkNuevo" runat="server" CausesValidation="false" OnClick="lnkNuevo_Click">Nuevo</asp:LinkButton>
                            <asp:ImageButton ID="ImbNuevo" runat="server" ImageUrl="~/Icons/add.png" Width="30px" Height="30px" OnClick="ImbNuevo_Click" CausesValidation="false" />
                        &nbsp;</td>
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
            <td style="width: 150px">Id
            </td>
            <td>
                <asp:Label ID="lblId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Categoria
            </td>
            <td>
                <%--<asp:DropDownList ID="ddlCategoria" runat="server"></asp:DropDownList>--%>
                <Uc1:UC_Categoria ID="UC_Categoria1" runat="server"></Uc1:UC_Categoria>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Codigo
            </td>
            <td>
                <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Codigo requerido" ControlToValidate="txtCodigo" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Nombre
            </td>
            <td>
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Nombre requerido" ControlToValidate="txtNombre" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Precio de compra
            </td>
            <td>
                <asp:TextBox ID="txtPrc" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Precio compra requerido" ControlToValidate="txtPrc" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Precio de venta
            </td>
            <td>
                <asp:TextBox ID="txtPrv" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Precio venta requerido" ControlToValidate="txtPrv" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Imagen
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" onchange="showimagepreview(this)"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"  ErrorMessage="Imagen requerida" ControlToValidate="FileUpload1" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">
                <img id="img" alt="" style="width:101px" src="../../../Images/preview-icon.png" />
                <%--<asp:Image ID="Avatar" runat="server" Height="94px" ImageUrl="~/Images/preview-icon.png" Width="101px" />--%>
            </td>
<%--            <td>
                <asp:Button ID="btnMostrar" runat="server" Text="Mostrar" OnClick="btnMostrar_Click" />
            </td>--%>
        </tr>
        <tr>
            <td style="width: 150px">Descripcion
            </td>
            <td>
                <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Stock minino
            </td>
            <td>
                <asp:TextBox ID="txtStockMin" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Stock minimo requerido" ControlToValidate="txtStockMin" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="width: 150px">Stock maximo
            </td>
            <td>
                <asp:TextBox ID="txtStockMax" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Stock maximo requerido" ControlToValidate="txtStockMax" ForeColor="Red">*</asp:RequiredFieldValidator>
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
    <script type="text/javascript">

        function showimagepreview(input) {

            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {

                    document.getElementsByTagName("img")[0].setAttribute("src", e.target.result);
                }
                reader.readAsDataURL(input.files[0]);
            }
        }

    </script>

</asp:Content>

