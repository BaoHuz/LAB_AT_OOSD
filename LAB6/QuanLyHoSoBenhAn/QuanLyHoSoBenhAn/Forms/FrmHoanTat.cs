using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmHoanTat : Form
    {
        private KhamService khamService = new KhamService();

        public FrmHoanTat(string maPhieuKham = "PK01")
        {
            InitializeComponent();
            txtMaPhieuKham.Text = maPhieuKham;
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            try
            {
                khamService.HoanTatPhieu(txtMaPhieuKham.Text.Trim(), txtNguoiXacNhan.Text.Trim());
                MessageBox.Show($"Đã chốt hoàn tất thành công đợt khám [{txtMaPhieuKham.Text}]!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể hoàn tất: " + ex.Message, "Lỗi Điều Kiện", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}