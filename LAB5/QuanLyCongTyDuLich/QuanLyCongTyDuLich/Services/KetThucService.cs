using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyCongTyDuLich.Data;

namespace QuanLyCongTyDuLich.Services
{
    public class KetThucService
    {
        public DataTable DoanCanThanhToan()
        {
            return Db.Query(@"SELECT d.SoDKDoan, k.TenCoQuanDaiDien, t.TenTour, d.NgayDi, d.NgayKetThucDuKien,
                                     d.TongTienDuKien, d.TienCoc,
                                     ISNULL(SUM(p.SoTien), 0) AS DaThanhToanThem,
                                     (d.TongTienDuKien - d.TienCoc - ISNULL(SUM(p.SoTien), 0)) AS ConLai,
                                     d.TrangThai
                              FROM DangKyDoan d
                              JOIN DoanKhach k ON d.MaDoan = k.MaDoan
                              JOIN Tour t ON d.MaTour = t.MaTour
                              LEFT JOIN PhieuThanhToanDoan p ON d.SoDKDoan = p.SoDKDoan
                              WHERE d.TrangThai = @tt OR d.TrangThai = @ht
                              GROUP BY d.SoDKDoan, k.TenCoQuanDaiDien, t.TenTour, d.NgayDi, d.NgayKetThucDuKien, d.TongTienDuKien, d.TienCoc, d.TrangThai
                              ORDER BY d.NgayDi DESC",
                              Db.P("@tt", QuyDinh.DaDangKy), Db.P("@ht", QuyDinh.HoanTatThanhToan));
        }

        public KetQuaXuLy ThanhToanDoan(string soTT, string soDK, DateTime ngayTT, decimal soTien, string ghiChu)
        {
            if (string.IsNullOrWhiteSpace(soTT) || string.IsNullOrWhiteSpace(soDK) || soTien <= 0)
                return KetQuaXuLy.Fail("Thông tin thanh toán không hợp lệ.");

            var dt = Db.Query(@"SELECT d.TongTienDuKien, d.TienCoc, ISNULL(SUM(p.SoTien), 0) AS DaTT
                                FROM DangKyDoan d 
                                LEFT JOIN PhieuThanhToanDoan p ON d.SoDKDoan = p.SoDKDoan 
                                WHERE d.SoDKDoan = @s 
                                GROUP BY d.TongTienDuKien, d.TienCoc", Db.P("@s", soDK));

            if (dt.Rows.Count == 0) return KetQuaXuLy.Fail("Không tìm thấy phiếu đăng ký đoàn.");

            decimal tong = Convert.ToDecimal(dt.Rows[0]["TongTienDuKien"]);
            decimal coc = Convert.ToDecimal(dt.Rows[0]["TienCoc"]);
            decimal daTT = Convert.ToDecimal(dt.Rows[0]["DaTT"]);
            decimal conLai = tong - coc - daTT;

            if (soTien > conLai)
                return KetQuaXuLy.Fail("Số tiền thanh toán (" + soTien.ToString("N0") + " đ) vượt quá số tiền còn lại (" + conLai.ToString("N0") + " đ).");

            using (var cn = Db.OpenConnection())
            using (var tr = cn.BeginTransaction())
            {
                try
                {
                    Exec(cn, tr, @"INSERT INTO PhieuThanhToanDoan (SoPhieuTT, SoDKDoan, NgayThanhToan, SoTien, GhiChu)
                                   VALUES (@sp, @s, @n, @t, @g)",
                        Db.P("@sp", soTT), Db.P("@s", soDK), Db.P("@n", ngayTT.Date), Db.P("@t", soTien), Db.P("@g", ghiChu));

                    if (soTien == conLai)
                    {
                        Exec(cn, tr, "UPDATE DangKyDoan SET TrangThai = @tt WHERE SoDKDoan = @s",
                            Db.P("@tt", QuyDinh.HoanTatThanhToan), Db.P("@s", soDK));
                    }

                    tr.Commit();
                    return KetQuaXuLy.Ok("Đã ghi nhận thanh toán. Còn lại: " + (conLai - soTien).ToString("N0") + " đ.");
                }
                catch (Exception ex)
                {
                    try { tr.Rollback(); } catch { }
                    return KetQuaXuLy.Fail(ex.Message);
                }
            }
        }

        public DataTable LayDangKyChoKhaoSat(string loaiKhach)
        {
            if (loaiKhach == QuyDinh.Le)
            {
                return Db.Query(@"SELECT d.SoDKLe AS Ma, d.SoDKLe + ' - ' + d.TenNguoiDangKy + ' (' + t.TenTour + ')' AS HienThi
                                  FROM DangKyLe d 
                                  JOIN ChuyenLe c ON d.MaChuyen = c.MaChuyen 
                                  JOIN Tour t ON c.MaTour = t.MaTour 
                                  WHERE c.NgayVe <= SYSDATETIME() 
                                  ORDER BY d.NgayDangKy DESC");
            }
            return Db.Query(@"SELECT d.SoDKDoan AS Ma, d.SoDKDoan + ' - ' + k.TenCoQuanDaiDien + ' (' + t.TenTour + ')' AS HienThi
                              FROM DangKyDoan d 
                              JOIN DoanKhach k ON d.MaDoan = k.MaDoan 
                              JOIN Tour t ON d.MaTour = t.MaTour 
                              WHERE d.NgayKetThucDuKien <= SYSDATETIME() 
                              ORDER BY d.NgayDangKy DESC");
        }

        public DataTable LayKhaoSat()
        {
            return Db.Query(@"SELECT MaKhaoSat, LoaiKhach, SoDKLe, SoDKDoan, NgayGui, NgayPhanHoi, DiemDanhGia, YKienGopY, TrangThai
                              FROM KhaoSatYKien ORDER BY NgayGui DESC");
        }

        public KetQuaXuLy GuiKhaoSat(string maKS, string loaiKhach, string soDK, DateTime ngayGui)
        {
            if (string.IsNullOrWhiteSpace(maKS) || string.IsNullOrWhiteSpace(soDK))
                return KetQuaXuLy.Fail("Thông tin phiếu khảo sát chưa đầy đủ.");

            string sql = loaiKhach == QuyDinh.Le
                ? "INSERT INTO KhaoSatYKien (MaKhaoSat, LoaiKhach, SoDKLe, NgayGui, TrangThai) VALUES (@m, @l, @s, @n, N'Đã gửi')"
                : "INSERT INTO KhaoSatYKien (MaKhaoSat, LoaiKhach, SoDKDoan, NgayGui, TrangThai) VALUES (@m, @l, @s, @n, N'Đã gửi')";

            try
            {
                Db.Execute(sql, Db.P("@m", maKS), Db.P("@l", loaiKhach), Db.P("@s", soDK), Db.P("@n", ngayGui.Date));
                return KetQuaXuLy.Ok("Đã gửi phiếu khảo sát.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        public KetQuaXuLy GhiPhanHoi(string maKS, DateTime ngayPH, int diem, string yKien)
        {
            if (string.IsNullOrWhiteSpace(maKS)) return KetQuaXuLy.Fail("Chưa chọn phiếu khảo sát.");
            if (diem < 1 || diem > 5) return KetQuaXuLy.Fail("Điểm đánh giá phải từ 1 đến 5.");

            try
            {
                int n = Db.Execute(@"UPDATE KhaoSatYKien 
                                     SET NgayPhanHoi = @n, DiemDanhGia = @d, YKienGopY = @y, TrangThai = N'Đã phản hồi' 
                                     WHERE MaKhaoSat = @m",
                                     Db.P("@n", ngayPH.Date), Db.P("@d", diem), Db.P("@y", yKien), Db.P("@m", maKS));
                return n > 0 ? KetQuaXuLy.Ok("Đã lưu ý kiến phản hồi.") : KetQuaXuLy.Fail("Không tìm thấy phiếu khảo sát.");
            }
            catch (Exception ex) { return KetQuaXuLy.Fail(ex.Message); }
        }

        private static void Exec(SqlConnection cn, SqlTransaction tr, string sql, params SqlParameter[] ps)
        {
            using (var cmd = new SqlCommand(sql, cn, tr))
            {
                cmd.Parameters.AddRange(ps);
                cmd.ExecuteNonQuery();
            }
        }
    }
}