using System.Data;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class KhachHangService
    {
        public DataTable LayDanhSach() => Db.Query("SELECT MaKH,TenKhachHang,LoaiKhach,MaSoThue,DiaChi,DienThoai,Email FROM KhachHang ORDER BY TenKhachHang");
        public void Them(string ma,string ten,string loai,string mst,string dc,string dt,string email) => Db.Execute(@"INSERT INTO KhachHang(MaKH,TenKhachHang,LoaiKhach,MaSoThue,DiaChi,DienThoai,Email) VALUES(@m,@t,@l,@mst,@dc,@dt,@e)",Db.P("@m",ma),Db.P("@t",ten),Db.P("@l",loai),Db.P("@mst",mst),Db.P("@dc",dc),Db.P("@dt",dt),Db.P("@e",email));
        public void Sua(string ma,string ten,string loai,string mst,string dc,string dt,string email) => Db.Execute(@"UPDATE KhachHang SET TenKhachHang=@t,LoaiKhach=@l,MaSoThue=@mst,DiaChi=@dc,DienThoai=@dt,Email=@e WHERE MaKH=@m",Db.P("@m",ma),Db.P("@t",ten),Db.P("@l",loai),Db.P("@mst",mst),Db.P("@dc",dc),Db.P("@dt",dt),Db.P("@e",email));
        public void Xoa(string ma) => Db.Execute("DELETE FROM KhachHang WHERE MaKH=@m",Db.P("@m",ma));
    }
}
