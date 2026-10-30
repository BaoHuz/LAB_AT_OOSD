using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class DichVuService
    {
        public DataTable LayDichVu() => Db.Query("SELECT MaDV,TenDV,DonViTinh,DonGia,DangSuDung FROM DichVu ORDER BY TenDV");
        public void ThemDV(string ma,string ten,string dvt,decimal gia,bool dung) => Db.Execute("INSERT INTO DichVu(MaDV,TenDV,DonViTinh,DonGia,DangSuDung) VALUES(@m,@t,@d,@g,@u)",Db.P("@m",ma),Db.P("@t",ten),Db.P("@d",dvt),Db.P("@g",gia),Db.P("@u",dung));
        public void SuaDV(string ma,string ten,string dvt,decimal gia,bool dung) => Db.Execute("UPDATE DichVu SET TenDV=@t,DonViTinh=@d,DonGia=@g,DangSuDung=@u WHERE MaDV=@m",Db.P("@m",ma),Db.P("@t",ten),Db.P("@d",dvt),Db.P("@g",gia),Db.P("@u",dung));
        public void XoaDV(string ma) => Db.Execute("DELETE FROM DichVu WHERE MaDV=@m",Db.P("@m",ma));
        public DataTable LayHopDong() => Db.Query("SELECT MaHD,MaHD HienThi FROM HopDongThue WHERE TrangThai=N'Hiệu lực' ORDER BY MaHD");
        public DataTable LayVP(string hd) => Db.Query(@"SELECT c.MaVP,c.MaVP + N' - ' + v.TenPhong HienThi FROM ChiTietHopDong c JOIN VanPhong v ON c.MaVP=v.MaVP WHERE c.MaHD=@h AND c.TrangThai=N'Đang thuê'",Db.P("@h",hd));
        public DataTable LayDVCombo() => Db.Query("SELECT MaDV,MaDV + N' - ' + TenDV HienThi,DonGia FROM DichVu WHERE DangSuDung=1 ORDER BY TenDV");
        public decimal LayDonGia(string ma) => Convert.ToDecimal(Db.Scalar("SELECT DonGia FROM DichVu WHERE MaDV=@m",Db.P("@m",ma)));
        public DataTable LaySuDung() => Db.Query(@"SELECT s.MaSD,s.MaHD,s.MaVP,v.TenPhong,s.MaDV,d.TenDV,s.ThangSuDung,s.SoLuong,s.DonGia,s.ThanhTien FROM SuDungDichVu s JOIN VanPhong v ON s.MaVP=v.MaVP JOIN DichVu d ON s.MaDV=d.MaDV ORDER BY s.ThangSuDung DESC,s.MaHD");
        public void GhiNhan(string maSD,string hd,string vp,string dv,DateTime thang,decimal sl,decimal gia)
        {
            var first=new DateTime(thang.Year,thang.Month,1);
            Db.Execute(@"INSERT INTO SuDungDichVu(MaSD,MaHD,MaVP,MaDV,ThangSuDung,SoLuong,DonGia) VALUES(@m,@h,@v,@d,@th,@sl,@g)",Db.P("@m",maSD),Db.P("@h",hd),Db.P("@v",vp),Db.P("@d",dv),Db.P("@th",first),Db.P("@sl",sl),Db.P("@g",gia));
        }
        public void XoaSuDung(string ma) => Db.Execute("DELETE FROM SuDungDichVu WHERE MaSD=@m",Db.P("@m",ma));
    }
}
