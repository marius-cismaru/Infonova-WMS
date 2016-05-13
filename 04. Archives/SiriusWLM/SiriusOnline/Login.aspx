<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="Sirius.SiriusOnline.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <asp:Literal ID="LiteralMessage" runat="server"></asp:Literal>
    <table>
       <tr>
          <td>Username:</td>
          <td><asp:TextBox ID="textBoxUserName" runat="server"></asp:TextBox></td>
          <td><asp:RequiredFieldValidator ControlToValidate="textBoxUserName"
               Display="Static" ErrorMessage="*" runat="server" 
               ID="vUserName"></asp:RequiredFieldValidator>
          </td>
       </tr>
       <tr>
          <td>Password:</td>
          <td><asp:TextBox ID="textBoxPassword" TextMode="Password" runat="server"></asp:TextBox></td>
          <td><asp:RequiredFieldValidator ControlToValidate="textBoxPassword"
              Display="Static" ErrorMessage="*" runat="server" 
              ID="vUserPass"></asp:RequiredFieldValidator>
          </td>
       </tr>
       <tr>
          <td>Remember me:</td>
          <td><asp:CheckBox ID="checkBoxPersistent" runat="server" AutoPostBack="false" /></td>
          <td>&nbsp;</td>
       </tr>
       <tr>
         <td colspan="3"><asp:Button Text="Login" runat="server" ID="buttonLogin" onclick="buttonLogin_Click" /></td>
       </tr>
    </table>
</asp:Content>
