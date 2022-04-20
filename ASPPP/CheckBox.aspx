<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckBox.aspx.cs" Inherits="ASPPP.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
        <fieldset style="width:350px">
        <legend><b>Education</b></legend>
     
        <asp:CheckBox ID="CheckBox1" Checked="true" Text="Graduate" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
        <asp:CheckBox ID="CheckBox2" Text="Post Graduate" runat="server" />
        <asp:CheckBox ID="CheckBox3" Text="Doctrate" runat="server" />
         </fieldset>&nbsp;
            <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
