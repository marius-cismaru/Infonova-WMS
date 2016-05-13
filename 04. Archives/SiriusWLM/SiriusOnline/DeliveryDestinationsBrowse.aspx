<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeliveryDestinationsBrowse.aspx.cs" Inherits="Sirius.SiriusOnline.DeliveryDestinationsBrowse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Destinatii livrari</h2>
    <br />
    <asp:Button ID="ButtonAddNew" runat="server" Text="Adaugare noua" PostBackUrl="~/DeliveryDestinationEdit.aspx?id=0" />
    <br /><br /><br />
    <asp:Table ID="TableDestinations" runat="server" BorderColor="#333333" 
        BorderStyle="Solid" BorderWidth="1px" CellPadding="4" CellSpacing="0" 
        GridLines="Both">
        <asp:TableRow runat="server">
            <asp:TableCell runat="server" Font-Bold="True">Denumire</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True">Tara</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True">Firma</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True">Adresa</asp:TableCell>
            <asp:TableCell runat="server" Font-Bold="True">Nr. livrari</asp:TableCell>
            <asp:TableCell runat="server">&nbsp;</asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</asp:Content>
