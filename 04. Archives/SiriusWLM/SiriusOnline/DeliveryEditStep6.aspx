<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryEditStep6.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveryEditStep6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Adaugare livrare - Pas 6 / 6 - Detalii transport</h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td align="right">Nume sofer:</td> 
      <td><asp:TextBox ID="TextBoxRepresentativeName" runat="server"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">ID sofer:</td> 
      <td><asp:TextBox ID="TextBoxRepresentativeID" runat="server"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Transport:</td> 
      <td><asp:TextBox ID="TextBoxConveyance" runat="server"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Sigiliu:</td> 
      <td><asp:TextBox ID="TextBoxSeal" runat="server"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Comentariu:</td> 
      <td><asp:TextBox ID="TextBoxComment" runat="server"></asp:TextBox></td>
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
        <asp:Button ID="ButtonNext" runat="server" Text="Salvare" 
              onclick="ButtonNext_Click" />
      </td>
    </tr>
    </table>
</asp:Content>
