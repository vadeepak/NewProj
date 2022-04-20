<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RdaioButt.aspx.cs" Inherits="ASPPP.RdaioButt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton ID="RadioButton1" GroupName="Gender" Checked="true" Text="Male" runat="server" />
        <asp:RadioButton ID="RadioButton2"  GroupName="Gender" Text="Female" runat="server" />

    </div>
    </form>
</body>
</html>
