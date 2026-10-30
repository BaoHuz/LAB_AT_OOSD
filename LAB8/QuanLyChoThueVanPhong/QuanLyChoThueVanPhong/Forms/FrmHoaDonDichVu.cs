using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmHoaDonDichVu : Form
    {
        readonly HoaDonDichVuService sv = new HoaDonDichVuService();

        public FrmHoaDonDichVu()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgvHD);
            FormHelper.Grid(dgvCT);
            FormHelper.Bind(cboHD, sv.LayHopDong(), "HienThi", "MaHD");
            Nap();
        }

        void Nap()
        {
            dgvHD.DataSource = sv.LayHoaDon();
        }

        private void btnLap_Click(object s, EventArgs e)
        {
            try
            {
                sv.LapHoaDon(
                    txtMa.Text.Trim(),
                    FormHelper.Val(cboHD),
                    dtThang.Value,
                    dtNgayLap.Value
                );
                Nap();
                FormHelper.Ok("Đã lập hóa đơn dịch vụ tháng.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }

        private void dgvHD_CellClick(object s, DataGridViewCellEventArgs e)
        {
            if (dgvHD.CurrentRow == null)
                return;
            string ma = Convert.ToString(dgvHD.CurrentRow.Cells["MaHDDV"].Value);
            dgvCT.DataSource = sv.LayChiTiet(ma);
            txtMaChon.Text = ma;
        }

        private void btnTT_Click(object s, EventArgs e)
        {
            try
            {
                sv.ThanhToan(
                    txtSoTT.Text.Trim(),
                    txtMaChon.Text.Trim(),
                    dtNgayTT.Value,
                    txtGC.Text.Trim()
                );
                Nap();
                FormHelper.Ok("Đã thanh toán đủ hóa đơn dịch vụ.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }
    }
}
