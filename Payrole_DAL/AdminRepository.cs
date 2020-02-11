using System;
using Payrole_Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrole_DAL
{
   public class AdminRepository
    {
        public static Boolean Login(AdminEntity login)
        {

            SqlConnection sqlconnect = SqlConnectivity.EstablishConnection();
            sqlconnect.Open();
            SqlCommand sqlCommand = new SqlCommand("sp_logindata", sqlconnect);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@UserName", login.Username);
            sqlCommand.Parameters.AddWithValue("@Userpassword",login.password);
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
