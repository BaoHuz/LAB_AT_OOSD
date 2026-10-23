using System;
using System.Windows.Forms;
using QuanLyNhanSuDongA.Data;
using QuanLyNhanSuDongA.Services;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmPhuTroi : Form
    {
        private readonly ChamCongService service = new ChamCongService();

        public FrmPhuTroi()
        {
            InitializeComponent();
            FormLayout.Apply(this);
        }

        private void FrmPhuTroi_Load(object sender, EventArgs e)
        {
            try
            {
                cboHinhThucPT.Items.AddRange(new object[] { "Tăng ca", "Ngày lễ", "Ngày nghỉ" });
                cboHinhThucPT.SelectedIndex = 0;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể nạp dữ liệu: " + ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            dgvPhuTroi.DataSource = Db.Query("SELECT SoPhieu, NgayPhuTroi, SoGioPhuTroi, HinhThuc, HeSo, NguoiLap FROM PhieuPhuTroi ORDER BY NgayPhuTroi DESC");
        }

        private void btnLapPhieuPT_Click(object sender, EventArgs e)
        {
            string[] dsNV = txtDanhSachNVPT.Text.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < dsNV.Length; i++) dsNV[i] = dsNV[i].Trim();

            var res = service.LapPhieuPhuTroi(txtSoPhieuPT.Text, dtpNgayPT.Value, numSoGioPT.Value, cboHinhThucPT.Text, txtNguoiLapPT.Text, dsNV);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi", MessageBoxButtons.OK, res.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.ThanhCong) LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}