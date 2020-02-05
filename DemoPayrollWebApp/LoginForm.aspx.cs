using System;
using PayrollSystem;
using System.Data.SqlClient;
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
            Admin data = new Admin();
            //string username = userName.Text;
            //string emppassword = password.Text;
            //string role = empRole.Text;
            bool result= data.Login(userName.Text, password.Text);
            if(result)
            {
                Response.Write("successful");
                //Response.Redirect("EmployeeDataBase.aspx");
            }
            else
            {
                Response.Write("unsuccessful");
            }
        }
    }
}