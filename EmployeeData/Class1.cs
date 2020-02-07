using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeData
{
    public class EmployeeData
    {
        string sqlConnection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public void AddEmployees(string Name,string Desigination,long DepartmentId,string EmailId,DateTime DateOfBirth,)
        {
           
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            sqlConnect.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_logindata", sqlConnect);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@UserName", userName);
            sqlCommand.Parameters.AddWithValue("@Userpassword", password);
            SqlDataReader sqlRows = sqlCommand.ExecuteReader();

            if (sqlRows.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

            {

            }
        }
    }
}
