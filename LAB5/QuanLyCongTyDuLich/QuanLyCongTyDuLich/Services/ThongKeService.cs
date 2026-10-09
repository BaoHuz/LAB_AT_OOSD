using System;
using System.Data;
using QuanLyCongTyDuLich.Data;

namespace QuanLyCongTyDuLich.Services
{
    public class ThongKeService
    {
        public DataTable LuongHDV(int thang, int nam)
        {
            return Db.Query(@"
                SELECT h.MaHDV, h.HoTen, h.LuongCoBan,
                       ISNULL(SUM(p.ThuLaoTour), 0) AS TongThuLaoTour,
                       (h.LuongCoBan + ISNULL(SUM(p.ThuLaoTour), 0)) AS TongThucLinh
                FROM HuongDanVien h
                LEFT JOIN PhanCongHDV p ON h.MaHDV = p.MaHDV 
                     AND MONTH(p.NgayPhanCong) = @m AND YEAR(p.NgayPhanCong) = @y
                WHERE h.DangLamViec = 1
                GROUP BY h.MaHDV, h.HoTen, h.LuongCoBan
                ORDER BY h.HoTen",
                Db.P("@m", thang), Db.P("@y", nam));
        }

        public DataTable TongHop(DateTime tuNgay, DateTime denNgay)
        {
            return Db.Query(@"
                SELECT N'Doanh thu khách lẻ' AS ChiTieu, ISNULL(SUM(ThanhTien), 0) AS GiaTri
                FROM DangKyLe WHERE NgayDangKy >= @from AND NgayDangKy <= @to
                UNION ALL
                SELECT N'Tiền cọc đoàn thu được' AS ChiTieu, ISNULL(SUM(TienCoc), 0) AS GiaTri
                FROM DangKyDoan WHERE NgayDangKy >= @from AND NgayDangKy <= @to
                UNION ALL
                SELECT N'Thanh toán đoàn bổ sung' AS ChiTieu, ISNULL(SUM(SoTien), 0) AS GiaTri
                FROM PhieuThanhToanDoan WHERE NgayThanhToan >= @from AND NgayThanhToan <= @to
                UNION ALL
                SELECT N'Tổng thù lao HDV đã phân công' AS ChiTieu, ISNULL(SUM(ThuLaoTour), 0) AS GiaTri
                FROM PhanCongHDV WHERE NgayPhanCong >= @from AND NgayPhanCong <= @to",
                Db.P("@from", tuNgay.Date), Db.P("@to", denNgay.Date));
        }
    }
}