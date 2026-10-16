using System.Configuration;
using System.Data.SqlClient;

namespace QuanLyHoSoBenhAn.Data
{
    public static class Db
    {
        public static SqlConnection CreateConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}