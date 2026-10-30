using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class HoaDonDichVuService
    {
        public DataTable LayHopDong() => Db.Query("SELECT MaHD,MaHD HienThi FROM HopDongThue WHERE TrangThai=N'Hiệu lực' ORDER BY MaHD");
        public DataTable LayHoaDon() => Db.Query("SELECT MaHDDV,MaHD,ThangSuDung,NgayLap,TongTien,TrangThai FROM HoaDonDichVu ORDER BY ThangSuDung DESC,MaHD");
        public DataTable LayChiTiet(string ma) => Db.Query(@"SELECT c.MaSD,d.TenDV,s.MaVP,s.SoLuong,s.DonGia,c.ThanhTien FROM ChiTietHoaDonDichVu c JOIN SuDungDichVu s ON c.MaSD=s.MaSD JOIN DichVu d ON s.MaDV=d.MaDV WHERE c.MaHDDV=@m",Db.P("@m",ma));
        public void LapHoaDon(string ma,string hd,DateTime thang,DateTime ngayLap)
        {
            using(var cn=Db.OpenConnection()) using(var cmd=new SqlCommand("sp_LapHoaDonDichVuThang",cn))
            { cmd.CommandType=CommandType.StoredProcedure; cmd.Parameters.AddWithValue("@MaHDDV",ma); cmd.Parameters.AddWithValue("@MaHD",hd); cmd.Parameters.AddWithValue("@ThangSuDung",thang.Date); cmd.Parameters.AddWithValue("@NgayLap",ngayLap.Date); cmd.ExecuteNonQuery(); }
        }
        public void ThanhToan(string soTTDV,string maHDDV,DateTime ngay,string gc)
        {
            using(var cn=Db.OpenConnection()) using(var tr=cn.BeginTransaction())
            {
                try
                {
                    decimal tong;
                    using(var cmd=new SqlCommand("SELECT TongTien FROM HoaDonDichVu WHERE MaHDDV=@m AND TrangThai=N'Chưa thanh toán'",cn,tr))
                    { cmd.Parameters.Add(Db.P("@m",maHDDV)); var o=cmd.ExecuteScalar(); if(o==null) throw new Exception("Hóa đơn không tồn tại hoặc đã thanh toán."); tong=Convert.ToDecimal(o); }
                    using(var cmd=new SqlCommand("INSERT INTO ThanhToanDichVu(SoTTDV,MaHDDV,NgayThanhToan,SoTien,GhiChu) VALUES(@s,@m,@n,@t,@g)",cn,tr))
                    { cmd.Parameters.AddRange(new[]{Db.P("@s",soTTDV),Db.P("@m",maHDDV),Db.P("@n",ngay.Date),Db.P("@t",tong),Db.P("@g",gc)}); cmd.ExecuteNonQuery(); }
                    using(var cmd=new SqlCommand("UPDATE HoaDonDichVu SET TrangThai=N'Đã thanh toán' WHERE MaHDDV=@m",cn,tr))
                    { cmd.Parameters.Add(Db.P("@m",maHDDV)); cmd.ExecuteNonQuery(); }
                    tr.Commit();
                }
                catch { tr.Rollback(); throw; }
            }
        }
    }
}
