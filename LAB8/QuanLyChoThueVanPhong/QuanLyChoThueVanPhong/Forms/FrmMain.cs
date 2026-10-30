using System;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Open(Form f)
        {
            using (f)
            {
                f.ShowDialog(this);
            }
        }

        private void btnTangVP_Click(object sender, EventArgs e)
        {
            Open(new FrmTangVanPhong());
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            Open(new FrmKhachHang());
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            Open(new FrmHopDong());
        }

        private void btnTT_Click(object sender, EventArgs e)
        {
            Open(new FrmThanhToanTienThue());
        }

        private void btnDV_Click(object sender, EventArgs e)
        {
            Open(new FrmDichVu());
        }

        private void btnHDDV_Click(object sender, EventArgs e)
        {
            Open(new FrmHoaDonDichVu());
        }

        private void btnGH_Click(object sender, EventArgs e)
        {
            Open(new FrmGiaHan());
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            Open(new FrmNhanVien());
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            Open(new FrmTheGiuXe());
        }

        private void btnKT_Click(object sender, EventArgs e)
        {
            Open(new FrmKiemTraPhong());
        }
    }
}