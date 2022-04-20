<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="GridviewDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ProdcutId" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True">
            <Columns>
                <asp:BoundField DataField="ProdcutId" HeaderText="ProdcutId" InsertVisible="False" ReadOnly="True" SortExpression="ProdcutId" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
                <asp:BoundField DataField="QuantitySold" HeaderText="QuantitySold" SortExpression="QuantitySold" />
            </Columns>
        </asp:GridView>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:aspppConnectionString %>" SelectCommand="SELECT * FROM [tblProduct]"></asp:SqlDataSource>

    </div>
    </form>
</body>
</html>
