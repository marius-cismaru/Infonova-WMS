<%@ Page Title="Articole" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="Infonova.ManagementWeb2.Articles" %>
<%@ MasterType VirtualPath="~/Site.Master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal runat="server" ID="literalMessage" />
    <hr />
    <h3>Adaugare articol nou</h3>
    <hr />
    <table border="1">
        <tr>
            <td>Cod:</td>
            <td><asp:TextBox runat="server" ID="textBoxCode" /></td>
        </tr>
        <tr>
            <td>Denumire completa:</td>
            <td><asp:TextBox runat="server" ID="textBoxNameFull" /></td>
        </tr>
        <tr>
            <td>Denumire furnizor:</td>
            <td><asp:TextBox runat="server" ID="textBoxNameFromSupplier" /></td>
        </tr>
        <tr>
            <td>Denumire ce va aparea pe factura:</td>
            <td><asp:TextBox runat="server" ID="textBoxNameInvoice" /></td>
        </tr>
        <tr>
            <td>E calibrat?:</td>
            <td><asp:CheckBox runat="server" ID="checkBoxIsCalibrated" /></td>
        </tr>
        <tr>
            <td>Factor unitate - greutate:</td>
            <td><asp:TextBox runat="server" ID="textBoxUnitWeightFactor" /></td>
        </tr>
        <tr>
            <td>Sub grup:</td>
            <td><asp:DropDownList runat="server" ID="dropDownListSubGroup" /></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button runat="server" ID="buttonSave" Text="Salvare" OnClick="buttonSave_Click" /></td>
        </tr>
    </table>
    <hr />
    <h3>Articole existente</h3>
    <hr />
    <asp:Literal runat="server" ID="literalTable" />
</asp:Content>
