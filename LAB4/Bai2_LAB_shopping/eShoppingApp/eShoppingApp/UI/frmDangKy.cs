using System;
using System.Windows.Forms;
using eShoppingApp.Services;

namespace eShoppingApp.UI
{
    public partial class frmDangKy : Form
    {
        private AccountService accountService = new AccountService();

        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (accountService.Register(txtHoTen.Text.Trim(), txtUser.Text.Trim(), txtPass.Text.Trim(), txtEmail.Text.Trim(), txtPhone.Text.Trim(), txtAddr.Text.Trim(), out string msg))
            {
                MessageBox.Show(msg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(msg, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}