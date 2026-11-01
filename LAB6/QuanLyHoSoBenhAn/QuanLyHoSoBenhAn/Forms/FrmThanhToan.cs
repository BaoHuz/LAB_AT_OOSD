using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmThanhToan : Form
    {
        public FrmThanhToan()
        {
            InitializeComponent();

            lblTongTien.Text = "Tiền khám (VNĐ):";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string maPhieuKham = txtMaPhieuKham.Text.Trim();

            if (string.IsNullOrWhiteSpace(maPhieuKham))
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã phiếu khám cần thanh toán!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            decimal tienKhamNhap;

            if (!decimal.TryParse(txtTongTien.Text.Trim(), out tienKhamNhap) ||
                tienKhamNhap < 0)
            {
                MessageBox.Show(
                    "Tiền khám phải là số >= 0.",
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
                        string loaiKham = null;
                        string trangThai = null;
                        string chanDoan = null;


                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT
                                LoaiKham,
                                TrangThai,
                                ChanDoan
                            FROM PhieuKhamBenh WITH (UPDLOCK, HOLDLOCK)
                            WHERE MaPhieuKham = @MaPhieuKham;", cn, tx))
                        {
                            cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                                .Value = maPhieuKham;

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                    throw new Exception("Không tìm thấy phiếu khám.");

                                loaiKham = reader["LoaiKham"].ToString();
                                trangThai = reader["TrangThai"].ToString();

                                chanDoan = reader["ChanDoan"] == DBNull.Value
                                    ? null
                                    : reader["ChanDoan"].ToString();
                            }
                        }

                        if (trangThai == "HoanTat")
                            throw new Exception("Phiếu khám đã hoàn tất, không thể thanh toán lại.");

                        if (string.IsNullOrWhiteSpace(chanDoan))
                            throw new Exception("Phiếu khám chưa có chẩn đoán.");

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT COUNT(*)
                            FROM ChiDinhXetNghiem
                            WHERE MaPhieuKham = @MaPhieuKham
                              AND TrangThai <> 'DaCoKetQua';", cn, tx))
                        {
                            cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                                .Value = maPhieuKham;

                            int pending = Convert.ToInt32(cmd.ExecuteScalar());

                            if (pending > 0)
                                throw new Exception("Còn xét nghiệm chưa có kết quả.");
                        }

                        decimal tienXN;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT ISNULL(SUM(DonGiaApDung), 0)
                            FROM ChiDinhXetNghiem
                            WHERE MaPhieuKham = @MaPhieuKham;", cn, tx))
                        {
                            cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                                .Value = maPhieuKham;

                            tienXN = Convert.ToDecimal(cmd.ExecuteScalar());
                        }


                        decimal tienThuoc;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT ISNULL(SUM(ct.ThanhTien), 0)
                            FROM ToaThuoc t
                            JOIN ChiTietToaThuoc ct
                                ON ct.MaToa = t.MaToa
                            WHERE t.MaPhieuKham = @MaPhieuKham;", cn, tx))
                        {
                            cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                                .Value = maPhieuKham;

                            tienThuoc = Convert.ToDecimal(cmd.ExecuteScalar());
                        }

                        decimal tienKham =
                            loaiKham == "DinhKy"
                            ? 0
                            : tienKhamNhap;

                        decimal mienGiam = 0;

                        decimal tongThanhToan =
                            tienKham + tienXN + tienThuoc - mienGiam;

                        using (SqlCommand cmd = new SqlCommand(@"
                            UPDATE PhieuKhamBenh
                            SET TrangThai = 'ChoThanhToan'
                            WHERE MaPhieuKham = @MaPhieuKham
                              AND TrangThai = 'DangXuLy';", cn, tx))
                        {
                            cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                                .Value = maPhieuKham;

                            cmd.ExecuteNonQuery();
                        }

                        string soHoaDon = null;
                        bool daThanhToan = false;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT SoHoaDon, DaThanhToan
                            FROM HoaDonVienPhi WITH (UPDLOCK, HOLDLOCK)
                            WHERE MaPhieuKham = @MaPhieuKham;", cn, tx))
                        {
                            cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                                .Value = maPhieuKham;

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    soHoaDon = reader["SoHoaDon"].ToString();
                                    daThanhToan = Convert.ToBoolean(reader["DaThanhToan"]);
                                }
                            }
                        }

                        if (daThanhToan)
                            throw new Exception("Phiếu khám này đã được thanh toán.");

                        if (string.IsNullOrEmpty(soHoaDon))
                        {
                            soHoaDon =
                                "HD" + DateTime.Now.ToString("yyyyMMddHHmmssfff");

                            using (SqlCommand cmd = new SqlCommand(@"
                                INSERT INTO HoaDonVienPhi
                                (
                                    SoHoaDon,
                                    MaPhieuKham,
                                    NgayThanhToan,
                                    TongTienKham,
                                    TongTienXN,
                                    TongTienThuoc,
                                    MienGiam,
                                    DaThanhToan
                                )
                                VALUES
                                (
                                    @SoHoaDon,
                                    @MaPhieuKham,
                                    SYSDATETIME(),
                                    @TongTienKham,
                                    @TongTienXN,
                                    @TongTienThuoc,
                                    @MienGiam,
                                    1
                                );", cn, tx))
                            {
                                cmd.Parameters.Add("@SoHoaDon", SqlDbType.VarChar, 20)
                                    .Value = soHoaDon;

                                cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                                    .Value = maPhieuKham;

                                cmd.Parameters.Add("@TongTienKham", SqlDbType.Decimal)
                                    .Value = tienKham;

                                cmd.Parameters.Add("@TongTienXN", SqlDbType.Decimal)
                                    .Value = tienXN;

                                cmd.Parameters.Add("@TongTienThuoc", SqlDbType.Decimal)
                                    .Value = tienThuoc;

                                cmd.Parameters.Add("@MienGiam", SqlDbType.Decimal)
                                    .Value = mienGiam;

                                cmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            using (SqlCommand cmd = new SqlCommand(@"
                                UPDATE HoaDonVienPhi
                                SET
                                    NgayThanhToan = SYSDATETIME(),
                                    TongTienKham = @TongTienKham,
                                    TongTienXN = @TongTienXN,
                                    TongTienThuoc = @TongTienThuoc,
                                    MienGiam = @MienGiam,
                                    DaThanhToan = 1
                                WHERE SoHoaDon = @SoHoaDon;", cn, tx))
                            {
                                cmd.Parameters.Add("@TongTienKham", SqlDbType.Decimal)
                                    .Value = tienKham;

                                cmd.Parameters.Add("@TongTienXN", SqlDbType.Decimal)
                                    .Value = tienXN;

                                cmd.Parameters.Add("@TongTienThuoc", SqlDbType.Decimal)
                                    .Value = tienThuoc;

                                cmd.Parameters.Add("@MienGiam", SqlDbType.Decimal)
                                    .Value = mienGiam;

                                cmd.Parameters.Add("@SoHoaDon", SqlDbType.VarChar, 20)
                                    .Value = soHoaDon;

                                cmd.ExecuteNonQuery();
                            }
                        }

                        tx.Commit();

                        MessageBox.Show(
                            "Thanh toán thành công!\n\n" +
                            "Số hóa đơn: " + soHoaDon +
                            "\nTiền khám: " + tienKham.ToString("N0") + " VNĐ" +
                            "\nTiền xét nghiệm: " + tienXN.ToString("N0") + " VNĐ" +
                            "\nTiền thuốc: " + tienThuoc.ToString("N0") + " VNĐ" +
                            "\n-----------------------------" +
                            "\nTổng thanh toán: " + tongThanhToan.ToString("N0") + " VNĐ",
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
                            "Không thể thanh toán: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}