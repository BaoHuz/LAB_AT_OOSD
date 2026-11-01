using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmPhatThuoc : Form
    {
        public FrmPhatThuoc()
        {
            InitializeComponent();
        }

        private void btnPhatThuoc_Click(object sender, EventArgs e)
        {
            string maToa = txtMaToaThuoc.Text.Trim();

            if (string.IsNullOrWhiteSpace(maToa))
            {
                MessageBox.Show(
                    "Vui lòng nhập Mã toa thuốc!",
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
                        string maPhieuKham = null;
                        bool daPhat = false;
                        bool daThanhToan = false;

                        using (SqlCommand cmd = new SqlCommand(@"
                            SELECT
                                t.MaPhieuKham,
                                t.DaPhat,
                                ISNULL(h.DaThanhToan, 0) AS DaThanhToan
                            FROM ToaThuoc t WITH (UPDLOCK, HOLDLOCK)
                            LEFT JOIN HoaDonVienPhi h
                                ON h.MaPhieuKham = t.MaPhieuKham
                            WHERE t.MaToa = @MaToa;", cn, tx))
                        {
                            cmd.Parameters.Add("@MaToa", SqlDbType.VarChar, 20)
                                .Value = maToa;

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (!reader.Read())
                                    throw new Exception("Mã toa thuốc không tồn tại.");

                                maPhieuKham = reader["MaPhieuKham"].ToString();
                                daPhat = Convert.ToBoolean(reader["DaPhat"]);
                                daThanhToan = Convert.ToBoolean(reader["DaThanhToan"]);
                            }
                        }

                        if (daPhat)
                            throw new Exception("Toa thuốc này đã được phát trước đó.");

                        if (!daThanhToan)
                            throw new Exception(
                                "Phiếu khám chưa thanh toán viện phí. Không được phát thuốc.");

                        using (SqlCommand cmd = new SqlCommand(@"
                            UPDATE ToaThuoc
                            SET
                                DaPhat = 1,
                                NgayPhat = SYSDATETIME()
                            WHERE MaToa = @MaToa
                              AND DaPhat = 0;", cn, tx))
                        {
                            cmd.Parameters.Add("@MaToa", SqlDbType.VarChar, 20)
                                .Value = maToa;

                            int rows = cmd.ExecuteNonQuery();

                            if (rows == 0)
                                throw new Exception("Không thể cập nhật trạng thái phát thuốc.");
                        }

                        tx.Commit();

                        MessageBox.Show(
                            "Xác nhận phát thuốc thành công!\n\n" +
                            "Mã toa: " + maToa +
                            "\nMã phiếu khám: " + maPhieuKham,
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
                            "Không thể phát thuốc: " + ex.Message,
                            "Lỗi",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}