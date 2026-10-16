using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Services
{
    public class KhamService
    {
        // Đặt lịch hẹn khám định kỳ quý (sp_DatLichHen)
        public void DatLichHen(string maLichHen, string maHoSo, DateTime ngayHen)
        {
            using (SqlConnection cn = Db.CreateConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_DatLichHen", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaLichHen", SqlDbType.VarChar, 20).Value = maLichHen;
                cmd.Parameters.Add("@MaHoSo", SqlDbType.VarChar, 20).Value = maHoSo;
                cmd.Parameters.Add("@NgayHen", SqlDbType.DateTime2).Value = ngayHen;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Hoàn tất đợt khám (sp_HoanTatPhieu)
        public void HoanTatPhieu(string maPhieuKham, string nguoiXacNhan)
        {
            using (SqlConnection cn = Db.CreateConnection())
            using (SqlCommand cmd = new SqlCommand("dbo.sp_HoanTatPhieu", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20).Value = maPhieuKham;
                cmd.Parameters.Add("@NguoiXacNhan", SqlDbType.NVarChar, 100).Value = nguoiXacNhan;

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Lấy lịch sử khám bệnh theo Mã Hồ Sơ
        public DataTable LayLichSuKham(string maHoSo)
        {
            using (SqlConnection cn = Db.CreateConnection())
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT p.MaPhieuKham, p.NgayGioKham, b.HoTen AS BacSi, k.TenKhoa, p.TrieuChung, p.ChanDoan, p.TrangThai
                FROM PhieuKhamBenh p 
                JOIN BacSi b ON b.MaBS = p.MaBS
                JOIN KhoaDieuTri k ON k.MaKhoa = p.MaKhoa
                WHERE p.MaHoSo = @MaHoSo 
                ORDER BY p.NgayGioKham DESC", cn))
            {
                cmd.Parameters.Add("@MaHoSo", SqlDbType.VarChar, 20).Value = maHoSo;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}