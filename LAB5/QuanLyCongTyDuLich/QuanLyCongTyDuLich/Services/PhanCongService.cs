using System;
using System.Data;
using QuanLyCongTyDuLich.Data;

namespace QuanLyCongTyDuLich.Services
{
    public class PhanCongService
    {
        public DataTable LayHDVDangLam()
        {
            return Db.Query("SELECT MaHDV, MaHDV + ' - ' + HoTen AS HienThi FROM HuongDanVien WHERE DangLamViec = 1 ORDER BY HoTen");
        }

        public DataTable LayDoiTuong(string loai)
        {
            if (loai == QuyDinh.Le)
            {
                return Db.Query(@"SELECT c.MaChuyen AS Ma, c.MaChuyen + ' - ' + t.TenTour + ' (' + CONVERT(varchar(10), c.NgayDi, 103) + ')' AS HienThi
                                  FROM ChuyenLe c 
                                  JOIN Tour t ON c.MaTour = t.MaTour 
                                  WHERE c.TrangThai = @tt 
                                  ORDER BY c.NgayDi", Db.P("@tt", QuyDinh.MoDangKy));
            }
            return Db.Query(@"SELECT d.SoDKDoan AS Ma, d.SoDKDoan + ' - ' + k.TenCoQuanDaiDien + ' (' + t.TenTour + ')' AS HienThi
                              FROM DangKyDoan d 
                              JOIN DoanKhach k ON d.MaDoan = k.MaDoan 
                              JOIN Tour t ON d.MaTour = t.MaTour 
                              WHERE d.TrangThai = @tt 
                              ORDER BY d.NgayDi", Db.P("@tt", QuyDinh.DaDangKy));
        }

        public DataTable LayDanhSach()
        {
            return Db.Query(@"SELECT p.MaPhanCong, h.HoTen AS TenHDV, p.LoaiPhanCong,
                                     COALESCE(p.MaChuyen, p.SoDKDoan) AS DoiTuong,
                                     p.ThuLaoTour, p.NgayPhanCong
                              FROM PhanCongHDV p 
                              JOIN HuongDanVien h ON p.MaHDV = h.MaHDV 
                              ORDER BY p.NgayPhanCong DESC");
        }

        public KetQuaXuLy PhanCong(string maPC, string maHDV, string loai, string doiTuong, decimal thuLao)
        {
            if (string.IsNullOrWhiteSpace(maPC) || string.IsNullOrWhiteSpace(maHDV) || string.IsNullOrWhiteSpace(doiTuong))
                return KetQuaXuLy.Fail("Thông tin phân công chưa đầy đủ.");
            if (thuLao < 0) return KetQuaXuLy.Fail("Thù lao không được âm.");

            DateTime ngayDi, ngayVe;
            if (loai == QuyDinh.Le)
            {
                var dt = Db.Query("SELECT NgayDi, NgayVe FROM ChuyenLe WHERE MaChuyen = @m", Db.P("@m", doiTuong));
                if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy chuyến lẻ.");
                ngayDi = Convert.ToDateTime(dt.Rows[0]["NgayDi"]);
                ngayVe = Convert.ToDateTime(dt.Rows[0]["NgayVe"]);
            }
            else
            {
                var dt = Db.Query("SELECT NgayDi, NgayKetThucDuKien FROM DangKyDoan WHERE SoDKDoan = @m", Db.P("@m", doiTuong));
                if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy đăng ký đoàn.");
                ngayDi = Convert.ToDateTime(dt.Rows[0]["NgayDi"]);
                ngayVe = Convert.ToDateTime(dt.Rows[0]["NgayKetThucDuKien"]);
            }

            // Kiểm tra trùng lịch của HDV
            object trung = Db.Scalar(@"
                SELECT COUNT(*) FROM PhanCongHDV p
                LEFT JOIN ChuyenLe c ON p.MaChuyen = c.MaChuyen
                LEFT JOIN DangKyDoan d ON p.SoDKDoan = d.SoDKDoan
                WHERE p.MaHDV = @h AND (
                    (p.LoaiPhanCong = 'LE' AND c.NgayDi <= @v AND c.NgayVe >= @d) OR
                    (p.LoaiPhanCong = 'DOAN' AND d.NgayDi <= @v AND d.NgayKetThucDuKien >= @d)
                )", Db.P("@h", maHDV), Db.P("@d", ngayDi), Db.P("@v", ngayVe));

            if (Convert.ToInt32(trung) > 0)
                return KetQuaXuLy.Fail("Hướng dẫn viên đã có lịch dẫn tour khác trong khoảng thời gian từ " + ngayDi.ToString("dd/MM/yyyy") + " đến " + ngayVe.ToString("dd/MM/yyyy") + ".");

            try
            {
                if (loai == QuyDinh.Le)
                {
                    Db.Execute(@"INSERT INTO PhanCongHDV (MaPhanCong, MaHDV, LoaiPhanCong, MaChuyen, ThuLaoTour, NgayPhanCong)
                                 VALUES (@m, @h, @l, @dt, @tl, SYSDATETIME())",
                        Db.P("@m", maPC), Db.P("@h", maHDV), Db.P("@l", loai), Db.P("@dt", doiTuong), Db.P("@tl", thuLao));
                }
                else
                {
                    Db.Execute(@"INSERT INTO PhanCongHDV (MaPhanCong, MaHDV, LoaiPhanCong, SoDKDoan, ThuLaoTour, NgayPhanCong)
                                 VALUES (@m, @h, @l, @dt, @tl, SYSDATETIME())",
                        Db.P("@m", maPC), Db.P("@h", maHDV), Db.P("@l", loai), Db.P("@dt", doiTuong), Db.P("@tl", thuLao));
                }
                return KetQuaXuLy.Ok("Đã phân công hướng dẫn viên.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }
    }
}