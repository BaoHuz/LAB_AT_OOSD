using System;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmDangKy : Form
    {
        private DangKyService dangKyService = new DangKyService();

        public FrmDangKy()
        {
            InitializeComponent();
            string suffix = DateTime.Now.ToString("ddHHmmss");
            txtMaBN.Text = "BN" + suffix;
            txtMaHoSo.Text = "HS" + suffix; 
            txtSoPhieuThu.Text = "PT" + suffix;

            dtpNgaySinh.Value = new DateTime(1995, 1, 1);
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên bệnh nhân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            try
            {
                dangKyService.DangKyBenhNhanMoi(
                    txtMaBN.Text.Trim(),
                    txtMaHoSo.Text.Trim(),
                    txtSoPhieuThu.Text.Trim(),
                    txtHoTen.Text.Trim(),
                    dtpNgaySinh.Value,
                    txtDiaChi.Text.Trim(),
                    txtDienThoai.Text.Trim(),
                    "/images/patients/default.jpg",
                    numSoTien.Value
                );

                MessageBox.Show("Đăng ký bệnh nhân thành công và đã cấp Hồ sơ bệnh án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đăng ký: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}