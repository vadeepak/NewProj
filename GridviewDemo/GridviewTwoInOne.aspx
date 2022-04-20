<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridviewTwoInOne.aspx.cs" Inherits="GridviewDemo.GridviewTwoInOne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="DepartmentId" HeaderText="Department Id" />
                <asp:BoundField DataField="DepartmentName" HeaderText="Department Name" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:GridView ID="GridView2" runat="server" DataSource='<%# Bind("Employees") %>'>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
