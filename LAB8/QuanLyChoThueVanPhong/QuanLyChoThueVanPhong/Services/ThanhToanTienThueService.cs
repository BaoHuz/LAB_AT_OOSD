using System;
using System.Data;
using QuanLyChoThueVanPhong.Data;
namespace QuanLyChoThueVanPhong.Services
{
    public class ThanhToanTienThueService
    {
        public DataTable LayHopDong() => Db.Query("SELECT MaHD,MaHD HienThi FROM HopDongThue WHERE TrangThai=N'Hiệu lực' ORDER BY MaHD");
        public DataTable LayThanhToan(string hd) => Db.Query("SELECT SoTT,KyTuThang,KyDenThang,NgayDenHan,NgayThanhToan,SoTien,TrangThai,GhiChu FROM ThanhToanTienThue WHERE MaHD=@h ORDER BY KyTuThang",Db.P("@h",hd));
        public decimal TienThueThang(string hd) { return Convert.ToDecimal(Db.Scalar("SELECT ISNULL(SUM(DonGiaThang),0) FROM ChiTietHopDong WHERE MaHD=@h AND TrangThai=N'Đang thuê'",Db.P("@h",hd))); }
        public DateTime NgayBatDau(string hd) { return Convert.ToDateTime(Db.Scalar("SELECT NgayBatDau FROM HopDongThue WHERE MaHD=@h",Db.P("@h",hd))); }
        public void ThanhToan(string soTT,string hd,int thang,DateTime ngayTT,decimal soTien,string gc)
        {
            if(thang<7) throw new Exception("Chỉ dùng chức năng này từ tháng thứ 7 trở đi.");
            DateTime denHan=NgayBatDau(hd).AddMonths(thang-1);
            Db.Execute(@"INSERT INTO ThanhToanTienThue(SoTT,MaHD,KyTuThang,KyDenThang,NgayDenHan,NgayThanhToan,SoTien,TrangThai,GhiChu) VALUES(@s,@h,@k,@k,@dh,@tt,@t,N'Đã thanh toán',@g)",Db.P("@s",soTT),Db.P("@h",hd),Db.P("@k",thang),Db.P("@dh",denHan),Db.P("@tt",ngayTT.Date),Db.P("@t",soTien),Db.P("@g",gc));
        }
    }
}
