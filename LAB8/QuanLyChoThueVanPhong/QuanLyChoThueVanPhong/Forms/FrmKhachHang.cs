using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmKhachHang : Form
    {
        readonly KhachHangService sv = new KhachHangService();

        public FrmKhachHang()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgv);
            cboLoai.Items.AddRange(new object[] { "Cá nhân", "Doanh nghiệp" });
            cboLoai.SelectedIndex = 1;
            Nap();
        }

        void Nap()
        {
            dgv.DataSource = sv.LayDanhSach();
        }

        private void btnThem_Click(object s, EventArgs e)
        {
            try
            {
                sv.Them(
                    txtMa.Text.Trim(),
                    txtTen.Text.Trim(),
                    cboLoai.Text,
                    txtMST.Text.Trim(),
                    txtDC.Text.Trim(),
                    txtDT.Text.Trim(),
                    txtEmail.Text.Trim()
                );
                Nap();
                FormHelper.Ok("Đã thêm khách hàng.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnSua_Click(object s, EventArgs e)
        {
            try
            {
                sv.Sua(
                    txtMa.Text.Trim(),
                    txtTen.Text.Trim(),
                    cboLoai.Text,
                    txtMST.Text.Trim(),
                    txtDC.Text.Trim(),
                    txtDT.Text.Trim(),
                    txtEmail.Text.Trim()
                );
                Nap();
                FormHelper.Ok("Đã cập nhật khách hàng.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnXoa_Click(object s, EventArgs e)
        {
            try
            {
                if (FormHelper.Confirm("Xóa khách hàng đang chọn?"))
                {
                    sv.Xoa(txtMa.Text.Trim());
                    Nap();
                }
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void dgv_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow == null)
                return;
            var r = dgv.CurrentRow;
            txtMa.Text = Convert.ToString(r.Cells["MaKH"].Value);
            txtTen.Text = Convert.ToString(r.Cells["TenKhachHang"].Value);
            cboLoai.Text = Convert.ToString(r.Cells["LoaiKhach"].Value);
            txtMST.Text = Convert.ToString(r.Cells["MaSoThue"].Value);
            txtDC.Text = Convert.ToString(r.Cells["DiaChi"].Value);
            txtDT.Text = Convert.ToString(r.Cells["DienThoai"].Value);
            txtEmail.Text = Convert.ToString(r.Cells["Email"].Value);
        }
    }
}
