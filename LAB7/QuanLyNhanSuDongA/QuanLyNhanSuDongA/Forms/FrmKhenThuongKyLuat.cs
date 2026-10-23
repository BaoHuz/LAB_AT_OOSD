using System;
using System.Windows.Forms;
using QuanLyNhanSuDongA.Data;
using QuanLyNhanSuDongA.Services;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmKhenThuongKyLuat : Form
    {
        private readonly KhenThuongKyLuatService service = new KhenThuongKyLuatService();

        public FrmKhenThuongKyLuat()
        {
            InitializeComponent();
            FormLayout.Apply(this);
        }

        private void FrmKhenThuongKyLuat_Load(object sender, EventArgs e)
        {
            try
            {
                cboCachThu.Items.AddRange(new object[] { "TRU_LUONG", "PHIEU_THU" });
                cboCachThu.SelectedIndex = 0;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể nạp dữ liệu: " + ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            dgvKT.DataSource = Db.Query("SELECT SoQDKT, NgayQD, MaNV, MaPB, LoaiKhenThuong, SoTien, NoiDung, NguoiKy FROM QuyetDinhKhenThuong ORDER BY NgayQD DESC");
            dgvKL.DataSource = Db.Query("SELECT SoQDKL, NgayQD, MaNV, MaPB, HinhThucXuLy, SoTienPhat, CachThu, DaXuLy, NguoiKy FROM QuyetDinhKyLuat ORDER BY NgayQD DESC");
        }

        private void btnLapKT_Click(object sender, EventArgs e)
        {
            string nv = string.IsNullOrWhiteSpace(txtMaNVKT.Text) ? null : txtMaNVKT.Text;
            string pb = string.IsNullOrWhiteSpace(txtMaPBKT.Text) ? null : txtMaPBKT.Text;

            var res = service.LapQuyetDinhKhenThuong(txtSoQDKT.Text, dtpNgayKT.Value, nv, pb, txtLoaiKT.Text, numSoTienKT.Value, txtNoiDungKT.Text, txtNguoiKyKT.Text);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi");
            if (res.ThanhCong) LoadData();
        }

        private void btnLapKL_Click(object sender, EventArgs e)
        {
            string nv = string.IsNullOrWhiteSpace(txtMaNVKL.Text) ? null : txtMaNVKL.Text;
            string pb = string.IsNullOrWhiteSpace(txtMaPBKL.Text) ? null : txtMaPBKL.Text;

            var res = service.LapQuyetDinhKyLuat(txtSoQDKL.Text, dtpNgayKL.Value, nv, pb, txtHinhThucKL.Text, numSoTienKL.Value, cboCachThu.Text, txtNoiDungKL.Text, txtNguoiKyKL.Text);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi");
            if (res.ThanhCong) LoadData();
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}