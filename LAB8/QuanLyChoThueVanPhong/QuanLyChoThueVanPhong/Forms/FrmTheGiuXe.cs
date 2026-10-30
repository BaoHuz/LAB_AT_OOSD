using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmTheGiuXe : Form
    {
        readonly TheGiuXeService sv = new TheGiuXeService();

        public FrmTheGiuXe()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgv);
            FormHelper.Bind(cboNV, sv.LayNV(), "HienThi", "MaNV");
            cboTT.Items.AddRange(new object[] { "Hoạt động", "Khóa", "Đã thu hồi" });
            cboTT.SelectedIndex = 0;
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
                    FormHelper.Val(cboNV),
                    txtBien.Text.Trim(),
                    txtLoai.Text.Trim(),
                    txtMau.Text.Trim(),
                    dtNgay.Value,
                    cboTT.Text
                );
                Nap();
                FormHelper.Ok("Đã cấp thẻ.");
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
                    FormHelper.Val(cboNV),
                    txtBien.Text.Trim(),
                    txtLoai.Text.Trim(),
                    txtMau.Text.Trim(),
                    dtNgay.Value,
                    cboTT.Text
                );
                Nap();
                FormHelper.Ok("Đã cập nhật thẻ.");
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
                if (FormHelper.Confirm("Xóa thẻ?"))
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
            txtMa.Text = Convert.ToString(r.Cells["MaThe"].Value);
            cboNV.SelectedValue = Convert.ToString(r.Cells["MaNV"].Value);
            txtBien.Text = Convert.ToString(r.Cells["BienSoXe"].Value);
            txtLoai.Text = Convert.ToString(r.Cells["LoaiXe"].Value);
            txtMau.Text = Convert.ToString(r.Cells["MauXe"].Value);
            dtNgay.Value = Convert.ToDateTime(r.Cells["NgayCap"].Value);
            cboTT.Text = Convert.ToString(r.Cells["TrangThai"].Value);
        }
    }
}
