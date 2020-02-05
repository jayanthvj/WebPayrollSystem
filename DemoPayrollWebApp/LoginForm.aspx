<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="DemoPayrollWebApp.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <style>
     table
     {
        text-align:center;
     }  
    </style>
    <title></title>
</head>
<body style="background-image:url(download.fifg)">
    <h1 align="center";><i> LOGIN PAGE</i></h1>
    <form id="form1" runat="server">
        <div>
            <table align="center" runat="server">
                <tr>
                    <td>UserName :
                        <asp:TextBox ID="userName" runat="server" align="right" ></asp:TextBox>
                        <asp:RegularExpressionValidator ID="regularValidateName" runat="server" ControlToValidate="userName" ErrorMessage="Enter valid name" Style="color: red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password :
                        <asp:TextBox ID="password" runat="server" TextMode="Password" > </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Login_Click" Style="width: 60px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
