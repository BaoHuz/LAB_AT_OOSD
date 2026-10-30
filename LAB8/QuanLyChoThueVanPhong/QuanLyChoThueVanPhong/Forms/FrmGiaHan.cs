using System;
using System.Windows.Forms;
using QuanLyChoThueVanPhong.Services;

namespace QuanLyChoThueVanPhong.Forms
{
    public partial class FrmGiaHan : Form
    {
        readonly GiaHanService sv = new GiaHanService();

        public FrmGiaHan()
        {
            InitializeComponent();
            Load += Frm_Load;
        }

        void Frm_Load(object s, EventArgs e)
        {
            FormHelper.Grid(dgv);
            FormHelper.Bind(cboHD, sv.LayHopDong(), "HienThi", "MaHD");
            cboHD.SelectedIndexChanged += delegate
            {
                NapVP();
            };
            cboVP.SelectedIndexChanged += delegate
            {
                ThongTin();
            };
            numThang.Minimum = 1;
            numThang.Maximum = 120;
            NapVP();
            Nap();
        }

        void NapVP()
        {
            var h = FormHelper.Val(cboHD);
            if (h != "")
                FormHelper.Bind(cboVP, sv.LayVP(h), "HienThi", "MaVP");
            ThongTin();
        }

        void ThongTin()
        {
            var h = FormHelper.Val(cboHD);
            var v = FormHelper.Val(cboVP);
            lblInfo.Text = (h == "" || v == "") ? "" : sv.ThongTin(h, v);
        }

        void Nap()
        {
            dgv.DataSource = sv.LayDanhSach();
        }

        private void btnGiaHan_Click(object s, EventArgs e)
        {
            try
            {
                sv.GiaHan(
                    txtMa.Text.Trim(),
                    FormHelper.Val(cboHD),
                    FormHelper.Val(cboVP),
                    dtNgay.Value,
                    (int)numThang.Value,
                    txtGC.Text.Trim()
                );
                Nap();
                ThongTin();
                FormHelper.Ok("Gia hạn thành công.");
            }
            catch (Exception ex)
            {
                FormHelper.Error(ex);
            }
        }
    }
}
