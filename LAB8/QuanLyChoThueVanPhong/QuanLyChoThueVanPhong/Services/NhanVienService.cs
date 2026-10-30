using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class NhanVienService
    {
        public DataTable LayKH() => Db.Query("SELECT MaKH,MaKH + N' - ' + TenKhachHang HienThi FROM KhachHang ORDER BY TenKhachHang");
        public DataTable LayVP() => Db.Query("SELECT MaVP,MaVP + N' - ' + TenPhong HienThi FROM VanPhong ORDER BY MaVP");
        public DataTable LayDanhSach() => Db.Query(@"SELECT n.MaNV,n.MaKH,k.TenKhachHang,n.MaVP,v.TenPhong,n.HoTen,n.ChucVu,n.NgayBatDau,n.DangLamViec,n.HinhAnh FROM NhanVienVanPhong n JOIN KhachHang k ON n.MaKH=k.MaKH JOIN VanPhong v ON n.MaVP=v.MaVP ORDER BY n.HoTen");
        public void Them(string ma,string kh,string vp,string ten,string cv,byte[] anh,DateTime? ngay,bool dang) => Db.Execute(@"INSERT INTO NhanVienVanPhong(MaNV,MaKH,MaVP,HoTen,ChucVu,HinhAnh,NgayBatDau,DangLamViec) VALUES(@m,@k,@v,@t,@c,@a,@n,@d)",Db.P("@m",ma),Db.P("@k",kh),Db.P("@v",vp),Db.P("@t",ten),Db.P("@c",cv),Db.P("@a",anh),Db.P("@n",ngay),Db.P("@d",dang));
        public void Sua(string ma,string kh,string vp,string ten,string cv,byte[] anh,DateTime? ngay,bool dang) => Db.Execute(@"UPDATE NhanVienVanPhong SET MaKH=@k,MaVP=@v,HoTen=@t,ChucVu=@c,HinhAnh=@a,NgayBatDau=@n,DangLamViec=@d WHERE MaNV=@m",Db.P("@m",ma),Db.P("@k",kh),Db.P("@v",vp),Db.P("@t",ten),Db.P("@c",cv),Db.P("@a",anh),Db.P("@n",ngay),Db.P("@d",dang));
        public void Nghi(string ma) => Db.Execute("UPDATE NhanVienVanPhong SET DangLamViec=0 WHERE MaNV=@m",Db.P("@m",ma));
    }
}
