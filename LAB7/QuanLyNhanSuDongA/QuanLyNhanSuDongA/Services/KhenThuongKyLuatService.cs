using System;
using System.Data.SqlClient;
using QuanLyNhanSuDongA.Data;

namespace QuanLyNhanSuDongA.Services
{
    public class KhenThuongKyLuatService
    {
        private bool MotDoiTuong(string maNV, string maPB) => !string.IsNullOrWhiteSpace(maNV) ^ !string.IsNullOrWhiteSpace(maPB);

        public KetQuaXuLy LapQuyetDinhKhenThuong(string soQD, DateTime ngay, string maNV, string maPB, string loai, decimal soTien, string noiDung, string nguoiKy)
        {
            if (!MotDoiTuong(maNV, maPB))
                return KetQuaXuLy.Fail("Phải chọn đúng một đối tượng: cá nhân hoặc phòng ban.");
            if (soTien <= 0)
                return KetQuaXuLy.Fail("Số tiền khen thưởng phải > 0.");

            Db.Execute(@"INSERT QuyetDinhKhenThuong(SoQDKT,NgayQD,MaNV,MaPB,LoaiKhenThuong,SoTien,NoiDung,NguoiKy)
                VALUES(@s,@d,@n,@p,@l,@t,@c,@k)",
                new SqlParameter("@s", soQD),
                new SqlParameter("@d", ngay.Date),
                new SqlParameter("@n", (object)maNV ?? DBNull.Value),
                new SqlParameter("@p", (object)maPB ?? DBNull.Value),
                new SqlParameter("@l", loai),
                new SqlParameter("@t", soTien),
                new SqlParameter("@c", noiDung),
                new SqlParameter("@k", nguoiKy));

            return KetQuaXuLy.Ok("Đã lập quyết định khen thưởng.");
        }

        public KetQuaXuLy LapQuyetDinhKyLuat(string soQD, DateTime ngay, string maNV, string maPB, string hinhThuc, decimal soTien, string cachThu, string noiDung, string nguoiKy)
        {
            if (!MotDoiTuong(maNV, maPB))
                return KetQuaXuLy.Fail("Phải chọn đúng một đối tượng.");
            if (cachThu != "PHIEU_THU" && cachThu != "TRU_LUONG")
                return KetQuaXuLy.Fail("Cách thu phạt không hợp lệ.");

            Db.Execute(@"INSERT QuyetDinhKyLuat(SoQDKL,NgayQD,MaNV,MaPB,HinhThucXuLy,SoTienPhat,CachThu,NoiDung,NguoiKy)
                VALUES(@s,@d,@n,@p,@h,@t,@c,@i,@k)",
                new SqlParameter("@s", soQD),
                new SqlParameter("@d", ngay.Date),
                new SqlParameter("@n", (object)maNV ?? DBNull.Value),
                new SqlParameter("@p", (object)maPB ?? DBNull.Value),
                new SqlParameter("@h", hinhThuc),
                new SqlParameter("@t", soTien),
                new SqlParameter("@c", cachThu),
                new SqlParameter("@i", noiDung),
                new SqlParameter("@k", nguoiKy));

            return KetQuaXuLy.Ok("Đã lập quyết định kỷ luật.");
        }
    }
}