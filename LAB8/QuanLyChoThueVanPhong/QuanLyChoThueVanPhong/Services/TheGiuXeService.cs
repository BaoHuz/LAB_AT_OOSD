using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class TheGiuXeService
    {
        public DataTable LayNV() => Db.Query("SELECT MaNV,MaNV + N' - ' + HoTen HienThi FROM NhanVienVanPhong WHERE DangLamViec=1 ORDER BY HoTen");
        public DataTable LayDanhSach() => Db.Query(@"SELECT t.MaThe,t.MaNV,n.HoTen,t.BienSoXe,t.LoaiXe,t.MauXe,t.NgayCap,t.TrangThai FROM TheGiuXe t JOIN NhanVienVanPhong n ON t.MaNV=n.MaNV ORDER BY t.MaThe");
        public void Them(string ma,string nv,string bien,string loai,string mau,DateTime ngay,string tt) => Db.Execute("INSERT INTO TheGiuXe(MaThe,MaNV,BienSoXe,LoaiXe,MauXe,NgayCap,TrangThai) VALUES(@m,@n,@b,@l,@ma,@ng,@t)",Db.P("@m",ma),Db.P("@n",nv),Db.P("@b",bien),Db.P("@l",loai),Db.P("@ma",mau),Db.P("@ng",ngay.Date),Db.P("@t",tt));
        public void Sua(string ma,string nv,string bien,string loai,string mau,DateTime ngay,string tt) => Db.Execute("UPDATE TheGiuXe SET MaNV=@n,BienSoXe=@b,LoaiXe=@l,MauXe=@ma,NgayCap=@ng,TrangThai=@t WHERE MaThe=@m",Db.P("@m",ma),Db.P("@n",nv),Db.P("@b",bien),Db.P("@l",loai),Db.P("@ma",mau),Db.P("@ng",ngay.Date),Db.P("@t",tt));
        public void Xoa(string ma) => Db.Execute("DELETE FROM TheGiuXe WHERE MaThe=@m",Db.P("@m",ma));
    }
}
