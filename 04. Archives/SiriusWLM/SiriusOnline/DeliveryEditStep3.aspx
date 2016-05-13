<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryEditStep3.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveryEditStep3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Adaugare livrare - Pas 3 / 6 - Cantitati articole</h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td align="right">Articole:</td> 
      <td><asp:ListBox ID="ListBoxOrderProducts" runat="server" AutoPostBack="False" 
              Width="100%"></asp:ListBox></td>
      <td>
        <asp:Button ID="ButtonDelete" runat="server" Text="Stergere" 
              onclick="ButtonDelete_Click" />
      </td>
    </tr>
    <tr>
      <td align="right">Total greutate [Kg]:</td> 
      <td><asp:TextBox ID="TextBoxTotalWeightNet" runat="server" Width="100%" 
              ReadOnly="True"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Selectare articol:</td> 
      <td><asp:DropDownList ID="DropDownListProduct" runat="server" AutoPostBack="False" Width="100%"></asp:DropDownList></td>
      <td>
        <asp:Button ID="ButtonAdd" runat="server" Text="Adaugare" 
              onclick="ButtonAdd_Click" />
      </td>
    </tr>
    <tr>
      <td align="right">Cantitate:</td> 
      <td><asp:TextBox ID="TextBoxQuantity" runat="server" Width="100%"></asp:TextBox></td>
      <td><i><asp:Literal ID="LiteralProductMU" runat="server">&nbsp;Punct (.) pentru zecimale</asp:Literal></i></td>
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
