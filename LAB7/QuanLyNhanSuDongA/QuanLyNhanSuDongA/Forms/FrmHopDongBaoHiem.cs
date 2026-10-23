using System;
using System.Windows.Forms;
using QuanLyNhanSuDongA.Data;
using QuanLyNhanSuDongA.Services;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmHopDongBaoHiem : Form
    {
        private readonly NhanSuService service = new NhanSuService();

        public FrmHopDongBaoHiem()
        {
            InitializeComponent();
            FormLayout.Apply(this);
        }

        private void FrmHopDongBaoHiem_Load(object sender, EventArgs e)
        {
            try
            {
                cboLoaiHD.Items.AddRange(new object[] { "Ngắn hạn", "Dài hạn" });
                cboLoaiHD.SelectedIndex = 1;
                cboLoaiBH.Items.AddRange(new object[] { "BHYT", "BHXH" });
                cboLoaiBH.SelectedIndex = 0;

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể nạp dữ liệu: " + ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            dgvHopDong.DataSource = Db.Query("SELECT SoHD, MaNV, LoaiHD, NgayKy, TuNgay, DenNgay, TrangThai FROM HopDongLaoDong ORDER BY NgayKy DESC");
            dgvBaoHiem.DataSource = Db.Query("SELECT MaHSBH, MaNV, SoHD, LoaiBH, SoSoThe, TyLeNguoiLD, TyLeCongTy, TuNgay FROM HoSoBaoHiem ORDER BY TuNgay DESC");
        }

        private void btnKyHD_Click(object sender, EventArgs e)
        {
            DateTime? den = cboLoaiHD.Text == "Ngắn hạn" ? dtpDenNgayHD.Value : (DateTime?)null;
            var res = service.KyHopDong(txtSoHD.Text, txtMaNV.Text, cboLoaiHD.Text, dtpNgayKy.Value, dtpTuNgayHD.Value, den);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi");
            if (res.ThanhCong) LoadData();
        }

        private void btnLuuBH_Click(object sender, EventArgs e)
        {
            var res = service.LuuBaoHiem(txtMaHSBH.Text, txtMaNVBH.Text, txtSoHDBH.Text, cboLoaiBH.Text, txtSoTheBH.Text, numTyLeNV.Value, numTyLeCT.Value, dtpTuNgayBH.Value);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi");
            if (res.ThanhCong) LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}