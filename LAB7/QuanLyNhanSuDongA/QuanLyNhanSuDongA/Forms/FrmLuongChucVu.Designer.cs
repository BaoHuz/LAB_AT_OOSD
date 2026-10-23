namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmLuongChucVu
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabLuong = new System.Windows.Forms.TabPage { Text = "Quyết định Lương" };
            this.tabChucVu = new System.Windows.Forms.TabPage { Text = "Quyết định Chức vụ" };

            this.txtSoQDL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 12), Size = new System.Drawing.Size(100, 22) };
            this.txtMaNVL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(240, 12), Size = new System.Drawing.Size(100, 22) };
            this.dtpHieuLucL = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(430, 12), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(110, 22) };
            this.numLuongCB = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(80, 45), Maximum = 100000000, Size = new System.Drawing.Size(100, 22) };
            this.numPCLuong = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(250, 45), Maximum = 50000000, Size = new System.Drawing.Size(90, 22) };
            this.numPCDocHai = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(430, 45), Maximum = 50000000, Size = new System.Drawing.Size(100, 22) };
            this.txtNguoiKyL = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(610, 12), Size = new System.Drawing.Size(90, 22) };
            this.btnLapQDLuong = new System.Windows.Forms.Button { Text = "Lập QĐ Lương", Location = new System.Drawing.Point(600, 43), Size = new System.Drawing.Size(100, 25) };
            this.btnLapQDLuong.Click += new System.EventHandler(this.btnLapQDLuong_Click);
            this.dgvLuong = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 80), Size = new System.Drawing.Size(700, 220) };

            this.tabLuong.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số QĐ:", Location = new System.Drawing.Point(15, 15) }, txtSoQDL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(190, 15) }, txtMaNVL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Hiệu lực từ:", Location = new System.Drawing.Point(350, 15) }, dtpHieuLucL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Người ký:", Location = new System.Drawing.Point(550, 15) }, txtNguoiKyL,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Lương CB:", Location = new System.Drawing.Point(15, 48) }, numLuongCB,
                new System.Windows.Forms.Label { AutoSize = true, Text = "PC Lương:", Location = new System.Drawing.Point(190, 48) }, numPCLuong,
                new System.Windows.Forms.Label { AutoSize = true, Text = "PC Độc hại:", Location = new System.Drawing.Point(350, 48) }, numPCDocHai, btnLapQDLuong, dgvLuong
            });

            this.txtSoQDCV = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 12), Size = new System.Drawing.Size(100, 22) };
            this.txtMaNVCV = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(240, 12), Size = new System.Drawing.Size(100, 22) };
            this.cboChucVu = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(430, 12), Size = new System.Drawing.Size(120, 22) };
            this.numPCCV = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(80, 45), Maximum = 50000000, Size = new System.Drawing.Size(100, 22) };
            this.dtpHieuLucCV = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(240, 45), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(100, 22) };
            this.txtNguoiKyCV = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(430, 45), Size = new System.Drawing.Size(120, 22) };
            this.btnLapQDCV = new System.Windows.Forms.Button { Text = "Lập QĐ Chức vụ", Location = new System.Drawing.Point(580, 43), Size = new System.Drawing.Size(120, 25) };
            this.btnLapQDCV.Click += new System.EventHandler(this.btnLapQDCV_Click);
            this.dgvChucVu = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 80), Size = new System.Drawing.Size(700, 220) };

            this.tabChucVu.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số QĐ:", Location = new System.Drawing.Point(15, 15) }, txtSoQDCV,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(190, 15) }, txtMaNVCV,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Chức vụ:", Location = new System.Drawing.Point(350, 15) }, cboChucVu,
                new System.Windows.Forms.Label { AutoSize = true, Text = "PC CV:", Location = new System.Drawing.Point(15, 48) }, numPCCV,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Hiệu lực:", Location = new System.Drawing.Point(190, 48) }, dtpHieuLucCV,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Người ký:", Location = new System.Drawing.Point(350, 48) }, txtNguoiKyCV, btnLapQDCV, dgvChucVu
            });

            this.tabMain.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabLuong, this.tabChucVu });
            this.tabMain.Location = new System.Drawing.Point(15, 15);
            this.tabMain.Size = new System.Drawing.Size(740, 340);

            this.btnDong = new System.Windows.Forms.Button { Text = "Đóng", Location = new System.Drawing.Point(650, 365), Size = new System.Drawing.Size(105, 30) };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmLuongChucVu_Load);
            this.ClientSize = new System.Drawing.Size(770, 405);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabMain, this.btnDong });
            this.Text = "Quyết định lương – chức vụ";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabLuong, tabChucVu;
        private System.Windows.Forms.TextBox txtSoQDL, txtMaNVL, txtNguoiKyL, txtSoQDCV, txtMaNVCV, txtNguoiKyCV;
        private System.Windows.Forms.DateTimePicker dtpHieuLucL, dtpHieuLucCV;
        private System.Windows.Forms.NumericUpDown numLuongCB, numPCLuong, numPCDocHai, numPCCV;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Button btnLapQDLuong, btnLapQDCV, btnDong;
        private System.Windows.Forms.DataGridView dgvLuong, dgvChucVu;
    }
}