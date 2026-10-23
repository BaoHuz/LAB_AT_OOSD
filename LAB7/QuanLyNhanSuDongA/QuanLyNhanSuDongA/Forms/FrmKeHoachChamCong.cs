using System;
using System.Windows.Forms;
using QuanLyNhanSuDongA.Data;
using QuanLyNhanSuDongA.Services;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmKeHoachChamCong : Form
    {
        private readonly KeHoachService khService = new KeHoachService();
        private readonly ChamCongService ccService = new ChamCongService();

        public FrmKeHoachChamCong()
        {
            InitializeComponent();
            FormLayout.Apply(this);
        }

        private void FrmKeHoachChamCong_Load(object sender, EventArgs e)
        {
            try
            {
                cboPhongBan.DataSource = Db.Query("SELECT MaPB, TenPB FROM PhongBan ORDER BY TenPB");
                cboPhongBan.DisplayMember = "TenPB";
                cboPhongBan.ValueMember = "MaPB";

                cboCa.DataSource = Db.Query("SELECT MaCa, TenCa FROM CaLamViec ORDER BY MaCa");
                cboCa.DisplayMember = "TenCa";
                cboCa.ValueMember = "MaCa";

                cboCaCC.DataSource = Db.Query("SELECT MaCa, TenCa FROM CaLamViec ORDER BY MaCa");
                cboCaCC.DisplayMember = "TenCa";
                cboCaCC.ValueMember = "MaCa";

                cboTrangThaiCC.Items.AddRange(new object[] { "Đi làm", "Nghỉ", "Vắng" });
                cboTrangThaiCC.SelectedIndex = 0;

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể nạp dữ liệu: " + ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            dgvKeHoach.DataSource = Db.Query("SELECT MaKH, MaPB, TuanTuNgay, TuanDenNgay, NgayLap, NguoiLap FROM KeHoachTuan ORDER BY TuanTuNgay DESC");
            dgvChamCong.DataSource = Db.Query("SELECT MaCC, MaNV, NgayCham, MaCa, SoGioLam, TrangThai, NguoiCham FROM PhieuChamCong ORDER BY NgayCham DESC");
        }

        private void btnTaoKH_Click(object sender, EventArgs e)
        {
            var res = khService.TaoKeHoach(txtMaKH.Text, cboPhongBan.SelectedValue?.ToString(), dtpTuNgay.Value, dtpDenNgay.Value, txtNguoiLap.Text);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi");
            if (res.ThanhCong) LoadData();
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            var res = khService.ThemChiTiet(txtMaKHPC.Text, (int)numSTT.Value, txtMaNVPC.Text, dtpNgayLamPC.Value, cboCa.SelectedValue?.ToString(), false, null, null);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi");
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            var res = ccService.ChamCong(txtMaCC.Text, txtMaNVCC.Text, dtpNgayCC.Value, cboCaCC.SelectedValue?.ToString(), numSoGioLam.Value, cboTrangThaiCC.Text, txtNguoiCham.Text);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi");
            if (res.ThanhCong) LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}