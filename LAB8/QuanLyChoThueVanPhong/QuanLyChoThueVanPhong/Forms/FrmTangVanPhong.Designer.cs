using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmTangVanPhong
    {
        TabControl tab;
        TabPage tabTang,
            tabVP;
        TextBox txtMaTang,
            txtTenTang,
            txtGhiChuTang,
            txtMaVP,
            txtTenPhong;
        NumericUpDown numSTT,
            numDienTich,
            numDonGia;
        ComboBox cboTang,
            cboHuong,
            cboTrangThai;
        Button btnThemTang,
            btnSuaTang,
            btnXoaTang,
            btnThemVP,
            btnSuaVP,
            btnXoaVP;
        DataGridView dgvTang,
            dgvVP;

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

        Button B(string t, int x, int y, EventHandler h)
        {
            var b = new Button
            {
                Text = t,
                Left = x,
                Top = y,
                Width = 100,
                Height = 34,
            };
            b.Click += h;
            return b;
        }

        private void InitializeComponent()
        {
            Text = "Tầng - Văn phòng";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1100, 650);
            Font = new Font("Segoe UI", 10F);
            tab = new TabControl { Dock = DockStyle.Fill };
            tabTang = new TabPage("Tầng");
            tabVP = new TabPage("Văn phòng");
            txtMaTang = new TextBox
            {
                Left = 140,
                Top = 20,
                Width = 180,
            };
            txtTenTang = new TextBox
            {
                Left = 140,
                Top = 60,
                Width = 260,
            };
            numSTT = new NumericUpDown
            {
                Left = 140,
                Top = 100,
                Width = 120,
                Minimum = 1,
                Maximum = 999,
            };
            txtGhiChuTang = new TextBox
            {
                Left = 140,
                Top = 140,
                Width = 420,
            };
            btnThemTang = B("Thêm", 600, 20, btnThemTang_Click);
            btnSuaTang = B("Sửa", 710, 20, btnSuaTang_Click);
            btnXoaTang = B("Xóa", 820, 20, btnXoaTang_Click);
            dgvTang = new DataGridView
            {
                Left = 20,
                Top = 210,
                Width = 1030,
                Height = 360,
                Anchor =
                    AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            dgvTang.CellClick += dgvTang_CellClick;
            tabTang.Controls.AddRange(
                new Control[]
                {
                    L("Mã tầng", 20, 24),
                    txtMaTang,
                    L("Tên tầng", 20, 64),
                    txtTenTang,
                    L("Số thứ tự", 20, 104),
                    numSTT,
                    L("Ghi chú", 20, 144),
                    txtGhiChuTang,
                    btnThemTang,
                    btnSuaTang,
                    btnXoaTang,
                    dgvTang,
                }
            );
            txtMaVP = new TextBox
            {
                Left = 140,
                Top = 20,
                Width = 160,
            };
            cboTang = new ComboBox
            {
                Left = 140,
                Top = 60,
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            txtTenPhong = new TextBox
            {
                Left = 140,
                Top = 100,
                Width = 220,
            };
            numDienTich = new NumericUpDown
            {
                Left = 140,
                Top = 140,
                Width = 160,
                Maximum = 100000,
                DecimalPlaces = 2,
            };
            cboHuong = new ComboBox
            {
                Left = 500,
                Top = 20,
                Width = 180,
            };
            numDonGia = new NumericUpDown
            {
                Left = 500,
                Top = 60,
                Width = 200,
                Maximum = 1000000000,
                ThousandsSeparator = true,
            };
            cboTrangThai = new ComboBox
            {
                Left = 500,
                Top = 100,
                Width = 180,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            btnThemVP = B("Thêm", 760, 20, btnThemVP_Click);
            btnSuaVP = B("Sửa", 870, 20, btnSuaVP_Click);
            btnXoaVP = B("Xóa", 980, 20, btnXoaVP_Click);
            dgvVP = new DataGridView
            {
                Left = 20,
                Top = 210,
                Width = 1030,
                Height = 360,
                Anchor =
                    AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
            };
            dgvVP.CellClick += dgvVP_CellClick;
            tabVP.Controls.AddRange(
                new Control[]
                {
                    L("Mã VP", 20, 24),
                    txtMaVP,
                    L("Tầng", 20, 64),
                    cboTang,
                    L("Tên phòng", 20, 104),
                    txtTenPhong,
                    L("Diện tích", 20, 144),
                    numDienTich,
                    L("Hướng", 390, 24),
                    cboHuong,
                    L("Đơn giá/tháng", 390, 64),
                    numDonGia,
                    L("Trạng thái", 390, 104),
                    cboTrangThai,
                    btnThemVP,
                    btnSuaVP,
                    btnXoaVP,
                    dgvVP,
                }
            );
            tab.Controls.Add(tabTang);
            tab.Controls.Add(tabVP);
            Controls.Add(tab);
        }
    }
}
