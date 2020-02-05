<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeDataBase.aspx.cs" Inherits="DemoPayrollWebApp.EmployeeDataBase" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>EMPLOYEE MANAGEMENT </h1>
        <table class="auto-style1">
            <tr>
                <td>EmployeeName :</td>
                <td>
                    <asp:TextBox ID="empName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>EmployeeID</td>
                <td>
                    <asp:TextBox ID="empID" runat="server" style="height: 25px"></asp:TextBox></td>
            </tr>
             <tr>
                <td>EmployeeDesigination</td>
                <td>
                    <asp:TextBox ID="empDesigination" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>EmployeeMobileNumber</td>
                <td>
                    <asp:TextBox ID="empMobileNumber" runat="server" TextMode="Phone"></asp:TextBox></td>
            </tr>
             
              <tr>
                <td>EmployeeEmailID</td>
                <td>
                    <asp:TextBox ID="empEmail" runat="server" TextMode="Email"></asp:TextBox></td>
            </tr>
             <tr>
                <td>EmployeeDateOfBirth</td>
                <td>
                    <asp:TextBox ID="empDOB" runat="server" TextMode="Date"></asp:TextBox></td>
            </tr>
             <tr>
                <td>EmployeeSalary</td>
                <td>
                    <asp:TextBox ID="empSalary" runat="server" TextMode="Date"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Role</td>
                <td>
                    <asp:TextBox ID="empRole" runat="server" TextMode="Date"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" style="width: 60px; height: 29px;" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
