using System;
using System.Data;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmHopDong : Form
    {
        readonly HopDongService sv = new HopDongService();
        DataTable chon = new DataTable();

        public FrmHopDong()
        {
            InitializeComponent();
            chon.Columns.Add("MaVP", typeof(string));
            chon.Columns.Add("DonGiaThang", typeof(decimal));
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgvTrong);
            FormHelper.Grid(dgvChon);
            FormHelper.Grid(dgvHD);
            numThang.Minimum = 6;
            numThang.Maximum = 120;
            numThang.Value = 6;
            Nap();
        }

        void Nap()
        {
            FormHelper.Bind(cboKH, sv.LayKhachHang(), "HienThi", "MaKH");
            dgvTrong.DataSource = sv.LayVanPhongTrong();
            dgvChon.DataSource = chon;
            dgvHD.DataSource = sv.LayHopDong();
        }

        private void btnAddVP_Click(object s, EventArgs e)
        {
            if (dgvTrong.CurrentRow == null)
                return;
            string ma = Convert.ToString(dgvTrong.CurrentRow.Cells["MaVP"].Value);
            foreach (DataRow r in chon.Rows)
                if (Convert.ToString(r["MaVP"]) == ma)
                    return;
            chon.Rows.Add(ma, Convert.ToDecimal(dgvTrong.CurrentRow.Cells["DonGiaThang"].Value));
        }

        private void btnRemoveVP_Click(object s, EventArgs e)
        {
            if (dgvChon.CurrentRow == null)
                return;
            string ma = Convert.ToString(dgvChon.CurrentRow.Cells["MaVP"].Value);
            foreach (DataRow r in chon.Select("MaVP='" + ma.Replace("'", "''") + "'"))
                chon.Rows.Remove(r);
        }

        private void btnLap_Click(object s, EventArgs e)
        {
            try
            {
                if (chon.Rows.Count == 0)
                    throw new Exception("Phải chọn ít nhất một văn phòng.");
                sv.LapHopDong(
                    txtMaHD.Text.Trim(),
                    FormHelper.Val(cboKH),
                    dtNgayKy.Value,
                    dtBatDau.Value,
                    (int)numThang.Value,
                    txtGhiChu.Text.Trim(),
                    chon
                );
                FormHelper.Ok("Đã lập hợp đồng và ghi nhận trả trước 6 tháng đầu.");
                chon.Rows.Clear();
                Nap();
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
            string hd = Convert.ToString(dgvHD.CurrentRow.Cells["MaHD"].Value);
            dgvChiTiet.DataSource = sv.LayChiTiet(hd);
            FormHelper.Grid(dgvChiTiet);
        }
    }
}
