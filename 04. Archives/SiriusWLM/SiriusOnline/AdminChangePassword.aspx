<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminChangePassword.aspx.cs" Inherits="Sirius.SiriusOnline.AdminChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <h2>Admin - Change Password</h2>
    <br /><br />
    <table border="0" cellpadding="2" cellspacing="0">
    <tr>
      <td>Old password:</td>
      <td><asp:TextBox ID="TextBoxOldPassword" runat="server" TextMode="Password"></asp:TextBox></td>
      <td>&nbsp;</td>
    </tr>
    <tr>
      <td>New password:</td> 
      <td><asp:TextBox ID="TextBoxNewPassword1" runat="server" TextMode="Password"></asp:TextBox></td>
      <td><i>(At least 6 characters)</i></td>
    </tr>
    <tr>
      <td>Retype password:</td> 
      <td><asp:TextBox ID="TextBoxNewPassword2" runat="server" TextMode="Password"></asp:TextBox></td>
    </tr>
    <tr>
      <td colspan="2"><asp:Button ID="ButtonSave" runat="server" Text="Save" onclick="ButtonSave_Click"/></td>
    </tr>
    </table>
</asp:Content>
