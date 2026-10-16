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

        /// <summary>
        /// Mở các Form con dưới dạng ShowDialog đúng theo quy chuẩn điều hướng của bài Lab
        /// </summary>
        private void MoForm(Form f)
        {
            using (f)
            {
                f.ShowDialog(this);
            }
        }

        private void btnTiepNhan_Click(object sender, EventArgs e)
        {
            MoForm(new FrmDangKy());
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            MoForm(new FrmLichHen());
        }

        private void btnKhamBenh_Click(object sender, EventArgs e)
        {
            MoForm(new FrmLapToa());
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            MoForm(new FrmHoanTat());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát ứng dụng?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}