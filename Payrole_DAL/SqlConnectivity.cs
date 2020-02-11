using System.Configuration;
using System.Data.SqlClient;


namespace Payrole_DAL
{
   public class SqlConnectivity
    {
        public static SqlConnection EstablishConnection()
        {
            string sqlConnection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            SqlConnection sqlConnect = new SqlConnection(sqlConnection);
            return sqlConnect;
        }
    }
}
