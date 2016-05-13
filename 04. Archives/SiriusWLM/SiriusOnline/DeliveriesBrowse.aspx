<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveriesBrowse.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveriesBrowse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Livrari</h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td>Date from:</td> 
      <td><asp:TextBox ID="TextBoxDateFrom" runat="server"></asp:TextBox></td>
      <td><i>(Format dd.mm.yyyy)</i></td>
    </tr>
    <tr>
      <td>Date to:</td> 
      <td><asp:TextBox ID="TextBoxDateTo" runat="server"></asp:TextBox></td>
      <td><i>(Format dd.mm.yyyy)</i></td>
    </tr>
    <tr>
      <td colspan="3"><asp:Button ID="ButtonShow" runat="server" Text="Show" onclick="ButtonShow_Click" /></td>
    </tr>
    </table>
    <br /><br />
    <asp:Literal ID="LiteralReport" runat="server"></asp:Literal>
</asp:Content>
