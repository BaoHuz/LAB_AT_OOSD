namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmTuyenDung
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblSoQD = new System.Windows.Forms.Label { AutoSize = true, Text = "Số QĐ Tuyển dụng:", Location = new System.Drawing.Point(20, 20) };
            this.txtSoQD = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(140, 17), Size = new System.Drawing.Size(150, 22) };

            this.lblMaNV = new System.Windows.Forms.Label { AutoSize = true, Text = "Mã NV:", Location = new System.Drawing.Point(310, 20) };
            this.txtMaNV = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(370, 17), Size = new System.Drawing.Size(120, 22) };

            this.lblHoTen = new System.Windows.Forms.Label { AutoSize = true, Text = "Họ tên NV:", Location = new System.Drawing.Point(510, 20) };
            this.txtHoTen = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(580, 17), Size = new System.Drawing.Size(180, 22) };

            this.lblPhongBan = new System.Windows.Forms.Label { AutoSize = true, Text = "Phòng ban:", Location = new System.Drawing.Point(20, 55) };
            this.cboPhongBan = new System.Windows.Forms.ComboBox { Location = new System.Drawing.Point(140, 52), Size = new System.Drawing.Size(150, 22) };

            this.lblTuNgay = new System.Windows.Forms.Label { AutoSize = true, Text = "Từ ngày:", Location = new System.Drawing.Point(310, 55) };
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(370, 52), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(120, 22) };

            this.lblDenNgay = new System.Windows.Forms.Label { AutoSize = true, Text = "Đến ngày:", Location = new System.Drawing.Point(510, 55) };
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker { Location = new System.Drawing.Point(580, 52), Format = System.Windows.Forms.DateTimePickerFormat.Custom, CustomFormat = "dd/MM/yyyy", Size = new System.Drawing.Size(120, 22) };

            this.lblLuong = new System.Windows.Forms.Label { AutoSize = true, Text = "Lương thử việc:", Location = new System.Drawing.Point(20, 90) };
            this.numLuongThuViec = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(140, 88), Maximum = 100000000 };

            this.lblNguoiKy = new System.Windows.Forms.Label { AutoSize = true, Text = "Người ký:", Location = new System.Drawing.Point(310, 90) };
            this.txtNguoiKy = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(370, 88), Size = new System.Drawing.Size(120, 22) };

            this.lblNoiDung = new System.Windows.Forms.Label { AutoSize = true, Text = "Nội dung:", Location = new System.Drawing.Point(20, 125) };
            this.txtNoiDung = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(140, 122), Size = new System.Drawing.Size(620, 22) };

            this.btnLap = new System.Windows.Forms.Button { Text = "Lập quyết định", Size = new System.Drawing.Size(120, 25), Location = new System.Drawing.Point(550, 155) };
            this.btnLap.Click += new System.EventHandler(this.btnLap_Click);

            this.btnDong = new System.Windows.Forms.Button { Text = "Đóng", Location = new System.Drawing.Point(680, 155) };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.dgvDanhSach = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(20, 190), Size = new System.Drawing.Size(740, 230) };

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmTuyenDung_Load);
            this.ClientSize = new System.Drawing.Size(780, 440);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblSoQD, this.txtSoQD, this.lblMaNV, this.txtMaNV, this.lblHoTen, this.txtHoTen,
                this.lblPhongBan, this.cboPhongBan, this.lblTuNgay, this.dtpTuNgay, this.lblDenNgay, this.dtpDenNgay,
                this.lblLuong, this.numLuongThuViec, this.lblNguoiKy, this.txtNguoiKy, this.lblNoiDung, this.txtNoiDung,
                this.btnLap, this.btnDong, this.dgvDanhSach
            });
            this.Text = "Tuyển dụng & Thử việc nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.numLuongThuViec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblSoQD, lblMaNV, lblHoTen, lblPhongBan, lblTuNgay, lblDenNgay, lblLuong, lblNoiDung, lblNguoiKy;
        private System.Windows.Forms.TextBox txtSoQD, txtMaNV, txtHoTen, txtNoiDung, txtNguoiKy;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.DateTimePicker dtpTuNgay, dtpDenNgay;
        private System.Windows.Forms.NumericUpDown numLuongThuViec;
        private System.Windows.Forms.Button btnLap, btnDong;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}