   <%@ Page Language="C#" MasterPageFile="~/MasterPayrollPage.Master" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="DemoPayrollWebApp.LoginForm" %>

<asp:Content ID="contentHead" runat="server" ContentPlaceHolderID="head">
</asp:Content>
<asp:Content ID="contentPlaceHolderLogin" runtat="server" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <div>
            <table runat="server">
                <tr>
                    <td>UserName :</td>
                    <td>
                        <asp:TextBox ID="userName" runat="server" align="left" required=""></asp:TextBox>
                        <asp:RegularExpressionValidator ID="regularValidateName" runat="server" ControlToValidate="userName" ErrorMessage="Enter valid name" Style="color: red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td>
                        <asp:TextBox ID="password" runat="server" TextMode="Password" align="left"> </asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Login_Click" Style="width: 60px" />
                    </td>
                </tr>
            </table>
        </div>
    </asp:content>
   
