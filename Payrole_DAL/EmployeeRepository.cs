using System;
using System.Data.SqlClient;
using Payrole_Entity;
using System.Threading.Tasks;
using System.Data;

namespace Payrole_DAL
{
    public class EmployeeRepository
    {
       
        public  static bool AddandupdateEmployee(EmployeeEntity emp,string EmployeeData)
        {
            SqlConnection sqlconnect = SqlConnectivity.EstablishConnection();
            SqlCommand sqlCommand = new SqlCommand("Insert_Update_employee", sqlconnect);
            sqlconnect.Open();
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@EmployeeData", EmployeeData);
            sqlCommand.Parameters.AddWithValue("@Name", emp.Name);
            sqlCommand.Parameters.AddWithValue("@Desigination", emp.Designation);
            sqlCommand.Parameters.AddWithValue("@DepartmentId", emp.departmentId);
            sqlCommand.Parameters.AddWithValue("@Email", emp.EmailID);
            sqlCommand.Parameters.AddWithValue("@DOB", emp.DateOfBirth);
            sqlCommand.Parameters.AddWithValue("@MobileNumber", emp.Mobilenumber);
            sqlCommand.Parameters.AddWithValue("@Salary", emp.Salary);
            sqlCommand.ExecuteNonQuery();
            string value = EmployeeData;
            if (value == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public static void Clear(EmployeeEntity clear)
        {
             clear.Name = clear.Designation = clear.departmentId = clear.Mobilenumber = clear.EmailID = clear.Salary = "";
        }
        public static DataTable EmployeeGridView()
        {
            SqlConnection sqlconnect = SqlConnectivity.EstablishConnection();
            SqlDataAdapter sqlCommand = new SqlDataAdapter("ViewEmployeeData", sqlconnect);
            sqlconnect.Open();
            sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dtbl = new DataTable();
            sqlCommand.Fill(dtbl);
            return dtbl;
        }
        public static DataTable view(int EmployeeData)
        {
            SqlConnection sqlconnect = SqlConnectivity.EstablishConnection();
            SqlDataAdapter sqlCommand = new SqlDataAdapter("ViewEmployeeeById", sqlconnect);
            sqlCommand.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.SelectCommand.Parameters.AddWithValue("@EmployeeData", EmployeeData);
            DataTable dtbl = new  DataTable();
            sqlCommand.Fill(dtbl);
            return dtbl;
        }
        public static void DeleteEmployee(int empId)
        {
            
            SqlConnection sqlConnect =SqlConnectivity.EstablishConnection();
            sqlConnect.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_deleteEmployee", sqlConnect);
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@EmployeeData",empId);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }

    }
}
