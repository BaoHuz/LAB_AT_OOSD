using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmHoaDonDichVu
    {
        TextBox txtMa,
            txtMaChon,
            txtSoTT,
            txtGC;
        ComboBox cboHD;
        DateTimePicker dtThang,
            dtNgayLap,
            dtNgayTT;
        Button btnLap,
            btnTT;
        DataGridView dgvHD,
            dgvCT;

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
            Text = "Hóa đơn dịch vụ";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1150, 680);
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
            dtThang = new DateTimePicker
            {
                Left = 540,
                Top = 20,
                Width = 170,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "MM/yyyy",
                ShowUpDown = true,
            };
            dtNgayLap = new DateTimePicker
            {
                Left = 540,
                Top = 60,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            btnLap = new Button
            {
                Text = "Lập hóa đơn",
                Left = 780,
                Top = 20,
                Width = 140,
                Height = 40,
            };
            btnLap.Click += btnLap_Click;
            dgvHD = new DataGridView
            {
                Left = 20,
                Top = 130,
                Width = 700,
                Height = 280,
            };
            dgvHD.CellClick += dgvHD_CellClick;
            dgvCT = new DataGridView
            {
                Left = 740,
                Top = 130,
                Width = 380,
                Height = 280,
            };
            txtMaChon = new TextBox
            {
                Left = 150,
                Top = 450,
                Width = 170,
                ReadOnly = true,
            };
            txtSoTT = new TextBox
            {
                Left = 150,
                Top = 490,
                Width = 170,
            };
            dtNgayTT = new DateTimePicker
            {
                Left = 540,
                Top = 450,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            txtGC = new TextBox
            {
                Left = 540,
                Top = 490,
                Width = 280,
            };
            btnTT = new Button
            {
                Text = "Thanh toán hóa đơn",
                Left = 850,
                Top = 450,
                Width = 180,
                Height = 42,
            };
            btnTT.Click += btnTT_Click;
            Controls.AddRange(
                new Control[]
                {
                    L("Mã hóa đơn", 20, 24),
                    txtMa,
                    L("Hợp đồng", 20, 64),
                    cboHD,
                    L("Tháng sử dụng", 400, 24),
                    dtThang,
                    L("Ngày lập", 400, 64),
                    dtNgayLap,
                    btnLap,
                    new Label
                    {
                        Text = "Danh sách hóa đơn",
                        Left = 20,
                        Top = 105,
                        Width = 180,
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    },
                    new Label
                    {
                        Text = "Chi tiết",
                        Left = 740,
                        Top = 105,
                        Width = 120,
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    },
                    dgvHD,
                    dgvCT,
                    L("Hóa đơn chọn", 20, 454),
                    txtMaChon,
                    L("Số TT dịch vụ", 20, 494),
                    txtSoTT,
                    L("Ngày thanh toán", 400, 454),
                    dtNgayTT,
                    L("Ghi chú", 400, 494),
                    txtGC,
                    btnTT,
                }
            );
        }
    }
}
