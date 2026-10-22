using System;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            FrmDangKy frm = new FrmDangKy();
            frm.ShowDialog();
        }


        private void mnuHoSo_Click(object sender, EventArgs e)
        {
            FrmHoSo frm = new FrmHoSo();
            frm.ShowDialog();
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            FrmLichHen frm = new FrmLichHen();
            frm.ShowDialog();
        }

        private void mnuKhamBenh_Click(object sender, EventArgs e)
        {
            FrmKhamBenh frm = new FrmKhamBenh();
            frm.ShowDialog();
        }

        private void mnuXetNghiem_Click(object sender, EventArgs e)
        {
            FrmXetNghiem frm = new FrmXetNghiem();
            frm.ShowDialog();
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            FrmLapToa frm = new FrmLapToa();
            frm.ShowDialog();
        }

        private void mnuThanhToan_Click(object sender, EventArgs e)
        {
            FrmThanhToan frm = new FrmThanhToan();
            frm.ShowDialog();
        }

        private void mnuPhatThuoc_Click(object sender, EventArgs e)
        {
            FrmPhatThuoc frm = new FrmPhatThuoc();
            frm.ShowDialog();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            FrmHoanTat frm = new FrmHoanTat();
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát khỏi ứng dụng không?",
                "Xác nhận thoát",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}