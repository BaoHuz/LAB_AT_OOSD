using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSuDongA.Data;

namespace QuanLyNhanSuDongA.Services
{
    public class LuongService
    {
        public KetQuaXuLy TinhLuongThang(int thang, int nam, string nguoiLap)
        {
            DateTime dau = new DateTime(nam, thang, 1), cuoi = dau.AddMonths(1).AddDays(-1);
            DataTable cfg = Db.Query("SELECT NgayCongChuan,GioCongChuanNgay FROM CauHinhTinhLuong WHERE Thang=@t AND Nam=@n",
                new SqlParameter("@t", thang), new SqlParameter("@n", nam));
            if (cfg.Rows.Count == 0)
                return KetQuaXuLy.Fail("Chưa có cấu hình kỳ lương.");

            decimal ngayChuan = (decimal)cfg.Rows[0][0], gioChuan = (decimal)cfg.Rows[0][1];
            string maBL = "BL" + nam.ToString() + thang.ToString("00");

            using (var cn = Db.Open())
            using (var tx = cn.BeginTransaction())
                try
                {
                    var ins = new SqlCommand("INSERT BangLuong(MaBangLuong,Thang,Nam,NguoiLap) VALUES(@m,@t,@n,@u)", cn, tx);
                    ins.Parameters.AddWithValue("@m", maBL);
                    ins.Parameters.AddWithValue("@t", thang);
                    ins.Parameters.AddWithValue("@n", nam);
                    ins.Parameters.AddWithValue("@u", nguoiLap);
                    ins.ExecuteNonQuery();

                    var nv = new SqlCommand("SELECT MaNV FROM NhanVien WHERE TrangThai=N'Chính thức'", cn, tx);
                    using (var rd = nv.ExecuteReader())
                    {
                        var ds = new System.Collections.Generic.List<string>();
                        while (rd.Read()) ds.Add(rd.GetString(0));
                        rd.Close();

                        foreach (string ma in ds)
                        {
                            decimal luong = ScalarD(cn, tx, @"SELECT TOP 1 LuongCoBan FROM QuyetDinhLuong WHERE MaNV=@m AND NgayHieuLuc<=@c ORDER BY NgayHieuLuc DESC", ma, cuoi);
                            decimal pcLuong = ScalarD(cn, tx, @"SELECT TOP 1 PhuCapLuong FROM QuyetDinhLuong WHERE MaNV=@m AND NgayHieuLuc<=@c ORDER BY NgayHieuLuc DESC", ma, cuoi);
                            decimal pcDocHai = ScalarD(cn, tx, @"SELECT TOP 1 PhuCapDocHai FROM QuyetDinhLuong WHERE MaNV=@m AND NgayHieuLuc<=@c ORDER BY NgayHieuLuc DESC", ma, cuoi);
                            decimal pcCV = ScalarD(cn, tx, @"SELECT TOP 1 PhuCapChucVu FROM QuyetDinhChucVu WHERE MaNV=@m AND NgayHieuLuc<=@c ORDER BY NgayHieuLuc DESC", ma, cuoi);

                            decimal ngayCong = ScalarD(cn, tx, @"SELECT COUNT(*) FROM PhieuChamCong WHERE MaNV=@m AND NgayCham BETWEEN @d AND @c AND TrangThai=N'Đi làm'", ma, cuoi, dau);
                            decimal tienCong = ngayChuan == 0 ? 0 : luong * ngayCong / ngayChuan;

                            decimal gioPT = ScalarD(cn, tx, @"SELECT ISNULL(SUM(p.SoGioPhuTroi*p.HeSo),0) FROM PhieuPhuTroi p JOIN ChiTietPhuTroi c ON p.SoPhieu=c.SoPhieu WHERE c.MaNV=@m AND p.NgayPhuTroi BETWEEN @d AND @c", ma, cuoi, dau);
                            decimal donGiaGio = (ngayChuan == 0 || gioChuan == 0) ? 0 : luong / ngayChuan / gioChuan;
                            decimal tienPT = gioPT * donGiaGio;

                            decimal tyLeBH = ScalarD(cn, tx, @"SELECT ISNULL(SUM(TyLeNguoiLD),0) FROM HoSoBaoHiem WHERE MaNV=@m AND TuNgay<=@c AND (DenNgay IS NULL OR DenNgay>=@d)", ma, cuoi, dau);
                            decimal truBH = luong * tyLeBH;

                            decimal truKL = ScalarD(cn, tx, @"SELECT ISNULL(SUM(SoTienPhat),0) FROM QuyetDinhKyLuat WHERE MaNV=@m AND CachThu='TRU_LUONG' AND DaXuLy=0 AND NgayQD<=@c", ma, cuoi);
                            decimal thuc = tienCong + pcLuong + pcDocHai + pcCV + tienPT - truBH - truKL;

                            var d = new SqlCommand(@"INSERT ChiTietBangLuong VALUES(@b,@m,@l,@pl,@pd,@pc,@nc,@tc,@pt,@bh,@kl,@tl)", cn, tx);
                            d.Parameters.AddWithValue("@b", maBL);
                            d.Parameters.AddWithValue("@m", ma);
                            d.Parameters.AddWithValue("@l", luong);
                            d.Parameters.AddWithValue("@pl", pcLuong);
                            d.Parameters.AddWithValue("@pd", pcDocHai);
                            d.Parameters.AddWithValue("@pc", pcCV);
                            d.Parameters.AddWithValue("@nc", ngayCong);
                            d.Parameters.AddWithValue("@tc", tienCong);
                            d.Parameters.AddWithValue("@pt", tienPT);
                            d.Parameters.AddWithValue("@bh", truBH);
                            d.Parameters.AddWithValue("@kl", truKL);
                            d.Parameters.AddWithValue("@tl", thuc);
                            d.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã tính bảng lương " + thang + "/" + nam + ".");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Fail(ex.Message);
                }
        }

        private decimal ScalarD(SqlConnection cn, SqlTransaction tx, string sql, string ma, DateTime cuoi, DateTime? dau = null)
        {
            using (var c = new SqlCommand(sql, cn, tx))
            {
                c.Parameters.AddWithValue("@m", ma);
                c.Parameters.AddWithValue("@c", cuoi);
                if (dau.HasValue) c.Parameters.AddWithValue("@d", dau.Value);
                object v = c.ExecuteScalar();
                return v == null || v == DBNull.Value ? 0 : Convert.ToDecimal(v);
            }
        }
    }
}