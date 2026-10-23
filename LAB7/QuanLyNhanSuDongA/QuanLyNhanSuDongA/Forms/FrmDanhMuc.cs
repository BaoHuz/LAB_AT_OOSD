using System;
using System.Data;
using System.Windows.Forms;
using QuanLyNhanSuDongA.Data;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmDanhMuc : Form
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
            FormLayout.Apply(this);
        }

        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            NapDuLieu();
        }

        private void NapDuLieu()
        {
            try
            {
                dgvPhongBan.AutoGenerateColumns = true;
                dgvCaLam.AutoGenerateColumns = true;
                dgvChucVu.AutoGenerateColumns = true;

                DataTable dtPB = Db.Query("SELECT MaPB AS [Mã PB], TenPB AS [Tên Phòng Ban], LoaiDonVi AS [Loại Đơn Vị] FROM PhongBan");
                dgvPhongBan.DataSource = dtPB;

                DataTable dtCa = Db.Query("SELECT MaCa AS [Mã Ca], TenCa AS [Tên Ca], GioBatDau AS [Giờ Bắt Đầu], GioKetThuc AS [Giờ Kết Thúc] FROM CaLamViec");
                dgvCaLam.DataSource = dtCa;

                DataTable dtCV = Db.Query("SELECT MaCV AS [Mã CV], TenCV AS [Tên Chức Vụ], MoTa AS [Mô Tả] FROM ChucVu");
                dgvChucVu.DataSource = dtCV;

                dgvPhongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCaLam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message, "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}