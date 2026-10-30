using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmThanhToanTienThue
    {
        TextBox txtSoTT,
            txtGC;
        ComboBox cboHD;
        NumericUpDown numThang,
            numTien;
        DateTimePicker dtNgayTT;
        Button btnThanhToan;
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
            Text = "Thanh toán tiền thuê từ tháng 7";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1000, 600);
            Font = new Font("Segoe UI", 10F);
            txtSoTT = new TextBox
            {
                Left = 150,
                Top = 20,
                Width = 180,
            };
            cboHD = new ComboBox
            {
                Left = 150,
                Top = 60,
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            numThang = new NumericUpDown
            {
                Left = 150,
                Top = 100,
                Width = 100,
            };
            dtNgayTT = new DateTimePicker
            {
                Left = 580,
                Top = 20,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            numTien = new NumericUpDown
            {
                Left = 580,
                Top = 60,
                Width = 220,
                Maximum = 1000000000,
                ThousandsSeparator = true,
            };
            txtGC = new TextBox
            {
                Left = 580,
                Top = 100,
                Width = 300,
            };
            btnThanhToan = new Button
            {
                Text = "Thanh toán",
                Left = 820,
                Top = 20,
                Width = 130,
                Height = 40,
            };
            btnThanhToan.Click += btnThanhToan_Click;
            dgv = new DataGridView
            {
                Left = 20,
                Top = 180,
                Width = 940,
                Height = 370,
            };
            Controls.AddRange(
                new Control[]
                {
                    L("Số thanh toán", 20, 24),
                    txtSoTT,
                    L("Hợp đồng", 20, 64),
                    cboHD,
                    L("Kỳ tháng", 20, 104),
                    numThang,
                    L("Ngày thanh toán", 440, 24),
                    dtNgayTT,
                    L("Số tiền", 440, 64),
                    numTien,
                    L("Ghi chú", 440, 104),
                    txtGC,
                    btnThanhToan,
                    dgv,
                }
            );
        }
    }
}
