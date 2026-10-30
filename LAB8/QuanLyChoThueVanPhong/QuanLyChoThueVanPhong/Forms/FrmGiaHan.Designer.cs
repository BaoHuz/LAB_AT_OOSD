using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmGiaHan
    {
        TextBox txtMa,
            txtGC;
        ComboBox cboHD,
            cboVP;
        DateTimePicker dtNgay;
        NumericUpDown numThang;
        Label lblInfo;
        Button btnGiaHan;
        DataGridView dgv;

        Label L(string t, int x, int y)
        {
            return new Label
            {
                Text = t,
                Left = x,
                Top = y,
                Width = 130,
            };
        }

        private void InitializeComponent()
        {
            Text = "Gia hạn văn phòng";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1000, 620);
            Font = new Font("Segoe UI", 10F);
            txtMa = new TextBox
            {
                Left = 150,
                Top = 20,
                Width = 170,
            };
            cboHD = new ComboBox
            {
                Left = 150,
                Top = 60,
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            cboVP = new ComboBox
            {
                Left = 150,
                Top = 100,
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            dtNgay = new DateTimePicker
            {
                Left = 580,
                Top = 20,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            numThang = new NumericUpDown
            {
                Left = 580,
                Top = 60,
                Width = 120,
            };
            txtGC = new TextBox
            {
                Left = 580,
                Top = 100,
                Width = 300,
            };
            lblInfo = new Label
            {
                Left = 20,
                Top = 150,
                Width = 850,
                Height = 35,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
            };
            btnGiaHan = new Button
            {
                Text = "LẬP PHIẾU GIA HẠN",
                Left = 780,
                Top = 45,
                Width = 180,
                Height = 45,
            };
            btnGiaHan.Click += btnGiaHan_Click;
            dgv = new DataGridView
            {
                Left = 20,
                Top = 210,
                Width = 940,
                Height = 350,
            };
            Controls.AddRange(
                new Control[]
                {
                    L("Mã gia hạn", 20, 24),
                    txtMa,
                    L("Hợp đồng", 20, 64),
                    cboHD,
                    L("Văn phòng", 20, 104),
                    cboVP,
                    L("Ngày lập", 440, 24),
                    dtNgay,
                    L("Số tháng gia hạn", 440, 64),
                    numThang,
                    L("Ghi chú", 440, 104),
                    txtGC,
                    lblInfo,
                    btnGiaHan,
                    dgv,
                }
            );
        }
    }
}
