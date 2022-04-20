<%@ Page Language="C#" Trace="true" AutoEventWireup="true" CodeBehind="Tracing.aspx.cs" Inherits="ASPPP.Tracing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
  <div style="font-family: Arial">
    <b>All employees</b>
    <asp:GridView ID="gvAllEmployees" runat="server">
    </asp:GridView>
    <br /><br />
    <b>Total Employees by Department</b>
    <asp:GridView ID="gvEmployeesByDepartment" runat="server">
    </asp:GridView>
    <br /><br />
    <b>Total Employees by Gender</b>
    <asp:GridView ID="gvEmployeesByGender" runat="server">
    </asp:GridView>
</div>
    </form>
</body>
</html>
