﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebservicesDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function GetStudentById() {
            var id = document.getElementById("txtStudentId").value;
            WebservicesDemo.StudentService.GetStudentByID(id, GetStudentByIdSuccessCallback, GetStudentByIdFailedCallback);

        }

        function GetStudentByIdSuccessCallback(result) {
            document.getElementById("txtName").value = result["Name"];
            document.getElementById("txtGender").value = result["Gender"];
            document.getElementById("txtTotalMarks").value = result["TotalMarks"];
        }
        
        function GetStudentByIdFailedCallback(errors) {
            alert(errors.get_message());
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/StudentService.asmx" />
            </Services>
        </asp:ScriptManager>
        <table style="font-family: Arial; border: 1px solid black">
            <tr>
                <td><b>ID</b></td>
                <td>
                    <asp:TextBox ID="txtStudentId" runat="server"></asp:TextBox>
                    <input id="Button1" type="button" value="Get Student" onclick="GetStudentById()" />
                </td>
            </tr>
            <tr>
                <td><b>Name</b></td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><b>Gender</b></td>
                <td>
                    <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td><b>Total Marks</b></td>
                <td>
                    <asp:TextBox ID="txtTotalMarks" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
           <h1>
        The time below does not change, when we click Get Student button as we are doing partial page post back and not a full page postback.
    </h1>
    <asp:Label ID="lblPageTime" runat="server"></asp:Label>
    </form>
</body>
</html>
