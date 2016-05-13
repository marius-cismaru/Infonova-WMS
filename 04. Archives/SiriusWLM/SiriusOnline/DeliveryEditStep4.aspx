<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryEditStep4.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveryEditStep4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Adaugare livrare - Pas 4 / 6 - Metode piking si politici cantitati</h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td align="right">Metoda picking:</td> 
      <td><asp:DropDownList ID="DropDownListPickingMethod" runat="server" AutoPostBack="False"></asp:DropDownList></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Politica cantitati:</td> 
      <td><asp:DropDownList ID="DropDownListQuantityPolicy" runat="server" AutoPostBack="False"></asp:DropDownList></td>
      <td>&nbsp;</td>
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
