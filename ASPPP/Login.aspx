<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPPP.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 195px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
  <div style="font-family:Arial">
<table style="border: 1px solid black">
    <tr>
        <td colspan="2">
            <b>Login</b>
        </td>
    </tr>
    <tr>
        <td>
            User Name
        </td>    
        <td class="auto-style1">
            :<asp:TextBox ID="txtUserName" runat="server">
            </asp:TextBox>
        </td>    
    </tr>
    <tr>
        <td>
            Password
        </td>    
        <td class="auto-style1">
            :<asp:TextBox ID="txtPassword" TextMode="Password" runat="server">
            </asp:TextBox>
        </td>    
    </tr>
    <tr>
        <td>
                    
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Remember Me" />
                    
        </td>    
        <td class="auto-style1">
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </td>    
    </tr>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</table>
<br />
<a href="Registration/Register.aspx">Click here to register</a> 
if you do not have a user name and password.
</div>
    </form>
</body>
</html>
