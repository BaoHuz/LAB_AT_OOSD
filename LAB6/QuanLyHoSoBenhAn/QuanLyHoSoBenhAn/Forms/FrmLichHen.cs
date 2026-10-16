using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmLichHen : Form
    {
        private KhamService khamService = new KhamService();

        public FrmLichHen(string maHoSo = "HS01")
        {
            InitializeComponent();
            txtMaHoSo.Text = maHoSo;
            txtMaLichHen.Text = "LH" + DateTime.Now.ToString("ddHHmmss");
            dtpNgayHen.Value = DateTime.Now.AddDays(3); // Mặc định hẹn sau 3 ngày
        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLichHen.Text) || string.IsNullOrWhiteSpace(txtMaHoSo.Text))
            {
                MessageBox.Show("Mã lịch hẹn và mã hồ sơ không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Gọi Stored Procedure dbo.sp_DatLichHen trong KhamService
                khamService.DatLichHen(
                    txtMaLichHen.Text.Trim(),
                    txtMaHoSo.Text.Trim(),
                    dtpNgayHen.Value
                );

                MessageBox.Show($"Đặt lịch khám định kỳ thành công cho hồ sơ [{txtMaHoSo.Text.Trim()}]!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể đặt lịch: " + ex.Message, "Lỗi Nghiệp Vụ / CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}