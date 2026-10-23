using System;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhanSuDongA.Data;

namespace QuanLyNhanSuDongA.Services
{
    public class NhanSuService
    {
        public KetQuaXuLy LapQuyetDinhTuyenDung(string soQD, string maNV, string hoTen, string maPB,
            DateTime tuNgay, DateTime denNgay, decimal luongThuViec, string noiDung, string nguoiKy)
        {
            if (string.IsNullOrWhiteSpace(soQD) || string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(hoTen))
                return KetQuaXuLy.Fail("Số quyết định, mã và họ tên nhân viên không được để trống.");
            if (denNgay.Date < tuNgay.Date)
                return KetQuaXuLy.Fail("Đến ngày thử việc không được trước từ ngày.");
            if (luongThuViec < 0)
                return KetQuaXuLy.Fail("Lương thử việc không hợp lệ.");

            using (var cn = Db.Open())
            using (var tx = cn.BeginTransaction())
                try
                {
                    var up = new SqlCommand(@"IF EXISTS(SELECT 1 FROM NhanVien WHERE MaNV=@m)
                    UPDATE NhanVien SET HoTen=@h,MaPB=@pb,TrangThai=N'Đang thử việc' WHERE MaNV=@m
                    ELSE INSERT NhanVien(MaNV,HoTen,MaPB,TrangThai) VALUES(@m,@h,@pb,N'Đang thử việc')", cn, tx);
                    up.Parameters.AddWithValue("@m", maNV);
                    up.Parameters.AddWithValue("@h", hoTen);
                    up.Parameters.AddWithValue("@pb", maPB);
                    up.ExecuteNonQuery();

                    var q = new SqlCommand(@"INSERT QuyetDinhTuyenDung(SoQDTD,MaNV,MaPBThuViec,NgayQD,TuNgay,DenNgay,LuongThuViec,NoiDung,NguoiKy)
                    VALUES(@s,@m,@pb,CAST(GETDATE() AS date),@t,@d,@l,@n,@k)", cn, tx);
                    q.Parameters.AddWithValue("@s", soQD);
                    q.Parameters.AddWithValue("@m", maNV);
                    q.Parameters.AddWithValue("@pb", maPB);
                    q.Parameters.AddWithValue("@t", tuNgay.Date);
                    q.Parameters.AddWithValue("@d", denNgay.Date);
                    q.Parameters.AddWithValue("@l", luongThuViec);
                    q.Parameters.AddWithValue("@n", noiDung);
                    q.Parameters.AddWithValue("@k", nguoiKy);
                    q.ExecuteNonQuery();

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập quyết định tuyển dụng.");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Fail(ex.Message);
                }
        }

        public KetQuaXuLy KyHopDong(string soHD, string maNV, string loaiHD, DateTime ngayKy, DateTime tuNgay, DateTime? denNgay)
        {
            DateTime hetTV = Db.Scalar<DateTime>("SELECT ISNULL(MAX(DenNgay),'19000101') FROM QuyetDinhTuyenDung WHERE MaNV=@m", new SqlParameter("@m", maNV));
            if (tuNgay.Date <= hetTV.Date)
                return KetQuaXuLy.Fail("Chỉ ký hợp đồng sau khi hết thời gian thử việc.");
            if (loaiHD != "Dài hạn" && loaiHD != "Ngắn hạn")
                return KetQuaXuLy.Fail("Loại hợp đồng không hợp lệ.");

            Db.Execute(@"INSERT HopDongLaoDong(SoHD,MaNV,LoaiHD,NgayKy,TuNgay,DenNgay,TrangThai) VALUES(@s,@m,@l,@k,@t,@d,N'Đang hiệu lực')",
                new SqlParameter("@s", soHD),
                new SqlParameter("@m", maNV),
                new SqlParameter("@l", loaiHD),
                new SqlParameter("@k", ngayKy.Date),
                new SqlParameter("@t", tuNgay.Date),
                new SqlParameter("@d", (object)denNgay?.Date ?? DBNull.Value));

            Db.Execute("UPDATE NhanVien SET TrangThai=N'Chính thức' WHERE MaNV=@m", new SqlParameter("@m", maNV));
            return KetQuaXuLy.Ok("Đã ký hợp đồng lao động.");
        }

        public KetQuaXuLy LuuBaoHiem(string maHS, string maNV, string soHD, string loaiBH, string soSoThe,
            decimal tyLeNV, decimal tyLeCongTy, DateTime tuNgay)
        {
            if (loaiBH != "BHYT" && loaiBH != "BHXH")
                return KetQuaXuLy.Fail("Loại bảo hiểm không hợp lệ.");

            string loaiHD = Db.Scalar<string>("SELECT LoaiHD FROM HopDongLaoDong WHERE SoHD=@s AND MaNV=@m",
                new SqlParameter("@s", soHD), new SqlParameter("@m", maNV));
            if (loaiHD != "Dài hạn")
                return KetQuaXuLy.Fail("Hồ sơ BHYT/BHXH trong bài lab áp dụng cho hợp đồng dài hạn.");

            Db.Execute(@"INSERT HoSoBaoHiem(MaHSBH,MaNV,SoHD,LoaiBH,SoSoThe,TyLeNguoiLD,TyLeCongTy,TuNgay) VALUES(@a,@m,@h,@l,@s,@n,@c,@t)",
                new SqlParameter("@a", maHS),
                new SqlParameter("@m", maNV),
                new SqlParameter("@h", soHD),
                new SqlParameter("@l", loaiBH),
                new SqlParameter("@s", soSoThe),
                new SqlParameter("@n", tyLeNV),
                new SqlParameter("@c", tyLeCongTy),
                new SqlParameter("@t", tuNgay.Date));

            return KetQuaXuLy.Ok("Đã lưu hồ sơ bảo hiểm.");
        }
    }
}