using System.Data;
using QuanLyChoThueVanPhong.Data;

namespace QuanLyChoThueVanPhong.Services
{
    public class TangVanPhongService
    {
        public DataTable LayTang() => Db.Query("SELECT MaTang,TenTang,SoThuTu,GhiChu FROM Tang ORDER BY SoThuTu");
        public DataTable LayVanPhong() => Db.Query(@"SELECT v.MaVP,v.MaTang,t.TenTang,v.TenPhong,v.DienTichSuDung,v.Huong,v.DonGiaThang,v.TrangThai FROM VanPhong v JOIN Tang t ON v.MaTang=t.MaTang ORDER BY t.SoThuTu,v.TenPhong");
        public void ThemTang(string ma,string ten,int stt,string gc) => Db.Execute("INSERT INTO Tang(MaTang,TenTang,SoThuTu,GhiChu) VALUES(@m,@t,@s,@g)",Db.P("@m",ma),Db.P("@t",ten),Db.P("@s",stt),Db.P("@g",gc));
        public void SuaTang(string ma,string ten,int stt,string gc) => Db.Execute("UPDATE Tang SET TenTang=@t,SoThuTu=@s,GhiChu=@g WHERE MaTang=@m",Db.P("@m",ma),Db.P("@t",ten),Db.P("@s",stt),Db.P("@g",gc));
        public void XoaTang(string ma) => Db.Execute("DELETE FROM Tang WHERE MaTang=@m",Db.P("@m",ma));
        public void ThemVP(string ma,string tang,string ten,decimal dt,string huong,decimal gia,string tt) => Db.Execute(@"INSERT INTO VanPhong(MaVP,MaTang,TenPhong,DienTichSuDung,Huong,DonGiaThang,TrangThai) VALUES(@m,@t,@n,@d,@h,@g,@tt)",Db.P("@m",ma),Db.P("@t",tang),Db.P("@n",ten),Db.P("@d",dt),Db.P("@h",huong),Db.P("@g",gia),Db.P("@tt",tt));
        public void SuaVP(string ma,string tang,string ten,decimal dt,string huong,decimal gia,string tt) => Db.Execute(@"UPDATE VanPhong SET MaTang=@t,TenPhong=@n,DienTichSuDung=@d,Huong=@h,DonGiaThang=@g,TrangThai=@tt WHERE MaVP=@m",Db.P("@m",ma),Db.P("@t",tang),Db.P("@n",ten),Db.P("@d",dt),Db.P("@h",huong),Db.P("@g",gia),Db.P("@tt",tt));
        public void XoaVP(string ma) => Db.Execute("DELETE FROM VanPhong WHERE MaVP=@m",Db.P("@m",ma));
    }
}
