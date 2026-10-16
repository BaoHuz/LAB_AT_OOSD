using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class ToaThuocService
    {
        public void LapToaThuoc(string maToa, string maPhieuKham, string maBS, string danDo, DataTable dtDongThuoc)
        {
            if (dtDongThuoc == null || dtDongThuoc.Rows.Count == 0)
                throw new ArgumentException("Toa thuốc phải có ít nhất một loại thuốc.");

            using (SqlConnection cn = Db.CreateConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_LapToaThuoc", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaToa", SqlDbType.VarChar, 20).Value = maToa;
                cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20).Value = maPhieuKham;
                cmd.Parameters.Add("@MaBS", SqlDbType.VarChar, 20).Value = maBS;
                cmd.Parameters.Add("@DanDo", SqlDbType.NVarChar, 1000).Value = (object)danDo ?? DBNull.Value;

               
                SqlParameter paramDong = cmd.Parameters.Add("@Dong", SqlDbType.Structured);
                paramDong.TypeName = "dbo.DongToaThuoc";
                paramDong.Value = dtDongThuoc;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}