using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmPhongTienNghi : Form
    {
        readonly PhongTienNghiService s = new PhongTienNghiService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmPhongTienNghi()
        {
            InitializeComponent();
        }

        private void FrmPhongTienNghi_Load(object sender, EventArgs e)
        {
            // Nạp dữ liệu vào các ComboBox
            cboKhu.DataSource = dm.LayKhuVuc();
            cboKhu.DisplayMember = "TenKhuVuc";
            cboKhu.ValueMember = "MaKhuVuc";

            cboLoai.DataSource = dm.LayLoaiTienNghi();
            cboLoai.DisplayMember = "TenLoaiTN";
            cboLoai.ValueMember = "MaLoaiTN";

            cboTN.DataSource = s.LayTienNghi();
            cboTN.DisplayMember = "MaTienNghi";
            cboTN.ValueMember = "MaTienNghi";

            cboPhong.DataSource = s.LayPhong();
            cboPhong.DisplayMember = "SoPhong";
            cboPhong.ValueMember = "SoPhong";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            Tai();
        }

        void Tai()
        {
            dgvPhong.DataSource = s.LayPhong();
            dgvTN.DataSource = s.LayTienNghi();
            dgvLD.DataSource = s.LayLapDat();
        }

        void H(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo", MessageBoxButtons.OK, k.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            if (k.ThanhCong) Tai();
        }

        string V(ComboBox c) => c.SelectedValue?.ToString() ?? "";

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            H(s.ThemPhong(txtPhong.Text.Trim(), V(cboKhu), (int)numMax.Value, numGia.Value));
        }

        private void btnThemTN_Click(object sender, EventArgs e)
        {
            H(s.ThemTienNghi(txtMaTN.Text.Trim(), V(cboLoai), (int)numSTT.Value, txtTinhTrang.Text.Trim()));
        }

        private void btnLapDat_Click(object sender, EventArgs e)
        {
            H(s.LapDat(txtSoLD.Text.Trim(), V(cboTN), V(cboPhong), dtNgay.Value, txtTTLD.Text.Trim(), V(cboNV), txtGhiChu.Text.Trim()));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}