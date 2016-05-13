<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryEditStep2.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveryEditStep2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Adaugare livrare - Pas 2 / 6 - Date comanda</h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td align="right">Tip comanda:</td> 
      <td><asp:DropDownList ID="DropDownListOrderType" runat="server" AutoPostBack="False"></asp:DropDownList></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Numar:</td> 
      <td><asp:TextBox ID="TextBoxOrderNumber" runat="server"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Data:</td> 
      <td><asp:TextBox ID="TextBoxOrderDate" runat="server"></asp:TextBox></td>
      <td><i>(Format dd.mm.yyyy)</i></td>
    </tr>
    <tr>
        <td colspan="3"><hr /></td>
    </tr>
    <tr>
      <td colspan="3">
        <asp:Button ID="ButtonCancel" runat="server" Text="Anulare" 
              onclick="ButtonCancel_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonPrevious" runat="server" Text="<< Pas precedent" 
              onclick="ButtonPrevious_Click" />
        <asp:Button ID="ButtonNext" runat="server" Text="Pas urmator >>" 
              onclick="ButtonNext_Click" />
      </td>
    </tr>
    </table>
</asp:Content>
