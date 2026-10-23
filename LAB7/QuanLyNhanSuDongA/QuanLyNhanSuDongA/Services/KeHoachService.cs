using System;
using System.Data.SqlClient;
using QuanLyNhanSuDongA.Data;

namespace QuanLyNhanSuDongA.Services
{
    public class KeHoachService
    {
        public KetQuaXuLy TaoKeHoach(string maKH, string maPB, DateTime tu, DateTime den, string nguoiLap)
        {
            if ((den.Date - tu.Date).TotalDays != 6)
                return KetQuaXuLy.Fail("Kế hoạch tuần phải đủ 7 ngày liên tiếp.");

            Db.Execute("INSERT KeHoachTuan(MaKH,MaPB,TuanTuNgay,TuanDenNgay,NgayLap,NguoiLap) VALUES(@m,@p,@t,@d,CAST(GETDATE() AS date),@n)",
                new SqlParameter("@m", maKH),
                new SqlParameter("@p", maPB),
                new SqlParameter("@t", tu.Date),
                new SqlParameter("@d", den.Date),
                new SqlParameter("@n", nguoiLap));

            return KetQuaXuLy.Ok("Đã tạo kế hoạch tuần.");
        }

        public KetQuaXuLy ThemChiTiet(string maKH, int stt, string maNV, DateTime ngay, string maCa, bool phuTroi, decimal? gio, string hinhThuc)
        {
            var dt = Db.Query("SELECT TuanTuNgay,TuanDenNgay FROM KeHoachTuan WHERE MaKH=@m", new SqlParameter("@m", maKH));
            if (dt.Rows.Count == 0)
                return KetQuaXuLy.Fail("Không tìm thấy kế hoạch.");

            DateTime tu = (DateTime)dt.Rows[0][0], den = (DateTime)dt.Rows[0][1];
            if (ngay.Date < tu.Date || ngay.Date > den.Date)
                return KetQuaXuLy.Fail("Ngày làm phải nằm trong tuần kế hoạch.");

            Db.Execute(@"INSERT ChiTietKeHoachTuan(MaKH,STT,MaNV,NgayLam,MaCa,KeHoachPhuTroi,SoGioPhuTroiDuKien,HinhThucPhuTroi)
                VALUES(@k,@s,@n,@d,@c,@p,@g,@h)",
                new SqlParameter("@k", maKH),
                new SqlParameter("@s", stt),
                new SqlParameter("@n", maNV),
                new SqlParameter("@d", ngay.Date),
                new SqlParameter("@c", maCa),
                new SqlParameter("@p", phuTroi),
                new SqlParameter("@g", (object)gio ?? DBNull.Value),
                new SqlParameter("@h", (object)hinhThuc ?? DBNull.Value));

            return KetQuaXuLy.Ok("Đã thêm phân công tuần.");
        }
    }
}