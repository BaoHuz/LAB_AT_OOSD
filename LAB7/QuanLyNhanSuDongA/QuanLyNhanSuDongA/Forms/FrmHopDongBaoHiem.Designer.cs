namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmHopDongBaoHiem
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabHopDong = new System.Windows.Forms.TabPage { Text = "Hợp đồng lao động" };
            this.tabBaoHiem = new System.Windows.Forms.TabPage { Text = "Bảo hiểm" };

            this.txtSoHD = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 12), Size = new System.Drawing.Size(120, 22) };
            this.txtMaNV = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(280, 12), Size = new System.Drawing.Size(100, 22) };
            this.cboLoaiHD = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(460, 12), Size = new System.Drawing.Size(120, 22) };
            this.dtpNgayKy = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(80, 45), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(120, 22) };
            this.dtpTuNgayHD = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(280, 45), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(120, 22) };
            this.dtpDenNgayHD = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(460, 45), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(120, 22) };
            this.btnKyHD = new System.Windows.Forms.Button { Text = "Ký Hợp Đồng", Location = new System.Drawing.Point(600, 43), Size = new System.Drawing.Size(110, 25) };
            this.btnKyHD.Click += new System.EventHandler(this.btnKyHD_Click);
            this.dgvHopDong = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 80), Size = new System.Drawing.Size(700, 230) };

            this.tabHopDong.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số HĐ:", Location = new System.Drawing.Point(15, 15) }, txtSoHD,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(220, 15) }, txtMaNV,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Loại HĐ:", Location = new System.Drawing.Point(400, 15) }, cboLoaiHD,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Ngày ký:", Location = new System.Drawing.Point(15, 48) }, dtpNgayKy,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Từ ngày:", Location = new System.Drawing.Point(220, 48) }, dtpTuNgayHD,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Đến ngày:", Location = new System.Drawing.Point(400, 48) }, dtpDenNgayHD, btnKyHD, dgvHopDong
            });

            this.txtMaHSBH = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 12), Size = new System.Drawing.Size(100, 22) };
            this.txtMaNVBH = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(260, 12), Size = new System.Drawing.Size(100, 22) };
            this.txtSoHDBH = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(440, 12), Size = new System.Drawing.Size(100, 22) };
            this.cboLoaiBH = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(610, 12), Size = new System.Drawing.Size(90, 22) };
            this.txtSoTheBH = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 45), Size = new System.Drawing.Size(100, 22) };
            this.numTyLeNV = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(260, 45), DecimalPlaces = 3, Increment = 0.005m, Value = 0.015m, Size = new System.Drawing.Size(70, 22) };
            this.numTyLeCT = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(440, 45), DecimalPlaces = 3, Increment = 0.005m, Value = 0.030m, Size = new System.Drawing.Size(70, 22) };
            this.dtpTuNgayBH = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(580, 45), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(120, 22) };
            this.btnLuuBH = new System.Windows.Forms.Button { Text = "Lưu Hồ Sơ BH", Location = new System.Drawing.Point(580, 75), Size = new System.Drawing.Size(120, 25) };
            this.btnLuuBH.Click += new System.EventHandler(this.btnLuuBH_Click);
            this.dgvBaoHiem = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 110), Size = new System.Drawing.Size(700, 200) };

            this.tabBaoHiem.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã HSBH:", Location = new System.Drawing.Point(15, 15) }, txtMaHSBH,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(200, 15) }, txtMaNVBH,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số HĐ:", Location = new System.Drawing.Point(380, 15) }, txtSoHDBH,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Loại BH:", Location = new System.Drawing.Point(550, 15) }, cboLoaiBH,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số sổ/thẻ:", Location = new System.Drawing.Point(15, 48) }, txtSoTheBH,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Tỷ lệ NV:", Location = new System.Drawing.Point(200, 48) }, numTyLeNV,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Tỷ lệ Cty:", Location = new System.Drawing.Point(380, 48) }, numTyLeCT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Từ ngày:", Location = new System.Drawing.Point(520, 48) }, dtpTuNgayBH, btnLuuBH, dgvBaoHiem
            });

            this.tabMain.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabHopDong, this.tabBaoHiem });
            this.tabMain.Location = new System.Drawing.Point(15, 15);
            this.tabMain.Size = new System.Drawing.Size(740, 350);

            this.btnDong = new System.Windows.Forms.Button { Text = "Đóng", Location = new System.Drawing.Point(650, 375), Size = new System.Drawing.Size(105, 30) };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmHopDongBaoHiem_Load);
            this.ClientSize = new System.Drawing.Size(770, 415);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabMain, this.btnDong });
            this.Text = "Hợp đồng – Bảo hiểm lao động";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabHopDong, tabBaoHiem;
        private System.Windows.Forms.TextBox txtSoHD, txtMaNV, txtMaHSBH, txtMaNVBH, txtSoHDBH, txtSoTheBH;
        private System.Windows.Forms.ComboBox cboLoaiHD, cboLoaiBH;
        private System.Windows.Forms.DateTimePicker dtpNgayKy, dtpTuNgayHD, dtpDenNgayHD, dtpTuNgayBH;
        private System.Windows.Forms.NumericUpDown numTyLeNV, numTyLeCT;
        private System.Windows.Forms.Button btnKyHD, btnLuuBH, btnDong;
        private System.Windows.Forms.DataGridView dgvHopDong, dgvBaoHiem;
    }
}