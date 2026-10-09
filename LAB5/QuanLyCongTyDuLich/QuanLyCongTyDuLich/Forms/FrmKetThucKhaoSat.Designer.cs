namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmKetThucKhaoSat
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabKT;
        private System.Windows.Forms.TabPage tabTT;
        private System.Windows.Forms.TabPage tabKS;

        // Thanh toan controls
        private System.Windows.Forms.DataGridView dgvDoan;
        private System.Windows.Forms.TextBox txtSoTT;
        private System.Windows.Forms.TextBox txtSoDK;
        private System.Windows.Forms.DateTimePicker dtTT;
        private System.Windows.Forms.NumericUpDown numTien;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnThanhToan;

        // Khao sat controls
        private System.Windows.Forms.ComboBox cboLoaiKS;
        private System.Windows.Forms.ComboBox cboDangKy;
        private System.Windows.Forms.TextBox txtMaKS;
        private System.Windows.Forms.DateTimePicker dtGui;
        private System.Windows.Forms.Button btnGui;
        private System.Windows.Forms.DataGridView dgvKS;
        private System.Windows.Forms.TextBox txtKSChon;
        private System.Windows.Forms.DateTimePicker dtPH;
        private System.Windows.Forms.NumericUpDown numDiem;
        private System.Windows.Forms.TextBox txtGopY;
        private System.Windows.Forms.Button btnGhiPH;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabKT = new System.Windows.Forms.TabControl();
            this.tabTT = new System.Windows.Forms.TabPage();
            this.tabKS = new System.Windows.Forms.TabPage();

            this.dgvDoan = new System.Windows.Forms.DataGridView();
            this.txtSoTT = new System.Windows.Forms.TextBox();
            this.txtSoDK = new System.Windows.Forms.TextBox();
            this.dtTT = new System.Windows.Forms.DateTimePicker();
            this.numTien = new System.Windows.Forms.NumericUpDown();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();

            this.cboLoaiKS = new System.Windows.Forms.ComboBox();
            this.cboDangKy = new System.Windows.Forms.ComboBox();
            this.txtMaKS = new System.Windows.Forms.TextBox();
            this.dtGui = new System.Windows.Forms.DateTimePicker();
            this.btnGui = new System.Windows.Forms.Button();
            this.dgvKS = new System.Windows.Forms.DataGridView();
            this.txtKSChon = new System.Windows.Forms.TextBox();
            this.dtPH = new System.Windows.Forms.DateTimePicker();
            this.numDiem = new System.Windows.Forms.NumericUpDown();
            this.txtGopY = new System.Windows.Forms.TextBox();
            this.btnGhiPH = new System.Windows.Forms.Button();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabKT.SuspendLayout();
            this.tabTT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTien)).BeginInit();
            this.tabKS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).BeginInit();
            this.SuspendLayout();

            // TabControl
            this.tabKT.Controls.Add(this.tabTT);
            this.tabKT.Controls.Add(this.tabKS);
            this.tabKT.Location = new System.Drawing.Point(12, 12);
            this.tabKT.Size = new System.Drawing.Size(960, 500);

            // Tab TT
            this.tabTT.Text = "Thanh toán sau tour (đoàn)";
            this.dgvDoan.Location = new System.Drawing.Point(10, 10);
            this.dgvDoan.Size = new System.Drawing.Size(930, 330);
            this.dgvDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoan.SelectionChanged += new System.EventHandler(this.dgvDoan_SelectionChanged);

            this.txtSoTT.Location = new System.Drawing.Point(80, 355); this.txtSoTT.Size = new System.Drawing.Size(100, 23);
            this.txtSoDK.Location = new System.Drawing.Point(260, 355); this.txtSoDK.Size = new System.Drawing.Size(100, 23); this.txtSoDK.ReadOnly = true;
            this.dtTT.Location = new System.Drawing.Point(470, 355); this.dtTT.Size = new System.Drawing.Size(120, 23); this.dtTT.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.numTien.Location = new System.Drawing.Point(80, 395); this.numTien.Size = new System.Drawing.Size(150, 23); this.numTien.Maximum = 1000000000;
            this.txtGhiChu.Location = new System.Drawing.Point(290, 395); this.txtGhiChu.Size = new System.Drawing.Size(300, 23);

            this.btnThanhToan.Location = new System.Drawing.Point(630, 370); this.btnThanhToan.Size = new System.Drawing.Size(160, 40); this.btnThanhToan.Text = "Ghi nhận thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            this.tabTT.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvDoan, new System.Windows.Forms.Label { Text = "Số TT:", Location = new System.Drawing.Point(10, 358) }, this.txtSoTT,
                new System.Windows.Forms.Label { Text = "Phiếu đoàn:", Location = new System.Drawing.Point(190, 358) }, this.txtSoDK,
                new System.Windows.Forms.Label { Text = "Ngày TT:", Location = new System.Drawing.Point(380, 358) }, this.dtTT,
                new System.Windows.Forms.Label { Text = "Số tiền:", Location = new System.Drawing.Point(10, 398) }, this.numTien,
                new System.Windows.Forms.Label { Text = "Ghi chú:", Location = new System.Drawing.Point(240, 398) }, this.txtGhiChu, this.btnThanhToan
            });

            // Tab KS
            this.tabKS.Text = "Khảo sát khách hàng";
            this.cboLoaiKS.Location = new System.Drawing.Point(80, 15); this.cboLoaiKS.Size = new System.Drawing.Size(80, 23); this.cboLoaiKS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKS.SelectedIndexChanged += new System.EventHandler(this.cboLoaiKS_SelectedIndexChanged);

            this.cboDangKy.Location = new System.Drawing.Point(230, 15); this.cboDangKy.Size = new System.Drawing.Size(250, 23); this.cboDangKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMaKS.Location = new System.Drawing.Point(540, 15); this.txtMaKS.Size = new System.Drawing.Size(100, 23);
            this.dtGui.Location = new System.Drawing.Point(710, 15); this.dtGui.Size = new System.Drawing.Size(110, 23); this.dtGui.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            this.btnGui.Location = new System.Drawing.Point(830, 10); this.btnGui.Size = new System.Drawing.Size(110, 30); this.btnGui.Text = "Gửi phiếu KS";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);

            this.dgvKS.Location = new System.Drawing.Point(10, 50);
            this.dgvKS.Size = new System.Drawing.Size(930, 280);
            this.dgvKS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKS.SelectionChanged += new System.EventHandler(this.dgvKS_SelectionChanged);

            this.txtKSChon.Location = new System.Drawing.Point(80, 345); this.txtKSChon.Size = new System.Drawing.Size(100, 23); this.txtKSChon.ReadOnly = true;
            this.dtPH.Location = new System.Drawing.Point(280, 345); this.dtPH.Size = new System.Drawing.Size(110, 23); this.dtPH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.numDiem.Location = new System.Drawing.Point(460, 345); this.numDiem.Size = new System.Drawing.Size(50, 23); this.numDiem.Minimum = 1; this.numDiem.Maximum = 5; this.numDiem.Value = 5;

            this.txtGopY.Location = new System.Drawing.Point(80, 380); this.txtGopY.Size = new System.Drawing.Size(500, 23);
            this.btnGhiPH.Location = new System.Drawing.Point(600, 375); this.btnGhiPH.Size = new System.Drawing.Size(120, 30); this.btnGhiPH.Text = "Ghi nhận góp ý";
            this.btnGhiPH.Click += new System.EventHandler(this.btnGhiPH_Click);

            this.tabKS.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Loại khách:", Location = new System.Drawing.Point(10, 18) }, this.cboLoaiKS,
                new System.Windows.Forms.Label { Text = "Đăng ký:", Location = new System.Drawing.Point(170, 18) }, this.cboDangKy,
                new System.Windows.Forms.Label { Text = "Mã KS:", Location = new System.Drawing.Point(490, 18) }, this.txtMaKS,
                new System.Windows.Forms.Label { Text = "Ngày gửi:", Location = new System.Drawing.Point(650, 18) }, this.dtGui, this.btnGui,
                this.dgvKS,
                new System.Windows.Forms.Label { Text = "Phiếu chọn:", Location = new System.Drawing.Point(10, 348) }, this.txtKSChon,
                new System.Windows.Forms.Label { Text = "Ngày PH:", Location = new System.Drawing.Point(200, 348) }, this.dtPH,
                new System.Windows.Forms.Label { Text = "Điểm (1-5):", Location = new System.Drawing.Point(400, 348) }, this.numDiem,
                new System.Windows.Forms.Label { Text = "Góp ý:", Location = new System.Drawing.Point(10, 383) }, this.txtGopY, this.btnGhiPH
            });

            // Form
            this.btnDong.Location = new System.Drawing.Point(860, 520); this.btnDong.Size = new System.Drawing.Size(110, 30); this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(984, 560);
            this.Controls.Add(this.tabKT);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmKetThucKhaoSat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết thúc tour - thanh toán đoàn - khảo sát";
            this.Load += new System.EventHandler(this.FrmKetThucKhaoSat_Load);
            this.tabKT.ResumeLayout(false);
            this.tabTT.ResumeLayout(false);
            this.tabTT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTien)).EndInit();
            this.tabKS.ResumeLayout(false);
            this.tabKS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiem)).EndInit();
            this.ResumeLayout(false);
        }
    }
}