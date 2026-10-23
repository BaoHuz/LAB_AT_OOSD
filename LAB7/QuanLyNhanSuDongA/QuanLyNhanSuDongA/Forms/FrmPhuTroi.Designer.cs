namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmPhuTroi
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.txtSoPhieuPT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 15), Size = new System.Drawing.Size(100, 22) };
            this.dtpNgayPT = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(260, 15), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(100, 22) };
            this.numSoGioPT = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(450, 15), DecimalPlaces = 1, Value = 2, Size = new System.Drawing.Size(80, 22) };
            this.cboHinhThucPT = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(620, 15), Size = new System.Drawing.Size(110, 22) };
            this.txtNguoiLapPT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(80, 48), Size = new System.Drawing.Size(100, 22) };
            this.txtDanhSachNVPT = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(300, 48), Size = new System.Drawing.Size(280, 22) };
            this.btnLapPhieuPT = new System.Windows.Forms.Button { Text = "Lập Phụ Trội (x1.5)", Location = new System.Drawing.Point(600, 46), Size = new System.Drawing.Size(130, 25) };
            this.btnLapPhieuPT.Click += new System.EventHandler(this.btnLapPhieuPT_Click);

            this.dgvPhuTroi = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 85), Size = new System.Drawing.Size(715, 230) };
            this.btnDong = new System.Windows.Forms.Button { Text = "Đóng", Location = new System.Drawing.Point(625, 330), Size = new System.Drawing.Size(105, 30) };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmPhuTroi_Load);
            this.ClientSize = new System.Drawing.Size(745, 375);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số phiếu:", Location = new System.Drawing.Point(15, 18) }, txtSoPhieuPT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Ngày làm:", Location = new System.Drawing.Point(195, 18) }, dtpNgayPT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Số giờ PT:", Location = new System.Drawing.Point(380, 18) }, numSoGioPT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Hình thức:", Location = new System.Drawing.Point(550, 18) }, cboHinhThucPT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Người lập:", Location = new System.Drawing.Point(15, 51) }, txtNguoiLapPT,
                new System.Windows.Forms.Label { AutoSize = true, Text = "DS NV:", Location = new System.Drawing.Point(195, 51) }, txtDanhSachNVPT,
                btnLapPhieuPT, dgvPhuTroi, btnDong
            });
            this.Text = "Phiếu phụ trội";
            ((System.ComponentModel.ISupportInitialize)(this.numSoGioPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTroi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.TextBox txtSoPhieuPT, txtNguoiLapPT, txtDanhSachNVPT;
        private System.Windows.Forms.DateTimePicker dtpNgayPT;
        private System.Windows.Forms.NumericUpDown numSoGioPT;
        private System.Windows.Forms.ComboBox cboHinhThucPT;
        private System.Windows.Forms.Button btnLapPhieuPT, btnDong;
        private System.Windows.Forms.DataGridView dgvPhuTroi;
    }
}