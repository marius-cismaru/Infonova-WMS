<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportStockProducts.aspx.cs" Inherits="Sirius.SiriusOnline.ReportStockProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Stock Products Report</h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td>Date:</td> 
      <td><asp:TextBox ID="TextBoxDate" runat="server"></asp:TextBox></td>
      <td><i>(Format dd.mm.yyyy)</i></td>
    </tr>
    <tr>
      <td colspan="3"><asp:Button ID="ButtonExecute" runat="server" Text="Execute" onclick="ButtonExecute_Click" /></td>
    </tr>
    </table>
    <br /><br />
    <asp:Literal ID="LiteralReport" runat="server"></asp:Literal>
</asp:Content>
