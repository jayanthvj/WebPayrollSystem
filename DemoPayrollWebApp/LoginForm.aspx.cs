using System;
using Payrole_Entity;
using Payrole_BL;
using System.Configuration;
using System.Data;

namespace DemoPayrollWebApp
{
    public partial class LoginForm : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            string User = userName.Text;
            string Password = password.Text;
            AdminEntity loginData=  new AdminEntity (User,Password);
            bool result = EmployeeBL.Login(loginData);
            if(result)
            {
                Response.Write("<script LANGUAGE='JavaScript'>alert('Login successful')</script>");
                Response.Redirect("EmployeeDataInsertion.aspx");
            }
            else
            {
                Response.Write("<script LANGUAGE='JavaScript'>alert('Login unsuccessful')</script>");
            }
        }
    }
}