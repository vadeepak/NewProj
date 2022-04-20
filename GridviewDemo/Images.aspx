<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Images.aspx.cs" Inherits="GridviewDemo.Images" %>

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
                <asp:BoundField DataField="EmployeeId" HeaderText="EmployeeId" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Gender" HeaderText="Gender" />
                <asp:BoundField DataField="City" HeaderText="City" />

  <%--              <asp:TemplateField HeaderText="Photo">
                    <ItemTemplate>
                        <asp:Image ID="Image1" runat="server" Height="100px" Width="100px" ImageUrl='<%# Bind("Photo") %>' />
                    </ItemTemplate>
                </asp:TemplateField>--%>
                <asp:ImageField DataImageUrlField="Photo" HeaderText="Photo">
                    <ControlStyle Height="100px" Width="100px" />
                </asp:ImageField>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
