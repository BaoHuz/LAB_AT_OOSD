using eShoppingApp.Services;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace eShoppingApp.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CapNhatTrangThai();


            if (string.IsNullOrEmpty(AccountService.CurrentMaKH))
            {
                YeuCauDangNhap();
            }
        }

        private bool YeuCauDangNhap()
        {
            frmDangNhap frm = new frmDangNhap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                CapNhatTrangThai();


                MoFormDanhSachSanPham();
                return true;
            }
            return false;
        }

        private void MoFormDanhSachSanPham()
        {

            foreach (Form child in this.MdiChildren)
            {
                if (child is frmDanhSachSanPham)
                {
                    child.Activate();
                    return;
                }
            }


            frmDanhSachSanPham frmSP = new frmDanhSachSanPham();
            frmSP.MdiParent = this;
            frmSP.Show();
        }

        private void CapNhatTrangThai()
        {
            if (!string.IsNullOrEmpty(AccountService.CurrentMaKH))
            {
                lblWelcome.Text = $"Xin chào: {AccountService.CurrentHoTen} | Mã KH: {AccountService.CurrentMaKH}";
                dangNhapToolStripMenuItem.Enabled = false;
                dangXuatToolStripMenuItem.Enabled = true;
            }
            else
            {
                lblWelcome.Text = "Chưa đăng nhập hệ thống!";
                dangNhapToolStripMenuItem.Enabled = true;
                dangXuatToolStripMenuItem.Enabled = false;
            }
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeuCauDangNhap();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountService.CurrentMaKH = "";
            AccountService.CurrentHoTen = "";

  
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            CapNhatTrangThai();
            MessageBox.Show("Đã đăng xuất tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            YeuCauDangNhap();
        }

        private void danhSachSPToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
            if (string.IsNullOrEmpty(AccountService.CurrentMaKH))
            {
                MessageBox.Show("Bạn cần phải đăng nhập tài khoản trước khi thực hiện mua sắm!", "Yêu cầu đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (YeuCauDangNhap())
                {
                    return;
                }
            }
            else
            {
                MoFormDanhSachSanPham();
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
