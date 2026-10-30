using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmNhanVien : Form
    {
        readonly NhanVienService sv = new NhanVienService();
        byte[] anh;

        public FrmNhanVien()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgv);
            FormHelper.Bind(cboKH, sv.LayKH(), "HienThi", "MaKH");
            FormHelper.Bind(cboVP, sv.LayVP(), "HienThi", "MaVP");
            Nap();
        }

        void Nap()
        {
            dgv.DataSource = sv.LayDanhSach();
        }

        private void btnAnh_Click(object s, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp" })
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    anh = File.ReadAllBytes(ofd.FileName);
                    using (var ms = new MemoryStream(anh))
                        pic.Image = Image.FromStream(ms);
                }
        }

        private void btnThem_Click(object s, EventArgs e)
        {
            try
            {
                sv.Them(
                    txtMa.Text.Trim(),
                    FormHelper.Val(cboKH),
                    FormHelper.Val(cboVP),
                    txtTen.Text.Trim(),
                    txtCV.Text.Trim(),
                    anh,
                    dtNgay.Value,
                    chkDang.Checked
                );
                Nap();
                FormHelper.Ok("Đã thêm nhân viên.");
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
                    FormHelper.Val(cboKH),
                    FormHelper.Val(cboVP),
                    txtTen.Text.Trim(),
                    txtCV.Text.Trim(),
                    anh,
                    dtNgay.Value,
                    chkDang.Checked
                );
                Nap();
                FormHelper.Ok("Đã cập nhật nhân viên.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnNghi_Click(object s, EventArgs e)
        {
            try
            {
                sv.Nghi(txtMa.Text.Trim());
                Nap();
                FormHelper.Ok("Đã cập nhật trạng thái nghỉ việc.");
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
            txtMa.Text = Convert.ToString(r.Cells["MaNV"].Value);
            cboKH.SelectedValue = Convert.ToString(r.Cells["MaKH"].Value);
            cboVP.SelectedValue = Convert.ToString(r.Cells["MaVP"].Value);
            txtTen.Text = Convert.ToString(r.Cells["HoTen"].Value);
            txtCV.Text = Convert.ToString(r.Cells["ChucVu"].Value);
            if (r.Cells["NgayBatDau"].Value != DBNull.Value)
                dtNgay.Value = Convert.ToDateTime(r.Cells["NgayBatDau"].Value);
            chkDang.Checked = Convert.ToBoolean(r.Cells["DangLamViec"].Value);
            if (r.Cells["HinhAnh"].Value != DBNull.Value)
            {
                anh = (byte[])r.Cells["HinhAnh"].Value;
                using (var ms = new MemoryStream(anh))
                    pic.Image = Image.FromStream(ms);
            }
            else
            {
                anh = null;
                pic.Image = null;
            }
        }
    }
}
