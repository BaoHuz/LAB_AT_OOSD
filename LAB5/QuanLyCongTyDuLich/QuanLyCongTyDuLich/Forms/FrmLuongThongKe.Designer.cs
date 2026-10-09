namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmLuongThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabTK;
        private System.Windows.Forms.TabPage tabLuong;
        private System.Windows.Forms.TabPage tabTongHop;

        // Luong controls
        private System.Windows.Forms.NumericUpDown numThang;
        private System.Windows.Forms.NumericUpDown numNam;
        private System.Windows.Forms.Button btnLuong;
        private System.Windows.Forms.DataGridView dgvLuong;

        // TongHop controls
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTongHop;
        private System.Windows.Forms.DataGridView dgvTongHop;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabTK = new System.Windows.Forms.TabControl();
            this.tabLuong = new System.Windows.Forms.TabPage();
            this.tabTongHop = new System.Windows.Forms.TabPage();

            this.numThang = new System.Windows.Forms.NumericUpDown();
            this.numNam = new System.Windows.Forms.NumericUpDown();
            this.btnLuong = new System.Windows.Forms.Button();
            this.dgvLuong = new System.Windows.Forms.DataGridView();

            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTongHop = new System.Windows.Forms.Button();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabTK.SuspendLayout();
            this.tabLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).BeginInit();

            this.tabTongHop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.SuspendLayout();

            // TabControl
            this.tabTK.Controls.Add(this.tabLuong);
            this.tabTK.Controls.Add(this.tabTongHop);
            this.tabTK.Location = new System.Drawing.Point(12, 12);
            this.tabTK.Size = new System.Drawing.Size(860, 450);

            // Tab Luong
            this.tabLuong.Text = "Lương hướng dẫn viên";
            this.numThang.Location = new System.Drawing.Point(60, 15); this.numThang.Size = new System.Drawing.Size(50, 23); this.numThang.Minimum = 1; this.numThang.Maximum = 12;
            this.numNam.Location = new System.Drawing.Point(160, 15); this.numNam.Size = new System.Drawing.Size(80, 23); this.numNam.Minimum = 2000; this.numNam.Maximum = 2100;

            this.btnLuong.Location = new System.Drawing.Point(260, 10); this.btnLuong.Size = new System.Drawing.Size(100, 30); this.btnLuong.Text = "Tính lương";
            this.btnLuong.Click += new System.EventHandler(this.btnLuong_Click);

            this.dgvLuong.Location = new System.Drawing.Point(10, 50);
            this.dgvLuong.Size = new System.Drawing.Size(830, 350);
            this.dgvLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.tabLuong.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Tháng:", Location = new System.Drawing.Point(10, 18) }, this.numThang,
                new System.Windows.Forms.Label { Text = "Năm:", Location = new System.Drawing.Point(120, 18) }, this.numNam,
                this.btnLuong, this.dgvLuong
            });

            // Tab TongHop
            this.tabTongHop.Text = "Thống kê tổng hợp";
            this.dtTu.Location = new System.Drawing.Point(70, 15); this.dtTu.Size = new System.Drawing.Size(120, 23); this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(250, 15); this.dtDen.Size = new System.Drawing.Size(120, 23); this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnTongHop.Location = new System.Drawing.Point(390, 10); this.btnTongHop.Size = new System.Drawing.Size(100, 30); this.btnTongHop.Text = "Thống kê";
            this.btnTongHop.Click += new System.EventHandler(this.btnTongHop_Click);

            this.dgvTongHop.Location = new System.Drawing.Point(10, 50);
            this.dgvTongHop.Size = new System.Drawing.Size(830, 350);
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.tabTongHop.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Từ ngày:", Location = new System.Drawing.Point(10, 18) }, this.dtTu,
                new System.Windows.Forms.Label { Text = "Đến ngày:", Location = new System.Drawing.Point(200, 18) }, this.dtDen,
                this.btnTongHop, this.dgvTongHop
            });

            // Form
            this.btnDong.Location = new System.Drawing.Point(760, 470); this.btnDong.Size = new System.Drawing.Size(110, 30); this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(884, 510);
            this.Controls.Add(this.tabTK);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLuongThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lương hướng dẫn viên - thống kê";
            this.Load += new System.EventHandler(this.FrmLuongThongKe_Load);
            this.tabTK.ResumeLayout(false);
            this.tabLuong.ResumeLayout(false);
            this.tabLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuong)).EndInit();
            this.tabTongHop.ResumeLayout(false);
            this.tabTongHop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            this.ResumeLayout(false);
        }
    }
}