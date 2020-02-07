<%@ Page Language="C#" MasterPageFile="~/MasterPayrollPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDataInsertion.aspx.cs" Inherits="DemoPayrollWebApp.EmployeeDataInsertion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h3 align="left"><i>EMPLOYEE MANAGEMENT </i></h3>
        <asp:HiddenField ID="hfEmployeedata" runat="server" />
        <table runat="server">
            <tr>
                <td>EmployeeName :</td>
                <td>
                    <asp:TextBox ID="empName" placeholder="enter the employeeName" runat="server" required=""></asp:TextBox>
                    <asp:RegularExpressionValidator ID="validateName" runat="server" ErrorMessage="enter the validate name" ControlToValidate="empName" Style="color: red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>DepartmentID</td>
                <td>
                    <asp:TextBox ID="depID" placeholder="enter the departmentID" runat="server" required=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>EmployeeDesigination</td>
                <td>
                    <asp:TextBox ID="empDesigination" placeholder="enter the desigination" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="validateDesigination" runat="server" ErrorMessage="enter the validate Desigination" ControlToValidate="empDesigination" Style="color: red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>EmployeeMobileNumber</td>
                <td>
                    <asp:TextBox ID="empMobileNumber" placeholder="enter the mobilenumber" runat="server" TextMode="Phone"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="validateMobileNumber" runat="server" ErrorMessage="enter the validate mobile number" ControlToValidate="empMobileNumber" Style="color: red" ValidationExpression="[6789]\d{9}"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>EmployeeEmailID</td>
                <td>
                    <asp:TextBox ID="empEmail" runat="server" placeholder="Enter EmailID" TextMode="Email"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="validateEmailID" runat="server" ErrorMessage="enter the validate EmailID" ControlToValidate="empEmail" Style="color: red" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>EmployeeDateOfBirth</td>
                <td>
                    <asp:TextBox ID="empDOB" runat="server" placeholder="enter DateOfBirth" TextMode="Date" required=""></asp:TextBox></td>
            </tr>
            <tr>
                <td>EmployeeSalary</td>
                <td>
                    <asp:TextBox ID="empSalary" placeholder="enter the salary" runat="server" required=""></asp:TextBox>
                </td>
            </tr>
            <%--<tr>
                    <td>Role</td>
                    <td>
                        <asp:TextBox ID="empRole" placeholder="enter the role" runat="server" required=""></asp:TextBox>
                        <asp:RegularExpressionValidator ID="validateRole" runat="server" ErrorMessage="enter the validate role" ControlToValidate="empName" Style="color: red" ValidationExpression="^[A-Za-z]+$"></asp:RegularExpressionValidator>
                    </td>
                </tr>--%>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Onclick" Style="width: 60px; height: 29px;" />
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Onclick" Style="width: 60px; height: 29px;" />
                    <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Onclick" Style="width: 60px; height: 29px;" />
                </td>
            </tr>
        </table>
        <br />
        <asp:GridView ID="GridViewEmployeeData" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="NAME" />
                <asp:BoundField DataField="Desigination" HeaderText="DESIGINATION" />
                <asp:BoundField DataField="EmployeeId" HeaderText="EMPLOYEEID" />
                <asp:BoundField DataField="departmentId" HeaderText="DEPARTMENTID" />
                <asp:BoundField DataField="EmailId" HeaderText="EMAILID" />
                <asp:BoundField DataField="DateOfBirth" HeaderText="DOB" />
                <asp:BoundField DataField="MobileNumber" HeaderText="MOBILENUMBER" />
                <asp:BoundField DataField="Salary" HeaderText="SALARY" />
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="linkview" runat="server" CommandArgument='<%# Eval("EmployeeData") %>' OnClick="link_onclick">View</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>
</asp:Content>
