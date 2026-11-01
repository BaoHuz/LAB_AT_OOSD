using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmXetNghiem : Form
    {
        public FrmXetNghiem()
        {
            InitializeComponent();

            lblMaChiDinh.Text = "Mã phiếu | Mã XN:";
        }

        private void btnCapNhatKetQua_Click(object sender, EventArgs e)
        {
            string maGhep = txtMaChiDinh.Text.Trim();
            string ketQua = txtKetQua.Text.Trim();

            if (string.IsNullOrWhiteSpace(maGhep))
            {
                MessageBox.Show(
                    "Vui lòng nhập theo dạng: MaPhieuKham|MaXetNghiem\nVí dụ: PK01|XN01",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(ketQua))
            {
                MessageBox.Show(
                    "Kết quả xét nghiệm không được để trống!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string[] parts = maGhep.Split('|');

            if (parts.Length != 2)
            {
                MessageBox.Show(
                    "Sai định dạng.\nHãy nhập: MaPhieuKham|MaXetNghiem\nVí dụ: PK01|XN01",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            string maPhieuKham = parts[0].Trim();
            string maXetNghiem = parts[1].Trim();

            if (maPhieuKham.Length == 0 || maXetNghiem.Length == 0)
            {
                MessageBox.Show(
                    "Mã phiếu khám và mã xét nghiệm không được để trống!",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection cn = Db.CreateConnection())
                using (SqlCommand cmd = new SqlCommand(@"
                    UPDATE ChiDinhXetNghiem
                    SET
                        KetQua = @KetQua,
                        NgayThucHien = SYSDATETIME(),
                        TrangThai = 'DaCoKetQua'
                    WHERE MaPhieuKham = @MaPhieuKham
                      AND MaXetNghiem = @MaXetNghiem
                      AND TrangThai = 'ChoKetQua';", cn))
                {
                    cmd.Parameters.Add("@KetQua", SqlDbType.NVarChar, 2000)
                        .Value = ketQua;

                    cmd.Parameters.Add("@MaPhieuKham", SqlDbType.VarChar, 20)
                        .Value = maPhieuKham;

                    cmd.Parameters.Add("@MaXetNghiem", SqlDbType.VarChar, 20)
                        .Value = maXetNghiem;

                    cn.Open();

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show(
                            "Cập nhật kết quả xét nghiệm thành công!",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        txtKetQua.Clear();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Không tìm thấy chỉ định phù hợp hoặc xét nghiệm đã có kết quả.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi cập nhật kết quả xét nghiệm: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}