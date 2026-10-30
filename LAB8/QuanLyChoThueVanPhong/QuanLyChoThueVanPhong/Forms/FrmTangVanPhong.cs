using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmTangVanPhong : Form
    {
        readonly TangVanPhongService sv = new TangVanPhongService();

        public FrmTangVanPhong()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgvTang);
            FormHelper.Grid(dgvVP);
            cboTrangThai.Items.AddRange(new object[] { "Trống", "Đang thuê", "Bảo trì" });
            cboHuong.Items.AddRange(
                new object[]
                {
                    "Đông",
                    "Tây",
                    "Nam",
                    "Bắc",
                    "Đông Nam",
                    "Đông Bắc",
                    "Tây Nam",
                    "Tây Bắc",
                }
            );
            Nap();
        }

        void Nap()
        {
            dgvTang.DataSource = sv.LayTang();
            dgvVP.DataSource = sv.LayVanPhong();
            FormHelper.Bind(cboTang, sv.LayTang(), "TenTang", "MaTang");
        }

        private void btnThemTang_Click(object s, EventArgs e)
        {
            try
            {
                sv.ThemTang(
                    txtMaTang.Text.Trim(),
                    txtTenTang.Text.Trim(),
                    (int)numSTT.Value,
                    txtGhiChuTang.Text.Trim()
                );
                Nap();
                FormHelper.Ok("Đã thêm tầng.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnSuaTang_Click(object s, EventArgs e)
        {
            try
            {
                sv.SuaTang(
                    txtMaTang.Text.Trim(),
                    txtTenTang.Text.Trim(),
                    (int)numSTT.Value,
                    txtGhiChuTang.Text.Trim()
                );
                Nap();
                FormHelper.Ok("Đã cập nhật tầng.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnXoaTang_Click(object s, EventArgs e)
        {
            try
            {
                if (FormHelper.Confirm("Xóa tầng đang chọn?"))
                {
                    sv.XoaTang(txtMaTang.Text.Trim());
                    Nap();
                }
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void dgvTang_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (dgvTang.CurrentRow == null)
                return;
            var r = dgvTang.CurrentRow;
            txtMaTang.Text = Convert.ToString(r.Cells["MaTang"].Value);
            txtTenTang.Text = Convert.ToString(r.Cells["TenTang"].Value);
            numSTT.Value = Convert.ToDecimal(r.Cells["SoThuTu"].Value);
            txtGhiChuTang.Text = Convert.ToString(r.Cells["GhiChu"].Value);
        }

        private void btnThemVP_Click(object s, EventArgs e)
        {
            try
            {
                sv.ThemVP(
                    txtMaVP.Text.Trim(),
                    FormHelper.Val(cboTang),
                    txtTenPhong.Text.Trim(),
                    numDienTich.Value,
                    cboHuong.Text,
                    numDonGia.Value,
                    cboTrangThai.Text
                );
                Nap();
                FormHelper.Ok("Đã thêm văn phòng.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnSuaVP_Click(object s, EventArgs e)
        {
            try
            {
                sv.SuaVP(
                    txtMaVP.Text.Trim(),
                    FormHelper.Val(cboTang),
                    txtTenPhong.Text.Trim(),
                    numDienTich.Value,
                    cboHuong.Text,
                    numDonGia.Value,
                    cboTrangThai.Text
                );
                Nap();
                FormHelper.Ok("Đã cập nhật văn phòng.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void btnXoaVP_Click(object s, EventArgs e)
        {
            try
            {
                if (FormHelper.Confirm("Xóa văn phòng đang chọn?"))
                {
                    sv.XoaVP(txtMaVP.Text.Trim());
                    Nap();
                }
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void dgvVP_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (dgvVP.CurrentRow == null)
                return;
            var r = dgvVP.CurrentRow;
            txtMaVP.Text = Convert.ToString(r.Cells["MaVP"].Value);
            cboTang.SelectedValue = Convert.ToString(r.Cells["MaTang"].Value);
            txtTenPhong.Text = Convert.ToString(r.Cells["TenPhong"].Value);
            numDienTich.Value = Convert.ToDecimal(r.Cells["DienTichSuDung"].Value);
            cboHuong.Text = Convert.ToString(r.Cells["Huong"].Value);
            numDonGia.Value = Convert.ToDecimal(r.Cells["DonGiaThang"].Value);
            cboTrangThai.Text = Convert.ToString(r.Cells["TrangThai"].Value);
        }
    }
}
