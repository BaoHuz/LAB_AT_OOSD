using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmThanhToanTienThue : Form
    {
        readonly ThanhToanTienThueService sv = new ThanhToanTienThueService();

        public FrmThanhToanTienThue()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgv);
            FormHelper.Bind(cboHD, sv.LayHopDong(), "HienThi", "MaHD");
            numThang.Minimum = 7;
            numThang.Maximum = 240;
            cboHD.SelectedIndexChanged += cboHD_Changed;
            Nap();
        }

        void cboHD_Changed(object s, EventArgs e)
        {
            Nap();
        }

        void Nap()
        {
            string hd = FormHelper.Val(cboHD);
            if (string.IsNullOrEmpty(hd))
                return;
            dgv.DataSource = sv.LayThanhToan(hd);
            numTien.Value = Math.Min(numTien.Maximum, sv.TienThueThang(hd));
        }

        private void btnThanhToan_Click(object s, EventArgs e)
        {
            try
            {
                sv.ThanhToan(
                    txtSoTT.Text.Trim(),
                    FormHelper.Val(cboHD),
                    (int)numThang.Value,
                    dtNgayTT.Value,
                    numTien.Value,
                    txtGC.Text.Trim()
                );
                Nap();
                FormHelper.Ok("Đã ghi nhận thanh toán tiền thuê.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }
    }
}
