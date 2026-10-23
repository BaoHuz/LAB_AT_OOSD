using System;
using System.Windows.Forms;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void MoForm(Form f)
        {
            using (f)
            {
                f.ShowDialog(this);
            }
        }
        private void btnDanhMuc_Click(object sender, EventArgs e) => MoForm(new FrmDanhMuc());
        private void btnTuyenDung_Click(object sender, EventArgs e) => MoForm(new FrmTuyenDung());
        private void btnHopDongBaoHiem_Click(object sender, EventArgs e) => MoForm(new FrmHopDongBaoHiem());
        private void btnQDLuongChucVu_Click(object sender, EventArgs e) => MoForm(new FrmLuongChucVu());
        private void btnKeHoachChamCong_Click(object sender, EventArgs e) => MoForm(new FrmKeHoachChamCong());
        private void btnPhuTroi_Click(object sender, EventArgs e) => MoForm(new FrmPhuTroi());
        private void btnKhenThuongKyLuat_Click(object sender, EventArgs e) => MoForm(new FrmKhenThuongKyLuat());
        private void btnBangLuongThongKe_Click(object sender, EventArgs e) => MoForm(new FrmBangLuong());
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}