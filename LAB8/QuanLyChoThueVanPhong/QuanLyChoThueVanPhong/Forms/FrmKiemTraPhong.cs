using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmKiemTraPhong : Form
    {
        readonly KiemTraPhongService sv = new KiemTraPhongService();

        public FrmKiemTraPhong()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgv);
            FormHelper.Bind(cboVP, sv.LayVP(), "HienThi", "MaVP");
            Nap();
        }

        void Nap()
        {
            dgv.DataSource = sv.LayDanhSach();
        }

        decimal? Phat()
        {
            return chkDoi.Checked ? numPhat.Value : (decimal?)null;
        }

        private void btnThem_Click(object s, EventArgs e)
        {
            try
            {
                sv.Them(
                    txtMa.Text.Trim(),
                    FormHelper.Val(cboVP),
                    dtNgay.Value,
                    txtTT.Text.Trim(),
                    chkDoi.Checked,
                    Phat(),
                    txtKN.Text.Trim(),
                    txtNguoi.Text.Trim()
                );
                Nap();
                FormHelper.Ok("Đã lưu kết quả kiểm tra.");
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
                    FormHelper.Val(cboVP),
                    dtNgay.Value,
                    txtTT.Text.Trim(),
                    chkDoi.Checked,
                    Phat(),
                    txtKN.Text.Trim(),
                    txtNguoi.Text.Trim()
                );
                Nap();
                FormHelper.Ok("Đã cập nhật kết quả kiểm tra.");
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
                if (FormHelper.Confirm("Xóa phiếu kiểm tra?"))
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
            txtMa.Text = Convert.ToString(r.Cells["MaKT"].Value);
            cboVP.SelectedValue = Convert.ToString(r.Cells["MaVP"].Value);
            dtNgay.Value = Convert.ToDateTime(r.Cells["NgayKiemTra"].Value);
            txtTT.Text = Convert.ToString(r.Cells["TinhTrang"].Value);
            chkDoi.Checked = Convert.ToBoolean(r.Cells["CoThayDoiKetCau"].Value);
            numPhat.Value =
                r.Cells["MucPhat"].Value == DBNull.Value
                    ? 0
                    : Convert.ToDecimal(r.Cells["MucPhat"].Value);
            txtKN.Text = Convert.ToString(r.Cells["KienNghiSuaChua"].Value);
            txtNguoi.Text = Convert.ToString(r.Cells["NguoiKiemTra"].Value);
        }
    }
}
