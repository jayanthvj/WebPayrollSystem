﻿using System;
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
       
        public Boolean Login(string userName, string password)
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
        }
    }
}
