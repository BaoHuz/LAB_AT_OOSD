using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyNhanSuDongA.Data
{
    public static class Db
    {
        public static SqlConnection Open()
        {
            var cn = new SqlConnection(ConfigurationManager.ConnectionStrings["QuanLyNhanSuDongADB"].ConnectionString);
            cn.Open();
            return cn;
        }

        public static DataTable Query(string sql, params SqlParameter[] p)
        {
            using (var cn = Open())
            using (var cmd = new SqlCommand(sql, cn))
            using (var da = new SqlDataAdapter(cmd))
            {
                if (p != null) cmd.Parameters.AddRange(p);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static int Execute(string sql, params SqlParameter[] p)
        {
            using (var cn = Open())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (p != null) cmd.Parameters.AddRange(p);
                return cmd.ExecuteNonQuery();
            }
        }

        public static T Scalar<T>(string sql, params SqlParameter[] p)
        {
            using (var cn = Open())
            using (var cmd = new SqlCommand(sql, cn))
            {
                if (p != null) cmd.Parameters.AddRange(p);
                object v = cmd.ExecuteScalar();
                return v == null || v == DBNull.Value ? default(T) : (T)Convert.ChangeType(v, typeof(T));
            }
        }
    }
}