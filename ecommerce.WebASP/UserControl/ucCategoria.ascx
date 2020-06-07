<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCategoria.ascx.cs" Inherits="ecommerce.WebASP.UserControl.ucCategoria" %>

<asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Categoria requerido" Text="*" ControlToValidate="DropDownList1" InitialValue="0" ForeColor="Red"></asp:RequiredFieldValidator>