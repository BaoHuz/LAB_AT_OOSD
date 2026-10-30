using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class KiemTraPhongService
    {
        public DataTable LayVP() => Db.Query("SELECT MaVP,MaVP + N' - ' + TenPhong HienThi FROM VanPhong ORDER BY MaVP");
        public DataTable LayDanhSach() => Db.Query(@"SELECT k.MaKT,k.MaVP,v.TenPhong,k.NgayKiemTra,k.TinhTrang,k.CoThayDoiKetCau,k.MucPhat,k.KienNghiSuaChua,k.NguoiKiemTra FROM KiemTraPhong k JOIN VanPhong v ON k.MaVP=v.MaVP ORDER BY k.NgayKiemTra DESC");
        public void Them(string ma,string vp,DateTime ngay,string tt,bool doi,decimal? phat,string kn,string nguoi) => Db.Execute(@"INSERT INTO KiemTraPhong(MaKT,MaVP,NgayKiemTra,TinhTrang,CoThayDoiKetCau,MucPhat,KienNghiSuaChua,NguoiKiemTra) VALUES(@m,@v,@n,@t,@d,@p,@k,@g)",Db.P("@m",ma),Db.P("@v",vp),Db.P("@n",ngay.Date),Db.P("@t",tt),Db.P("@d",doi),Db.P("@p",phat),Db.P("@k",kn),Db.P("@g",nguoi));
        public void Sua(string ma,string vp,DateTime ngay,string tt,bool doi,decimal? phat,string kn,string nguoi) => Db.Execute(@"UPDATE KiemTraPhong SET MaVP=@v,NgayKiemTra=@n,TinhTrang=@t,CoThayDoiKetCau=@d,MucPhat=@p,KienNghiSuaChua=@k,NguoiKiemTra=@g WHERE MaKT=@m",Db.P("@m",ma),Db.P("@v",vp),Db.P("@n",ngay.Date),Db.P("@t",tt),Db.P("@d",doi),Db.P("@p",phat),Db.P("@k",kn),Db.P("@g",nguoi));
        public void Xoa(string ma) => Db.Execute("DELETE FROM KiemTraPhong WHERE MaKT=@m",Db.P("@m",ma));
    }
}
