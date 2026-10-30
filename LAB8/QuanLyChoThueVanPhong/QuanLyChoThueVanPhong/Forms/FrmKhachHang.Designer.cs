using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmKhachHang
    {
        TextBox txtMa,
            txtTen,
            txtMST,
            txtDC,
            txtDT,
            txtEmail;
        ComboBox cboLoai;
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

        Button B(string t, int x, EventHandler h)
        {
            var b = new Button
            {
                Text = t,
                Left = x,
                Top = 150,
                Width = 100,
                Height = 34,
            };
            b.Click += h;
            return b;
        }

        private void InitializeComponent()
        {
            Text = "Khách hàng";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1050, 620);
            Font = new Font("Segoe UI", 10F);
            txtMa = new TextBox
            {
                Left = 140,
                Top = 20,
                Width = 170,
            };
            txtTen = new TextBox
            {
                Left = 140,
                Top = 60,
                Width = 350,
            };
            cboLoai = new ComboBox
            {
                Left = 140,
                Top = 100,
                Width = 170,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            txtMST = new TextBox
            {
                Left = 620,
                Top = 20,
                Width = 200,
            };
            txtDT = new TextBox
            {
                Left = 620,
                Top = 60,
                Width = 200,
            };
            txtEmail = new TextBox
            {
                Left = 620,
                Top = 100,
                Width = 320,
            };
            txtDC = new TextBox
            {
                Left = 140,
                Top = 150,
                Width = 350,
            };
            btnThem = B("Thêm", 620, btnThem_Click);
            btnSua = B("Sửa", 730, btnSua_Click);
            btnXoa = B("Xóa", 840, btnXoa_Click);
            dgv = new DataGridView
            {
                Left = 20,
                Top = 230,
                Width = 1000,
                Height = 350,
                Anchor =
                    AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            dgv.CellClick += dgv_CellClick;
            Controls.AddRange(
                new Control[]
                {
                    L("Mã khách hàng", 20, 24),
                    txtMa,
                    L("Tên khách hàng", 20, 64),
                    txtTen,
                    L("Loại khách", 20, 104),
                    cboLoai,
                    L("Địa chỉ", 20, 154),
                    txtDC,
                    L("Mã số thuế", 500, 24),
                    txtMST,
                    L("Điện thoại", 500, 64),
                    txtDT,
                    L("Email", 500, 104),
                    txtEmail,
                    btnThem,
                    btnSua,
                    btnXoa,
                    dgv,
                }
            );
        }
    }
}
