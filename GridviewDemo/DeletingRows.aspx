<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeletingRows.aspx.cs" Inherits="GridviewDemo.DeletingRows" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="scripts/jquery-1.10.2.min.js" type="text/javascript" ></script>
    <script type="text/javascript">
    function toggleSelectionUsingHeaderCheckBox(source) {
        $("#GridView1 input[name$='cbDelete']").each(function () {
            $(this).attr('checked', source.checked);
        });
    }

    function toggleSelectionOfHeaderCheckBox() {
        if ($("#GridView1 input[name$='cbDelete']").length == $("#GridView1 input[name$='cbDelete']:checked").length) {
            $("#GridView1 input[name$='cbDeleteHeader']").first().attr('checked', true);
        }
        else {
            $("#GridView1 input[name$='cbDeleteHeader']").first().attr('checked', false);
        }
    }

    $(document).ready(function () {
        $("#btnDelete").click(function () {
            var rowsSelected = $("#GridView1 input[name$='cbDelete']:checked").length;
            if (rowsSelected == 0) {
                alert('No rows selected');
                return false;
            }
            else
                return confirm(rowsSelected + ' row(s) will be deleted');
        });
    });
</script>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" 
                   />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <Columns>
                    <asp:TemplateField>
                        <HeaderTemplate>
                            <asp:CheckBox ID="cbDeleteHeader" runat="server" onclick="toggleSelectionUsingHeaderCheckBox(this);" />
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="cbDelete" runat="server" onclick="toggleSelectionOfHeaderCheckBox();"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Employee ID">
                        <ItemTemplate>
                            <asp:Label ID="lblEmployeeId" runat="server" Text='<%# Bind("EmployeeId") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="Name" HeaderText="Name" />
                    <asp:BoundField DataField="Gender" HeaderText="Gender" />
                    <asp:BoundField DataField="City" HeaderText="City" />
                </Columns>
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <asp:Label ID="lblMessage" runat="server" Font-Bold="true">
            </asp:Label>

        </div>
    </form>
</body>
</html>
