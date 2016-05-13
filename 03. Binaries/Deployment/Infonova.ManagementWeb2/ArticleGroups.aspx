<%@ Page Title="Grupuri articole" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticleGroups.aspx.cs" Inherits="Infonova.ManagementWeb2.ArticleGroups" %>
<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal runat="server" ID="literalMessage" />
    <hr />
    <h3>Adaugare grup de articole nou</h3>
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
            <td>Categorie:</td>
            <td><asp:DropDownList runat="server" ID="dropDownListCategory" /></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button runat="server" ID="buttonSave" Text="Salvare" OnClick="buttonSave_Click" /></td>
        </tr>
    </table>
    <hr />
    <h3>Grupuri articole existente</h3>
    <hr />
    <asp:Literal runat="server" ID="literalTable" />
</asp:Content>
