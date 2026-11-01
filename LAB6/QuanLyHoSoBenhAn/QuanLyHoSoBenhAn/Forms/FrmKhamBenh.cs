using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmKhamBenh : Form
    {
        public FrmKhamBenh()
        {
            InitializeComponent();
        }

        private void btnLuuPhieuKham_Click(object sender, EventArgs e)
        {
            string maHoSo = txtMaHoSo.Text.Trim();
            string trieuChung = txtTrieuChung.Text.Trim();
            string chanDoan = txtChanDoan.Text.Trim();

            if (string.IsNullOrWhiteSpace(maHoSo))
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã hồ sơ bệnh án!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(chanDoan))
            {
                MessageBox.Show(
                    "Vui lòng nhập chẩn đoán!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection cn = Db.CreateConnection())
            {
                cn.Open();

                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT COUNT(*)
                            FROM HoSoBenhAn
                            WHERE MaHoSo = @MaHoSo
                              AND TrangThai = 'HoatDong';", cn, tx))
                        {
                            cmd.Parameters.Add("@MaHoSo", SqlDbType.VarChar, 20).Value = maHoSo;

                            int count = Convert.ToInt32(cmd.ExecuteScalar());

                            if (count == 0)
                                throw new Exception("Mã hồ sơ không tồn tại hoặc hồ sơ không còn hoạt động.");
                        }

                        string maBS;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT TOP 1 MaBS
                            FROM BacSi
                            ORDER BY MaBS;", cn, tx))
                        {
                            object result = cmd.ExecuteScalar();

                            if (result == null || result == DBNull.Value)
                                throw new Exception("Chưa có bác sĩ trong danh mục.");

                            maBS = result.ToString();
                        }


                        string maKhoa;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT TOP 1 MaKhoa
                            FROM KhoaDieuTri
                            ORDER BY MaKhoa;", cn, tx))
                        {
                            object result = cmd.ExecuteScalar();

                            if (result == null || result == DBNull.Value)
                                throw new Exception("Chưa có khoa điều trị trong danh mục.");

                            maKhoa = result.ToString();
                        }

                        string maLichHen = null;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT TOP 1 MaLichHen
                            FROM LichHenDinhKy WITH (UPDLOCK, HOLDLOCK)
                            WHERE MaHoSo = @MaHoSo
                              AND TrangThai = 'DaHen'
                              AND CAST(NgayGioHen AS DATE) = CAST(SYSDATETIME() AS DATE)
                            ORDER BY NgayGioHen;", cn, tx))
                        {
                            cmd.Parameters.Add("@MaHoSo", SqlDbType.VarChar, 20).Value = maHoSo;

                            object result = cmd.ExecuteScalar();

                            if (result != null && result != DBNull.Value)
                                maLichHen = result.ToString();
                        }

                        string loaiKham =
                            string.IsNullOrEmpty(maLichHen)
                            ? "Thuong"
                            : "DinhKy";


                        string maPhieuKham =
                            "PK" + DateTime.Now.ToString("yyyyMMddHHmmssfff");


                        using (SqlCommand cmd = new SqlCommand(@"
                            INSERT INTO PhieuKhamBenh
                            (
                                MaPhieuKham,
                                MaHoSo,
                                MaBS,
                                MaKhoa,
                                MaLichHen,
                                NgayGioKham,
                                TrieuChung,
                                ChanDoan,
                                LoaiKham,
                                TrangThai
                            )
                            VALUES
                            (
                                @MaPhieuKham,
                                @MaHoSo,
                                @MaBS,
                                @MaKhoa,
                                @MaLichHen,
                                SYSDATETIME(),
                                @TrieuChung,
                                @ChanDoan,
                                @LoaiKham,
                                'DangXuLy'
                            );", cn, tx))
                        {
                            cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                                .Value = maPhieuKham;

                            cmd.Parameters.Add("@MaHoSo", SqlDbType.VarChar, 20)
                                .Value = maHoSo;

                            cmd.Parameters.Add("@MaBS", SqlDbType.VarChar, 20)
                                .Value = maBS;

                            cmd.Parameters.Add("@MaKhoa", SqlDbType.VarChar, 20)
                                .Value = maKhoa;

                            cmd.Parameters.Add("@MaLichHen", SqlDbType.VarChar, 20)
                                .Value = string.IsNullOrEmpty(maLichHen)
                                    ? (object)DBNull.Value
                                    : maLichHen;

                            cmd.Parameters.Add("@TrieuChung", SqlDbType.NVarChar, 1000)
                                .Value = string.IsNullOrWhiteSpace(trieuChung)
                                    ? (object)DBNull.Value
                                    : trieuChung;

                            cmd.Parameters.Add("@ChanDoan", SqlDbType.NVarChar, 1000)
                                .Value = chanDoan;

                            cmd.Parameters.Add("@LoaiKham", SqlDbType.VarChar, 10)
                                .Value = loaiKham;

                            cmd.ExecuteNonQuery();
                        }


                        if (!string.IsNullOrEmpty(maLichHen))
                        {
                            using (SqlCommand cmd = new SqlCommand(@"
                                UPDATE LichHenDinhKy
                                SET TrangThai = 'DaKham'
                                WHERE MaLichHen = @MaLichHen;", cn, tx))
                            {
                                cmd.Parameters.Add("@MaLichHen", SqlDbType.VarChar, 20)
                                    .Value = maLichHen;

                                cmd.ExecuteNonQuery();
                            }
                        }

                        tx.Commit();

                        txtMaPhieuKham.Text = maPhieuKham;

                        MessageBox.Show(
                            "Tạo phiếu khám thành công!\n\n" +
                            "Mã phiếu: " + maPhieuKham +
                            "\nBác sĩ: " + maBS +
                            "\nKhoa: " + maKhoa +
                            "\nLoại khám: " + loaiKham,
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            tx.Rollback();
                        }
                        catch
                        {
                        }

                        MessageBox.Show(
                            "Lỗi tạo phiếu khám: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}