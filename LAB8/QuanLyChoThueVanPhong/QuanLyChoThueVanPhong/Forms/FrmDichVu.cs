using QuanLyChoThueVanPhong.Services;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmDichVu : Form
    {
        readonly DichVuService sv = new DichVuService();

        public FrmDichVu()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgvDV);
            FormHelper.Grid(dgvSD);
            NapDV();
            NapSD();
            FormHelper.Bind(cboHD, sv.LayHopDong(), "HienThi", "MaHD");
            FormHelper.Bind(cboDV, sv.LayDVCombo(), "HienThi", "MaDV");
            cboHD.SelectedIndexChanged += delegate
            {
                NapVP();
            };
            cboDV.SelectedIndexChanged += delegate
            {
                NapGia();
            };
            NapVP();
            NapGia();
        }

        void NapDV()
        {
            dgvDV.DataSource = sv.LayDichVu();
        }

        void NapSD()
        {
            dgvSD.DataSource = sv.LaySuDung();
        }

        void NapVP()
        {
            var h = FormHelper.Val(cboHD);
            if (h != "")
                FormHelper.Bind(cboVP, sv.LayVP(h), "HienThi", "MaVP");
        }

        void NapGia()
        {
            var d = FormHelper.Val(cboDV);
            if (d != "")
                numGiaSD.Value = Math.Min(numGiaSD.Maximum, sv.LayDonGia(d));
        }

        private void btnThemDV_Click(object s, EventArgs e)
        {
            try
            {
                sv.ThemDV(
                    txtMaDV.Text.Trim(),
                    txtTenDV.Text.Trim(),
                    txtDVT.Text.Trim(),
                    numGiaDV.Value,
                    chkDung.Checked
                );
                NapDV();
                FormHelper.Ok("Đã thêm dịch vụ.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnSuaDV_Click(object s, EventArgs e)
        {
            try
            {
                sv.SuaDV(
                    txtMaDV.Text.Trim(),
                    txtTenDV.Text.Trim(),
                    txtDVT.Text.Trim(),
                    numGiaDV.Value,
                    chkDung.Checked
                );
                NapDV();
                FormHelper.Ok("Đã cập nhật dịch vụ.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnXoaDV_Click(object s, EventArgs e)
        {
            try
            {
                if (FormHelper.Confirm("Xóa dịch vụ?"))
                {
                    sv.XoaDV(txtMaDV.Text.Trim());
                    NapDV();
                }
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void dgvDV_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (dgvDV.CurrentRow == null)
                return;
            var r = dgvDV.CurrentRow;
            txtMaDV.Text = Convert.ToString(r.Cells["MaDV"].Value);
            txtTenDV.Text = Convert.ToString(r.Cells["TenDV"].Value);
            txtDVT.Text = Convert.ToString(r.Cells["DonViTinh"].Value);
            numGiaDV.Value = Convert.ToDecimal(r.Cells["DonGia"].Value);
            chkDung.Checked = Convert.ToBoolean(r.Cells["DangSuDung"].Value);
        }

        private void btnGhiNhan_Click(object s, EventArgs e)
        {
            try
            {
                sv.GhiNhan(
                    txtMaSD.Text.Trim(),
                    FormHelper.Val(cboHD),
                    FormHelper.Val(cboVP),
                    FormHelper.Val(cboDV),
                    dtThang.Value,
                    numSL.Value,
                    numGiaSD.Value
                );
                NapSD();
                FormHelper.Ok("Đã ghi nhận sử dụng dịch vụ.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnXoaSD_Click(object s, EventArgs e)
        {
            try
            {
                if (dgvSD.CurrentRow == null)
                    return;
                sv.XoaSuDung(Convert.ToString(dgvSD.CurrentRow.Cells["MaSD"].Value));
                NapSD();
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }
    }
}
