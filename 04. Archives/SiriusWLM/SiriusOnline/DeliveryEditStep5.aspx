<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryEditStep5.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveryEditStep5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Adaugare livrare - Pas 5 / 6 - Picking pachete</h2>
    <br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td align="right">Picking / cantitati:</td> 
      <td><asp:TextBox ID="TextBoxPickingDescription" runat="server" Width="100%" 
              ReadOnly="True"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Articole:</td> 
      <td><asp:ListBox ID="ListBoxOrderProducts" runat="server"
              Width="100%" 
              onselectedindexchanged="ListBoxOrderProducts_SelectedIndexChanged" 
              AutoPostBack="True"></asp:ListBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td align="right">Total [Kg]:</td> 
      <td><asp:TextBox ID="TextBoxTotalWeight" runat="server" Width="100%" 
              ReadOnly="True"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3"><hr /></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td colspan="2">Cod - Receptie - Cantitate - Greutate neta - Greutate bruta - Loc. depozit</td>
    </tr>
    <tr>
      <td align="right">Pachete:</td> 
      <td><asp:ListBox ID="ListBoxPackagesSelected" runat="server" AutoPostBack="False" Width="100%" Height="200"></asp:ListBox></td>
      <td>
        <asp:Button ID="ButtonDelete" runat="server" Text="Stergere" 
              onclick="ButtonDelete_Click" />
      </td>
    </tr>
    <tr>
      <td align="right">Selectare pachet:</td> 
      <td><asp:DropDownList ID="DropDownListPackagesAvailable" runat="server" AutoPostBack="False" Width="100%"></asp:DropDownList></td>
      <td>
        <asp:Button ID="ButtonAdd" runat="server" Text="Adaugare" 
              onclick="ButtonAdd_Click" />
      </td>
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
