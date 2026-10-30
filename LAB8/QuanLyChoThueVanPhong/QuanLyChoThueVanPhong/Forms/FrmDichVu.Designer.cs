using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmDichVu
    {
        TabControl tab;
        TabPage p1,
            p2;
        TextBox txtMaDV,
            txtTenDV,
            txtDVT,
            txtMaSD;
        NumericUpDown numGiaDV,
            numSL,
            numGiaSD;
        CheckBox chkDung;
        ComboBox cboHD,
            cboVP,
            cboDV;
        DateTimePicker dtThang;
        Button btnThemDV,
            btnSuaDV,
            btnXoaDV,
            btnGhiNhan,
            btnXoaSD;
        DataGridView dgvDV,
            dgvSD;

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
                Width = 110,
                Height = 34,
            };
            b.Click += h;
            return b;
        }

        private void InitializeComponent()
        {
            Text = "Dịch vụ";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1100, 650);
            Font = new Font("Segoe UI", 10F);
            tab = new TabControl { Dock = DockStyle.Fill };
            p1 = new TabPage("Danh mục dịch vụ");
            p2 = new TabPage("Sử dụng dịch vụ");
            txtMaDV = new TextBox
            {
                Left = 140,
                Top = 20,
                Width = 160,
            };
            txtTenDV = new TextBox
            {
                Left = 140,
                Top = 60,
                Width = 260,
            };
            txtDVT = new TextBox
            {
                Left = 140,
                Top = 100,
                Width = 160,
            };
            numGiaDV = new NumericUpDown
            {
                Left = 550,
                Top = 20,
                Width = 200,
                Maximum = 1000000000,
                ThousandsSeparator = true,
            };
            chkDung = new CheckBox
            {
                Left = 550,
                Top = 65,
                Text = "Đang sử dụng",
                Checked = true,
            };
            btnThemDV = B("Thêm", 800, 20, btnThemDV_Click);
            btnSuaDV = B("Sửa", 800, 60, btnSuaDV_Click);
            btnXoaDV = B("Xóa", 920, 20, btnXoaDV_Click);
            dgvDV = new DataGridView
            {
                Left = 20,
                Top = 170,
                Width = 1030,
                Height = 400,
            };
            dgvDV.CellClick += dgvDV_CellClick;
            p1.Controls.AddRange(
                new Control[]
                {
                    L("Mã DV", 20, 24),
                    txtMaDV,
                    L("Tên DV", 20, 64),
                    txtTenDV,
                    L("Đơn vị tính", 20, 104),
                    txtDVT,
                    L("Đơn giá", 430, 24),
                    numGiaDV,
                    chkDung,
                    btnThemDV,
                    btnSuaDV,
                    btnXoaDV,
                    dgvDV,
                }
            );
            txtMaSD = new TextBox
            {
                Left = 140,
                Top = 20,
                Width = 160,
            };
            cboHD = new ComboBox
            {
                Left = 140,
                Top = 60,
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            cboVP = new ComboBox
            {
                Left = 140,
                Top = 100,
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            cboDV = new ComboBox
            {
                Left = 500,
                Top = 20,
                Width = 260,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            dtThang = new DateTimePicker
            {
                Left = 500,
                Top = 60,
                Width = 170,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "MM/yyyy",
                ShowUpDown = true,
            };
            numSL = new NumericUpDown
            {
                Left = 500,
                Top = 100,
                Width = 160,
                Maximum = 1000000,
                DecimalPlaces = 2,
            };
            numGiaSD = new NumericUpDown
            {
                Left = 850,
                Top = 20,
                Width = 180,
                Maximum = 1000000000,
                ThousandsSeparator = true,
            };
            btnGhiNhan = B("Ghi nhận", 850, 70, btnGhiNhan_Click);
            btnXoaSD = B("Xóa dòng", 850, 110, btnXoaSD_Click);
            dgvSD = new DataGridView
            {
                Left = 20,
                Top = 180,
                Width = 1030,
                Height = 390,
            };
            p2.Controls.AddRange(
                new Control[]
                {
                    L("Mã sử dụng", 20, 24),
                    txtMaSD,
                    L("Hợp đồng", 20, 64),
                    cboHD,
                    L("Văn phòng", 20, 104),
                    cboVP,
                    L("Dịch vụ", 380, 24),
                    cboDV,
                    L("Tháng", 380, 64),
                    dtThang,
                    L("Số lượng", 380, 104),
                    numSL,
                    L("Đơn giá", 730, 24),
                    numGiaSD,
                    btnGhiNhan,
                    btnXoaSD,
                    dgvSD,
                }
            );
            tab.Controls.Add(p1);
            tab.Controls.Add(p2);
            Controls.Add(tab);
        }
    }
}
