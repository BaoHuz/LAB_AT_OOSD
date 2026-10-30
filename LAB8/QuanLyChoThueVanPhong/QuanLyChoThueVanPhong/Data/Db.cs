using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyChoThueVanPhong.Data
{
    public static class Db
    {
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager
                    .ConnectionStrings["QLVanPhongDB"]
                    .ConnectionString;
            }
        }

        public static SqlConnection OpenConnection()
        {
            SqlConnection cn =
                new SqlConnection(ConnectionString);

            cn.Open();

            return cn;
        }

        public static DataTable Query(
            string sql,
            params SqlParameter[] parameters)
        {
            using (SqlConnection cn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
        }

        public static int Execute(
            string sql,
            params SqlParameter[] parameters)
        {
            using (SqlConnection cn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        public static object Scalar(
            string sql,
            params SqlParameter[] parameters)
        {
            using (SqlConnection cn = OpenConnection())
            using (SqlCommand cmd = new SqlCommand(sql, cn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteScalar();
            }
        }

        public static SqlParameter P(
            string name,
            object value)
        {
            if (value == null)
                value = System.DBNull.Value;

            return new SqlParameter(name, value);
        }
    }
}