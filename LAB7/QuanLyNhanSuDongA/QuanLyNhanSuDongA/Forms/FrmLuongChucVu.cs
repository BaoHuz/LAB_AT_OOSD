using System;
using System.Windows.Forms;
using QuanLyNhanSuDongA.Data;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmLuongChucVu : Form
    {
        public FrmLuongChucVu()
        {
            InitializeComponent();
            FormLayout.Apply(this);
        }

        private void FrmLuongChucVu_Load(object sender, EventArgs e)
        {
            try
            {
                LoadChucVu();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể nạp dữ liệu: " + ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadChucVu()
        {
            cboChucVu.DataSource = Db.Query("SELECT MaCV, TenCV FROM ChucVu ORDER BY TenCV");
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";
        }

        private void LoadData()
        {
            dgvLuong.DataSource = Db.Query("SELECT SoQDL, MaNV, NgayHieuLuc, LuongCoBan, PhuCapLuong, PhuCapDocHai, NguoiKy FROM QuyetDinhLuong ORDER BY NgayHieuLuc DESC");
            dgvChucVu.DataSource = Db.Query("SELECT q.SoQDCV, q.MaNV, c.TenCV, q.PhuCapChucVu, q.NgayHieuLuc FROM QuyetDinhChucVu q JOIN ChucVu c ON q.MaCV=c.MaCV ORDER BY q.NgayHieuLuc DESC");
        }

        private void btnLapQDLuong_Click(object sender, EventArgs e)
        {
            try
            {
                Db.Execute(@"INSERT INTO QuyetDinhLuong(SoQDL, MaNV, NgayQD, NgayHieuLuc, LuongCoBan, PhuCapLuong, PhuCapDocHai, NguoiKy) 
                             VALUES(@s, @m, GETDATE(), @h, @l, @pl, @pd, @k)",
                    new System.Data.SqlClient.SqlParameter("@s", txtSoQDL.Text),
                    new System.Data.SqlClient.SqlParameter("@m", txtMaNVL.Text),
                    new System.Data.SqlClient.SqlParameter("@h", dtpHieuLucL.Value.Date),
                    new System.Data.SqlClient.SqlParameter("@l", numLuongCB.Value),
                    new System.Data.SqlClient.SqlParameter("@pl", numPCLuong.Value),
                    new System.Data.SqlClient.SqlParameter("@pd", numPCDocHai.Value),
                    new System.Data.SqlClient.SqlParameter("@k", txtNguoiKyL.Text));
                MessageBox.Show("Đã lập quyết định lương thành công.");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnLapQDCV_Click(object sender, EventArgs e)
        {
            try
            {
                Db.Execute(@"INSERT INTO QuyetDinhChucVu(SoQDCV, MaNV, MaCV, NgayQD, NgayHieuLuc, PhuCapChucVu, NguoiKy) 
                             VALUES(@s, @m, @cv, GETDATE(), @h, @pc, @k)",
                    new System.Data.SqlClient.SqlParameter("@s", txtSoQDCV.Text),
                    new System.Data.SqlClient.SqlParameter("@m", txtMaNVCV.Text),
                    new System.Data.SqlClient.SqlParameter("@cv", cboChucVu.SelectedValue),
                    new System.Data.SqlClient.SqlParameter("@h", dtpHieuLucCV.Value.Date),
                    new System.Data.SqlClient.SqlParameter("@pc", numPCCV.Value),
                    new System.Data.SqlClient.SqlParameter("@k", txtNguoiKyCV.Text));
                MessageBox.Show("Đã lập quyết định bổ nhiệm chức vụ thành công.");
                LoadData();
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}