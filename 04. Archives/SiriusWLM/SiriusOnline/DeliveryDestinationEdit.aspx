<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryDestinationEdit.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveryDestinationEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2><asp:Literal ID="LiteralTitle" runat="server"></asp:Literal></h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td>Denumire:</td> 
      <td><asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
      <td>Tara:</td> 
      <td><asp:DropDownList ID="DropDownListCountry" runat="server" AutoPostBack="False"></asp:DropDownList></td>
    </tr>
    <tr>
      <td>Firma:</td> 
      <td><asp:TextBox ID="TextBoxCompany" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
      <td>Adresa:</td> 
      <td><asp:TextBox ID="TextBoxAddress" runat="server"></asp:TextBox></td>
    </tr>
    <tr>
      <td colspan="3"><asp:Button ID="ButtonSave" runat="server" Text="Save" onclick="ButtonSave_Click" /></td>
    </tr>
    </table>
</asp:Content>
