namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDangKyDoan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpDoan;
        private System.Windows.Forms.TextBox txtMaDoan;
        private System.Windows.Forms.TextBox txtTenCQ;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.TextBox txtDaiDien;

        private System.Windows.Forms.GroupBox grpDangKy;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.DateTimePicker dtDi;
        private System.Windows.Forms.NumericUpDown numNguoi;
        private System.Windows.Forms.TextBox txtDon;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.CheckBox chkBH;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.Label lblTong;

        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpDoan = new System.Windows.Forms.GroupBox();
            this.txtMaDoan = new System.Windows.Forms.TextBox();
            this.txtTenCQ = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.txtDaiDien = new System.Windows.Forms.TextBox();

            this.grpDangKy = new System.Windows.Forms.GroupBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.dtDi = new System.Windows.Forms.DateTimePicker();
            this.numNguoi = new System.Windows.Forms.NumericUpDown();
            this.txtDon = new System.Windows.Forms.TextBox();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.chkBH = new System.Windows.Forms.CheckBox();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();

            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            // grpDoan
            this.grpDoan.Text = "Thông tin đoàn khách";
            this.grpDoan.Location = new System.Drawing.Point(12, 12); this.grpDoan.Size = new System.Drawing.Size(460, 180);
            this.txtMaDoan.Location = new System.Drawing.Point(90, 20); this.txtMaDoan.Size = new System.Drawing.Size(120, 23);
            this.txtTenCQ.Location = new System.Drawing.Point(90, 50); this.txtTenCQ.Size = new System.Drawing.Size(350, 23);
            this.txtDiaChi.Location = new System.Drawing.Point(90, 80); this.txtDiaChi.Size = new System.Drawing.Size(350, 23);
            this.txtDT.Location = new System.Drawing.Point(90, 110); this.txtDT.Size = new System.Drawing.Size(150, 23);
            this.txtDaiDien.Location = new System.Drawing.Point(90, 140); this.txtDaiDien.Size = new System.Drawing.Size(200, 23);
            this.grpDoan.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Mã đoàn:", Location = new System.Drawing.Point(10, 23) }, this.txtMaDoan,
                new System.Windows.Forms.Label { Text = "Cơ quan/GD:", Location = new System.Drawing.Point(10, 53) }, this.txtTenCQ,
                new System.Windows.Forms.Label { Text = "Địa chỉ:", Location = new System.Drawing.Point(10, 83) }, this.txtDiaChi,
                new System.Windows.Forms.Label { Text = "Điện thoại:", Location = new System.Drawing.Point(10, 113) }, this.txtDT,
                new System.Windows.Forms.Label { Text = "Đại diện:", Location = new System.Drawing.Point(10, 143) }, this.txtDaiDien
            });

            // grpDangKy
            this.grpDangKy.Text = "Đăng ký tour";
            this.grpDangKy.Location = new System.Drawing.Point(480, 12); this.grpDangKy.Size = new System.Drawing.Size(490, 180);
            this.txtSo.Location = new System.Drawing.Point(80, 20); this.txtSo.Size = new System.Drawing.Size(120, 23);
            this.cboTour.Location = new System.Drawing.Point(250, 20); this.cboTour.Size = new System.Drawing.Size(220, 23); this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.TinhTong);

            this.dtDi.Location = new System.Drawing.Point(80, 50); this.dtDi.Size = new System.Drawing.Size(120, 23); this.dtDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDi.ValueChanged += new System.EventHandler(this.TinhTong);

            this.numNguoi.Location = new System.Drawing.Point(270, 50); this.numNguoi.Size = new System.Drawing.Size(60, 23); this.numNguoi.Value = 13; this.numNguoi.Minimum = 13;
            this.numNguoi.ValueChanged += new System.EventHandler(this.TinhTong);

            this.txtDon.Location = new System.Drawing.Point(80, 80); this.txtDon.Size = new System.Drawing.Size(390, 23);
            this.numCoc.Location = new System.Drawing.Point(80, 110); this.numCoc.Size = new System.Drawing.Size(140, 23); this.numCoc.Maximum = 1000000000;
            this.chkBH.Location = new System.Drawing.Point(240, 110); this.chkBH.Text = "Mua bảo hiểm";
            this.chkBH.CheckedChanged += new System.EventHandler(this.chkBH_CheckedChanged);

            this.lblKetThuc.Location = new System.Drawing.Point(80, 145); this.lblKetThuc.Size = new System.Drawing.Size(120, 20);
            this.lblTong.Location = new System.Drawing.Point(280, 145); this.lblTong.Size = new System.Drawing.Size(180, 20); this.lblTong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.grpDangKy.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Số phiếu:", Location = new System.Drawing.Point(10, 23) }, this.txtSo,
                new System.Windows.Forms.Label { Text = "Tour:", Location = new System.Drawing.Point(210, 23) }, this.cboTour,
                new System.Windows.Forms.Label { Text = "Ngày đi:", Location = new System.Drawing.Point(10, 53) }, this.dtDi,
                new System.Windows.Forms.Label { Text = "Số người:", Location = new System.Drawing.Point(210, 53) }, this.numNguoi,
                new System.Windows.Forms.Label { Text = "Nơi đón:", Location = new System.Drawing.Point(10, 83) }, this.txtDon,
                new System.Windows.Forms.Label { Text = "Tiền cọc:", Location = new System.Drawing.Point(10, 113) }, this.numCoc, this.chkBH,
                new System.Windows.Forms.Label { Text = "Kết thúc:", Location = new System.Drawing.Point(10, 145) }, this.lblKetThuc,
                new System.Windows.Forms.Label { Text = "Tổng tiền:", Location = new System.Drawing.Point(210, 145) }, this.lblTong
            });

            // dgvThanhVien
            this.dgvThanhVien.Location = new System.Drawing.Point(12, 200);
            this.dgvThanhVien.Size = new System.Drawing.Size(958, 140);
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Buttons
            this.btnDangKy.Location = new System.Drawing.Point(320, 350); this.btnDangKy.Size = new System.Drawing.Size(150, 35); this.btnDangKy.Text = "Lập phiếu đăng ký";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            this.btnHuy.Location = new System.Drawing.Point(500, 350); this.btnHuy.Size = new System.Drawing.Size(150, 35); this.btnHuy.Text = "Hủy phiếu (mất cọc)";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            // dgv
            this.dgv.Location = new System.Drawing.Point(12, 395);
            this.dgv.Size = new System.Drawing.Size(958, 200);
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.btnDong.Location = new System.Drawing.Point(860, 605); this.btnDong.Size = new System.Drawing.Size(110, 30); this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(984, 645);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpDoan, this.grpDangKy, this.dgvThanhVien, this.btnDangKy, this.btnHuy, this.dgv, this.btnDong
            });

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDangKyDoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu đăng ký theo đoàn";
            this.Load += new System.EventHandler(this.FrmDangKyDoan_Load);
            this.grpDoan.ResumeLayout(false);
            this.grpDoan.PerformLayout();
            this.grpDangKy.ResumeLayout(false);
            this.grpDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
        }
    }
}