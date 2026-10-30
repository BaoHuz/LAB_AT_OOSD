using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class HopDongService
    {
        public DataTable LayKhachHang() => Db.Query("SELECT MaKH,MaKH + N' - ' + TenKhachHang HienThi FROM KhachHang ORDER BY TenKhachHang");
        public DataTable LayVanPhongTrong() => Db.Query(@"SELECT v.MaVP,v.TenPhong,t.TenTang,v.DienTichSuDung,v.Huong,v.DonGiaThang FROM VanPhong v JOIN Tang t ON v.MaTang=t.MaTang WHERE v.TrangThai=N'Trống' ORDER BY t.SoThuTu,v.TenPhong");
        public DataTable LayHopDong() => Db.Query(@"SELECT h.MaHD,k.TenKhachHang,h.NgayKy,h.NgayBatDau,h.SoThangThue,h.NgayKetThuc,h.TrangThai,h.GhiChu FROM HopDongThue h JOIN KhachHang k ON h.MaKH=k.MaKH ORDER BY h.NgayKy DESC");
        public DataTable LayChiTiet(string maHD) => Db.Query(@"SELECT c.MaVP,v.TenPhong,c.DonGiaThang,c.NgayBatDau,c.NgayKetThuc,c.TrangThai FROM ChiTietHopDong c JOIN VanPhong v ON c.MaVP=v.MaVP WHERE c.MaHD=@h",Db.P("@h",maHD));
        public void LapHopDong(string maHD,string maKH,DateTime ngayKy,DateTime ngayBD,int soThang,string ghiChu,DataTable dsVP)
        {
            using(var cn=Db.OpenConnection()) using(var cmd=new SqlCommand("sp_LapHopDongVaThu6Thang",cn))
            {
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD",maHD); cmd.Parameters.AddWithValue("@MaKH",maKH); cmd.Parameters.AddWithValue("@NgayKy",ngayKy.Date); cmd.Parameters.AddWithValue("@NgayBatDau",ngayBD.Date); cmd.Parameters.AddWithValue("@SoThangThue",soThang); cmd.Parameters.AddWithValue("@GhiChu",string.IsNullOrWhiteSpace(ghiChu)?(object)DBNull.Value:ghiChu);
                var p=cmd.Parameters.AddWithValue("@DanhSachVP",dsVP); p.SqlDbType=SqlDbType.Structured; p.TypeName="dbo.VanPhongThueType";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
