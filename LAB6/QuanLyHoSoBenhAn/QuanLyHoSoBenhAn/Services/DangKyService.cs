using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class DangKyService
    {
        public void DangKyBenhNhanMoi(string maBN, string maHoSo, string soPhieuThu,
            string hoTen, DateTime ngaySinh, string diaChi, string dienThoai, string anh, decimal soTien)
        {
            using (SqlConnection cn = Db.CreateConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_DangKyMoi", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@MaBN", SqlDbType.VarChar, 20).Value = maBN;
                cmd.Parameters.Add("@MaHoSo", SqlDbType.VarChar, 20).Value = maHoSo;
                cmd.Parameters.Add("@SoPhieuThu", SqlDbType.VarChar, 20).Value = soPhieuThu;
                cmd.Parameters.Add("@HoTen", SqlDbType.NVarChar, 120).Value = hoTen;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 250).Value = diaChi;
                cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 20).Value = dienThoai;
                cmd.Parameters.Add("@Anh", SqlDbType.NVarChar, 500).Value = anh;
                cmd.Parameters.Add("@SoTien", SqlDbType.Decimal).Value = soTien;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}