using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class GiaHanService
    {
        public DataTable LayHopDong() => Db.Query("SELECT MaHD,MaHD HienThi FROM HopDongThue WHERE TrangThai=N'Hiệu lực' ORDER BY MaHD");
        public DataTable LayVP(string hd) => Db.Query(@"SELECT c.MaVP,c.MaVP + N' - ' + v.TenPhong HienThi,c.NgayKetThuc FROM ChiTietHopDong c JOIN VanPhong v ON c.MaVP=v.MaVP WHERE c.MaHD=@h AND c.TrangThai=N'Đang thuê'",Db.P("@h",hd));
        public DataTable LayDanhSach() => Db.Query("SELECT MaGH,MaHD,MaVP,NgayLap,SoThangGiaHan,TuNgay,DenNgay,GhiChu FROM PhieuGiaHan ORDER BY NgayLap DESC");
        public string ThongTin(string hd,string vp)
        {
            var dt=Db.Query(@"SELECT h.SoThangThue,c.NgayKetThuc,ISNULL((SELECT SUM(SoThangGiaHan) FROM PhieuGiaHan g WHERE g.MaHD=h.MaHD AND g.MaVP=c.MaVP),0) DaGiaHan FROM HopDongThue h JOIN ChiTietHopDong c ON h.MaHD=c.MaHD WHERE h.MaHD=@h AND c.MaVP=@v",Db.P("@h",hd),Db.P("@v",vp));
            if(dt.Rows.Count==0) return ""; var r=dt.Rows[0]; int goc=Convert.ToInt32(r["SoThangThue"]),da=Convert.ToInt32(r["DaGiaHan"]); return "Thuê gốc: "+goc+" tháng | Đã gia hạn: "+da+" | Còn tối đa: "+(goc/2-da)+" tháng | Kết thúc hiện tại: "+Convert.ToDateTime(r["NgayKetThuc"]).ToString("dd/MM/yyyy");
        }
        public void GiaHan(string ma,string hd,string vp,DateTime ngay,int thang,string gc)
        {
            using(var cn=Db.OpenConnection()) using(var cmd=new SqlCommand("sp_GiaHanVanPhong",cn))
            { cmd.CommandType=CommandType.StoredProcedure; cmd.Parameters.AddWithValue("@MaGH",ma); cmd.Parameters.AddWithValue("@MaHD",hd); cmd.Parameters.AddWithValue("@MaVP",vp); cmd.Parameters.AddWithValue("@NgayLap",ngay.Date); cmd.Parameters.AddWithValue("@SoThangGiaHan",thang); cmd.Parameters.AddWithValue("@GhiChu",string.IsNullOrWhiteSpace(gc)?(object)DBNull.Value:gc); cmd.ExecuteNonQuery(); }
        }
    }
}
