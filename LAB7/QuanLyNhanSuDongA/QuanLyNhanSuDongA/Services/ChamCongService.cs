using System;
using System.Data.SqlClient;
using QuanLyNhanSuDongA.Data;

namespace QuanLyNhanSuDongA.Services
{
    public class ChamCongService
    {
        public KetQuaXuLy ChamCong(string maCC, string maNV, DateTime ngay, string maCa, decimal soGio, string trangThai, string nguoiCham)
        {
            if (soGio < 0)
                return KetQuaXuLy.Fail("Số giờ làm không hợp lệ.");

            Db.Execute(@"INSERT PhieuChamCong(MaCC,MaNV,NgayCham,MaCa,SoGioLam,TrangThai,NguoiCham)
                VALUES(@a,@n,@d,@c,@g,@t,@u)",
                new SqlParameter("@a", maCC),
                new SqlParameter("@n", maNV),
                new SqlParameter("@d", ngay.Date),
                new SqlParameter("@c", maCa),
                new SqlParameter("@g", soGio),
                new SqlParameter("@t", trangThai),
                new SqlParameter("@u", nguoiCham));

            return KetQuaXuLy.Ok("Đã ghi chấm công.");
        }

        public KetQuaXuLy LapPhieuPhuTroi(string soPhieu, DateTime ngay, decimal soGio, string hinhThuc, string nguoiLap, string[] maNV)
        {
            if (soGio <= 0)
                return KetQuaXuLy.Fail("Số giờ phụ trội phải > 0.");
            if (maNV == null || maNV.Length == 0)
                return KetQuaXuLy.Fail("Phiếu phụ trội phải có nhân viên tham gia.");

            using (var cn = Db.Open())
            using (var tx = cn.BeginTransaction())
                try
                {
                    var q = new SqlCommand("INSERT PhieuPhuTroi(SoPhieu,NgayPhuTroi,SoGioPhuTroi,HinhThuc,HeSo,NguoiLap) VALUES(@s,@d,@g,@h,1.50,@n)", cn, tx);
                    q.Parameters.AddWithValue("@s", soPhieu);
                    q.Parameters.AddWithValue("@d", ngay.Date);
                    q.Parameters.AddWithValue("@g", soGio);
                    q.Parameters.AddWithValue("@h", hinhThuc);
                    q.Parameters.AddWithValue("@n", nguoiLap);
                    q.ExecuteNonQuery();

                    foreach (string m in maNV)
                    {
                        var c = new SqlCommand("INSERT ChiTietPhuTroi(SoPhieu,MaNV) VALUES(@s,@m)", cn, tx);
                        c.Parameters.AddWithValue("@s", soPhieu);
                        c.Parameters.AddWithValue("@m", m);
                        c.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return KetQuaXuLy.Ok("Đã lập phiếu phụ trội, hệ số 1.5.");
                }
                catch (Exception ex)
                {
                    tx.Rollback();
                    return KetQuaXuLy.Fail(ex.Message);
                }
        }
    }
}