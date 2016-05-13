<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryEditStep1.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveryEditStep1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Adaugare livrare - Pas 1 / 6 - Selectare sursa si destinatie</h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td align="right">Depozit:</td> 
      <td><asp:DropDownList ID="DropDownListWarehouse" runat="server" AutoPostBack="False"></asp:DropDownList></td>
    </tr>
    <tr>
      <td align="right">Destinatie client:</td> 
      <td><asp:DropDownList ID="DropDownListClientDestination" runat="server" AutoPostBack="False"></asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2"><hr /></td>
    </tr>
    <tr>
      <td colspan="2">
        <asp:Button ID="ButtonCancel" runat="server" Text="Anulare" 
              onclick="ButtonCancel_Click" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonNext" runat="server" Text="Pas urmator >>" 
              onclick="ButtonNext_Click" />
      </td>
    </tr>
    </table>
</asp:Content>
