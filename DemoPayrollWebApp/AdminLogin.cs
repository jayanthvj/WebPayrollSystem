using System;
using DemoPayrollWebApp;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PayrollSystem
{

    public class Admin
    {
        string sqlConnection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        //internal static string adminName, adminPassword;
        //static Admin()
        //{
        //    adminName = "JayanthAspire";
        //    adminPassword = "Jayanth@123";
        //}


        //public void AdminLogin(string userName,string password)
        //{
        //    Admin home = new Admin();


        //    if (userName.Equals(adminName) && password.Equals(adminPassword))
        //    {
        //        Console.WriteLine("You have login as Admin ");
        //        home.AdminControl();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Login failed");
        //    }
        //}
        public Boolean Login(string userName, string password)
        {
            //int sqlRows = 0;
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_logindata", sqlConnect);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@UserName", userName);
            sqlCommand.Parameters.AddWithValue("@Userpassword", password);
            //sqlCommand.Parameters.AddWithValue("@Roll", empRole);
             SqlDataReader sqlRows = sqlCommand.ExecuteReader();

            if (sqlRows.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
