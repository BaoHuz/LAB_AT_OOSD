namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmBangLuong
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.numThang = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(70, 15), Minimum = 1, Maximum = 12, Value = 10, Size = new System.Drawing.Size(60, 22) };
            this.numNam = new System.Windows.Forms.NumericUpDown { Location = new System.Drawing.Point(180, 15), Minimum = 2000, Maximum = 2100, Value = 2026, Size = new System.Drawing.Size(80, 22) };
            this.txtNguoiLap = new System.Windows.Forms.TextBox { Location = new System.Drawing.Point(340, 15), Size = new System.Drawing.Size(120, 22) };
            this.btnTinhLuong = new System.Windows.Forms.Button { Text = "Tính Bảng Lương", Location = new System.Drawing.Point(480, 13), Size = new System.Drawing.Size(120, 25) };
            this.btnTinhLuong.Click += new System.EventHandler(this.btnTinhLuong_Click);

            this.dgvBangLuong = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 55), Size = new System.Drawing.Size(740, 120) };
            this.dgvBangLuong.SelectionChanged += new System.EventHandler(this.dgvBangLuong_SelectionChanged);

            this.dgvChiTiet = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Location = new System.Drawing.Point(15, 190), Size = new System.Drawing.Size(740, 220) };

            this.btnDong = new System.Windows.Forms.Button { Text = "Đóng", Location = new System.Drawing.Point(650, 420), Size = new System.Drawing.Size(105, 30) };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmBangLuong_Load);
            this.ClientSize = new System.Drawing.Size(770, 460);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { AutoSize = true, Text = "Tháng:", Location = new System.Drawing.Point(15, 18) }, numThang,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Năm:", Location = new System.Drawing.Point(140, 18) }, numNam,
                new System.Windows.Forms.Label { AutoSize = true, Text = "Người lập:", Location = new System.Drawing.Point(270, 18) }, txtNguoiLap,
                btnTinhLuong, dgvBangLuong, dgvChiTiet, btnDong
            });
            this.Text = "Bảng lương – thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.NumericUpDown numThang, numNam;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.Button btnTinhLuong, btnDong;
        private System.Windows.Forms.DataGridView dgvBangLuong, dgvChiTiet;
    }
}