namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmKeHoachChamCong
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabKH = new System.Windows.Forms.TabPage { Text = "Kế hoạch làm việc tuần" };
            this.tabCC = new System.Windows.Forms.TabPage { Text = "Chấm công hàng ngày" };

            this.txtMaKH = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(70, 12), Size = new System.Drawing.Size(90, 22) };
            this.cboPhongBan = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(240, 12), Size = new System.Drawing.Size(110, 22) };
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(420, 12), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(95, 22) };
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(580, 12), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(95, 22) };
            this.txtNguoiLap = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(70, 45), Size = new System.Drawing.Size(90, 22) };
            this.btnTaoKH = new System.Windows.Forms.Button { Text = "Tạo Kế Hoạch", Location = new System.Drawing.Point(240, 43), Size = new System.Drawing.Size(110, 25) };
            this.btnTaoKH.Click += new System.EventHandler(this.btnTaoKH_Click);
            this.dgvKeHoach = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 75), Size = new System.Drawing.Size(705, 130) };

            this.grpPC = new System.Windows.Forms.GroupBox { Text = "Phân công chi tiết ca làm việc", Location = new System.Drawing.Point(15, 212), Size = new System.Drawing.Size(705, 65) };
            this.txtMaKHPC = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(65, 25), Size = new System.Drawing.Size(70, 22) };
            this.numSTT = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(180, 25), Minimum = 1, Value = 1, Size = new System.Drawing.Size(45, 22) };
            this.txtMaNVPC = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(280, 25), Size = new System.Drawing.Size(70, 22) };
            this.dtpNgayLamPC = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(420, 25), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(95, 22) };
            this.cboCa = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(550, 25), Size = new System.Drawing.Size(80, 22) };
            this.btnPhanCong = new System.Windows.Forms.Button { Text = "Thêm", Location = new System.Drawing.Point(638, 23), Size = new System.Drawing.Size(55, 25) };
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);

            this.grpPC.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã KH:", Location = new System.Drawing.Point(10, 28) }, txtMaKHPC,
                new System.Windows.Forms.Label { AutoSize = true, Text = "STT:", Location = new System.Drawing.Point(145, 28) }, numSTT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(235, 28) }, txtMaNVPC,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Ngày:", Location = new System.Drawing.Point(360, 28) }, dtpNgayLamPC,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Ca:", Location = new System.Drawing.Point(520, 28) }, cboCa, btnPhanCong
            });

            this.tabKH.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã KH:", Location = new System.Drawing.Point(15, 15) }, txtMaKH,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Phòng ban:", Location = new System.Drawing.Point(170, 15) }, cboPhongBan,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Từ ngày:", Location = new System.Drawing.Point(360, 15) }, dtpTuNgay,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Đến ngày:", Location = new System.Drawing.Point(520, 15) }, dtpDenNgay,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Người lập:", Location = new System.Drawing.Point(15, 48) }, txtNguoiLap,
                btnTaoKH, dgvKeHoach, grpPC
            });

            this.txtMaCC = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 12), Size = new System.Drawing.Size(100, 22) };
            this.txtMaNVCC = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(240, 12), Size = new System.Drawing.Size(100, 22) };
            this.dtpNgayCC = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(430, 12), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(100, 22) };
            this.cboCaCC = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(600, 12), Size = new System.Drawing.Size(100, 22) };
            this.numSoGioLam = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(80, 45), DecimalPlaces = 1, Value = 8, Size = new System.Drawing.Size(80, 22) };
            this.cboTrangThaiCC = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(240, 45), Size = new System.Drawing.Size(100, 22) };
            this.txtNguoiCham = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(430, 45), Size = new System.Drawing.Size(100, 22) };
            this.btnChamCong = new System.Windows.Forms.Button { Text = "Ghi Chấm Công", Location = new System.Drawing.Point(580, 43), Size = new System.Drawing.Size(120, 25) };
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            this.dgvChamCong = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 80), Size = new System.Drawing.Size(705, 195) };

            this.tabCC.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã CC:", Location = new System.Drawing.Point(15, 15) }, txtMaCC,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(190, 15) }, txtMaNVCC,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Ngày:", Location = new System.Drawing.Point(360, 15) }, dtpNgayCC,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Ca:", Location = new System.Drawing.Point(550, 15) }, cboCaCC,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số giờ:", Location = new System.Drawing.Point(15, 48) }, numSoGioLam,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Trạng thái:", Location = new System.Drawing.Point(170, 48) }, cboTrangThaiCC,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Người chấm:", Location = new System.Drawing.Point(350, 48) }, txtNguoiCham, btnChamCong, dgvChamCong
            });

            this.tabMain.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabKH, this.tabCC });
            this.tabMain.Location = new System.Drawing.Point(15, 15);
            this.tabMain.Size = new System.Drawing.Size(740, 315);

            this.btnDong = new System.Windows.Forms.Button { Text = "Đóng", Location = new System.Drawing.Point(650, 340), Size = new System.Drawing.Size(105, 30) };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmKeHoachChamCong_Load);
            this.ClientSize = new System.Drawing.Size(770, 380);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabMain, this.btnDong });
            this.Text = "Kế hoạch – chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoGioLam)).EndInit();
            this.grpPC.ResumeLayout(false);
            this.grpPC.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKH, tabCC;
        private System.Windows.Forms.TextBox txtMaKH, txtNguoiLap, txtMaKHPC, txtMaNVPC, txtMaCC, txtMaNVCC, txtNguoiCham;
        private System.Windows.Forms.ComboBox cboPhongBan, cboCa, cboCaCC, cboTrangThaiCC;
        private System.Windows.Forms.DateTimePicker dtpTuNgay, dtpDenNgay, dtpNgayLamPC, dtpNgayCC;
        private System.Windows.Forms.Button btnTaoKH, btnPhanCong, btnChamCong, btnDong;
        private System.Windows.Forms.DataGridView dgvKeHoach, dgvChamCong;
        private System.Windows.Forms.GroupBox grpPC;
        private System.Windows.Forms.NumericUpDown numSTT, numSoGioLam;
    }
}