using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmTheGiuXe
    {
        TextBox txtMa,
            txtBien,
            txtLoai,
            txtMau;
        ComboBox cboNV,
            cboTT;
        DateTimePicker dtNgay;
        Button btnThem,
            btnSua,
            btnXoa;
        DataGridView dgv;

        Label L(string t, int x, int y)
        {
            return new Label
            {
                Text = t,
                Left = x,
                Top = y,
                Width = 120,
            };
        }

        private void InitializeComponent()
        {
            Text = "Thẻ giữ xe";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1000, 600);
            Font = new Font("Segoe UI", 10F);
            txtMa = new TextBox
            {
                Left = 140,
                Top = 20,
                Width = 160,
            };
            cboNV = new ComboBox
            {
                Left = 140,
                Top = 60,
                Width = 300,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            txtBien = new TextBox
            {
                Left = 140,
                Top = 100,
                Width = 170,
            };
            txtLoai = new TextBox
            {
                Left = 570,
                Top = 20,
                Width = 170,
            };
            txtMau = new TextBox
            {
                Left = 570,
                Top = 60,
                Width = 170,
            };
            dtNgay = new DateTimePicker
            {
                Left = 570,
                Top = 100,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            cboTT = new ComboBox
            {
                Left = 570,
                Top = 140,
                Width = 170,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            btnThem = new Button
            {
                Text = "Cấp thẻ",
                Left = 800,
                Top = 20,
                Width = 120,
            };
            btnThem.Click += btnThem_Click;
            btnSua = new Button
            {
                Text = "Cập nhật",
                Left = 800,
                Top = 60,
                Width = 120,
            };
            btnSua.Click += btnSua_Click;
            btnXoa = new Button
            {
                Text = "Xóa",
                Left = 800,
                Top = 100,
                Width = 120,
            };
            btnXoa.Click += btnXoa_Click;
            dgv = new DataGridView
            {
                Left = 20,
                Top = 210,
                Width = 940,
                Height = 330,
            };
            dgv.CellClick += dgv_CellClick;
            Controls.AddRange(
                new Control[]
                {
                    L("Mã thẻ", 20, 24),
                    txtMa,
                    L("Nhân viên", 20, 64),
                    cboNV,
                    L("Biển số xe", 20, 104),
                    txtBien,
                    L("Loại xe", 450, 24),
                    txtLoai,
                    L("Màu xe", 450, 64),
                    txtMau,
                    L("Ngày cấp", 450, 104),
                    dtNgay,
                    L("Trạng thái", 450, 144),
                    cboTT,
                    btnThem,
                    btnSua,
                    btnXoa,
                    dgv,
                }
            );
        }
    }
}
