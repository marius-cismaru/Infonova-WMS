<%@ Page Title="Categorii articole" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleCategories.aspx.cs" Inherits="Infonova.ManagementWeb2.ArticleCategories" %>
<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal runat="server" ID="literalMessage" />
    <hr />
    <h3>Adaugare categorie de articole noua</h3>
    <hr />
    <table border="1">
        <tr>
            <td>Cod:</td>
            <td><asp:TextBox runat="server" ID="textBoxCode" /></td>
        </tr>
        <tr>
            <td>Denumire:</td>
            <td><asp:TextBox runat="server" ID="textBoxName" /></td>
        </tr>
        <tr>
            <td>Descriere:</td>
            <td><asp:TextBox runat="server" ID="textBoxDescription" /></td>
        </tr>
        <tr>
            <td>Grupa TVA:</td>
            <td><asp:DropDownList runat="server" ID="dropDownListVAT" /></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button runat="server" ID="buttonSave" Text="Salvare" OnClick="buttonSave_Click" /></td>
        </tr>
    </table>
    <hr />
    <h3>Categorii articole existente</h3>
    <hr />
    <asp:Literal runat="server" ID="literalTable" />
</asp:Content>
