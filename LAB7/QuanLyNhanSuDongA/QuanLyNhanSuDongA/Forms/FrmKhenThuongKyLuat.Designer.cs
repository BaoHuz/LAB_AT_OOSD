namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmKhenThuongKyLuat
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabKT = new System.Windows.Forms.TabPage { Text = "Khen thưởng" };
            this.tabKL = new System.Windows.Forms.TabPage { Text = "Kỷ luật" };

            this.txtSoQDKT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 12), Size = new System.Drawing.Size(100, 22) };
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(240, 12), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(100, 22) };
            this.txtMaNVKT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(410, 12), Size = new System.Drawing.Size(90, 22) };
            this.txtMaPBKT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(580, 12), Size = new System.Drawing.Size(90, 22) };
            this.txtLoaiKT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 45), Size = new System.Drawing.Size(100, 22) };
            this.numSoTienKT = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(240, 45), Maximum = 100000000, Size = new System.Drawing.Size(100, 22) };
            this.txtNguoiKyKT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(410, 45), Size = new System.Drawing.Size(90, 22) };
            this.txtNoiDungKT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 78), Size = new System.Drawing.Size(420, 22) };
            this.btnLapKT = new System.Windows.Forms.Button { Text = "QĐ Khen Thưởng", Location = new System.Drawing.Point(530, 76), Size = new System.Drawing.Size(140, 25) };
            this.btnLapKT.Click += new System.EventHandler(this.btnLapKT_Click);
            this.dgvKT = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 110), Size = new System.Drawing.Size(700, 190) };

            this.tabKT.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số QĐ:", Location = new System.Drawing.Point(15, 15) }, txtSoQDKT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Ngày QĐ:", Location = new System.Drawing.Point(185, 15) }, dtpNgayKT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(350, 15) }, txtMaNVKT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã PB:", Location = new System.Drawing.Point(520, 15) }, txtMaPBKT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Loại KT:", Location = new System.Drawing.Point(15, 48) }, txtLoaiKT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số tiền:", Location = new System.Drawing.Point(185, 48) }, numSoTienKT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Người ký:", Location = new System.Drawing.Point(350, 48) }, txtNguoiKyKT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Nội dung:", Location = new System.Drawing.Point(15, 81) }, txtNoiDungKT, btnLapKT, dgvKT
            });

            this.txtSoQDKL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 12), Size = new System.Drawing.Size(100, 22) };
            this.dtpNgayKL = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(240, 12), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(100, 22) };
            this.txtMaNVKL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(410, 12), Size = new System.Drawing.Size(90, 22) };
            this.txtMaPBKL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(580, 12), Size = new System.Drawing.Size(90, 22) };
            this.txtHinhThucKL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 45), Size = new System.Drawing.Size(100, 22) };
            this.numSoTienKL = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(240, 45), Maximum = 100000000, Size = new System.Drawing.Size(100, 22) };
            this.cboCachThu = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(410, 45), Size = new System.Drawing.Size(90, 22) };
            this.txtNguoiKyKL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(580, 45), Size = new System.Drawing.Size(90, 22) };
            this.txtNoiDungKL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 78), Size = new System.Drawing.Size(420, 22) };
            this.btnLapKL = new System.Windows.Forms.Button { Text = "QĐ Kỷ Luật", Location = new System.Drawing.Point(530, 76), Size = new System.Drawing.Size(140, 25) };
            this.btnLapKL.Click += new System.EventHandler(this.btnLapKL_Click);
            this.dgvKL = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 110), Size = new System.Drawing.Size(700, 190) };

            this.tabKL.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số QĐ:", Location = new System.Drawing.Point(15, 15) }, txtSoQDKL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Ngày QĐ:", Location = new System.Drawing.Point(185, 15) }, dtpNgayKL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(350, 15) }, txtMaNVKL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã PB:", Location = new System.Drawing.Point(520, 15) }, txtMaPBKL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Hình thức:", Location = new System.Drawing.Point(15, 48) }, txtHinhThucKL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Tiền phạt:", Location = new System.Drawing.Point(185, 48) }, numSoTienKL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Cách thu:", Location = new System.Drawing.Point(350, 48) }, cboCachThu,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Người ký:", Location = new System.Drawing.Point(520, 48) }, txtNguoiKyKL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Nội dung:", Location = new System.Drawing.Point(15, 81) }, txtNoiDungKL, btnLapKL, dgvKL
            });

            this.tabMain.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabKT, this.tabKL });
            this.tabMain.Location = new System.Drawing.Point(15, 15);
            this.tabMain.Size = new System.Drawing.Size(740, 340);

            this.btnDong = new System.Windows.Forms.Button { Text = "Đóng", Location = new System.Drawing.Point(650, 365), Size = new System.Drawing.Size(105, 30) };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmKhenThuongKyLuat_Load);
            this.ClientSize = new System.Drawing.Size(770, 405);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabMain, this.btnDong });
            this.Text = "Khen thưởng – kỷ luật";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKT, tabKL;
        private System.Windows.Forms.TextBox txtSoQDKT, txtMaNVKT, txtMaPBKT, txtLoaiKT, txtNguoiKyKT, txtNoiDungKT;
        private System.Windows.Forms.TextBox txtSoQDKL, txtMaNVKL, txtMaPBKL, txtHinhThucKL, txtNguoiKyKL, txtNoiDungKL;
        private System.Windows.Forms.DateTimePicker dtpNgayKT, dtpNgayKL;
        private System.Windows.Forms.NumericUpDown numSoTienKT, numSoTienKL;
        private System.Windows.Forms.ComboBox cboCachThu;
        private System.Windows.Forms.Button btnLapKT, btnLapKL, btnDong;
        private System.Windows.Forms.DataGridView dgvKT, dgvKL;
    }
}