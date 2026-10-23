using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSuDongA.Data;
using QuanLyNhanSuDongA.Services;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmTuyenDung : Form
    {
        private readonly NhanSuService service = new NhanSuService();

        public FrmTuyenDung()
        {
            InitializeComponent();
            FormLayout.Apply(this);
        }

        private void FrmTuyenDung_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtPB = Db.Query("SELECT MaPB, TenPB FROM PhongBan");
                cboPhongBan.DataSource = dtPB;
                cboPhongBan.DisplayMember = "TenPB";
                cboPhongBan.ValueMember = "MaPB";

                NapDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu Tuyển dụng: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void NapDanhSach()
        {
            dgvDanhSach.AutoGenerateColumns = true;
            DataTable dtTD = Db.Query(@"SELECT q.SoQDTD AS [Số QĐ], q.MaNV AS [Mã NV], n.HoTen AS [Họ Tên NV], 
                                               p.TenPB AS [Phòng Thử Việc], q.TuNgay AS [Từ Ngày], q.DenNgay AS [Đến Ngày], 
                                               q.LuongThuViec AS [Lương Thử Việc], q.NguoiKy AS [Người Ký] 
                                        FROM QuyetDinhTuyenDung q 
                                        LEFT JOIN NhanVien n ON q.MaNV = n.MaNV 
                                        LEFT JOIN PhongBan p ON q.MaPBThuViec = p.MaPB 
                                        ORDER BY q.NgayQD DESC");

            dgvDanhSach.DataSource = dtTD;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnLap_Click(object sender, EventArgs e)
        {
            var res = service.LapQuyetDinhTuyenDung(
                txtSoQD.Text, txtMaNV.Text, txtHoTen.Text,
                cboPhongBan.SelectedValue?.ToString(),
                dtpTuNgay.Value, dtpDenNgay.Value,
                numLuongThuViec.Value, txtNoiDung.Text, txtNguoiKy.Text
            );

            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi", MessageBoxButtons.OK, res.ThanhCong ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (res.ThanhCong) NapDanhSach();
        }
        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}