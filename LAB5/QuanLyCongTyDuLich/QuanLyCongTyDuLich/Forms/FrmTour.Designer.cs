namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmTour
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.TabControl tabTour;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TabPage tabDiemDung;
        private System.Windows.Forms.TabPage tabChang;
        private System.Windows.Forms.TabPage tabDTQ;
        private System.Windows.Forms.Button btnDong;

        // Info Controls
        private System.Windows.Forms.DataGridView dgvTour;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.NumericUpDown numNgay;
        private System.Windows.Forms.NumericUpDown numDem;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Button btnThemTour;

        // DiemDung Controls
        private System.Windows.Forms.DataGridView dgvDiemDung;
        private System.Windows.Forms.NumericUpDown numThuTu;
        private System.Windows.Forms.TextBox txtDiemDung;
        private System.Windows.Forms.CheckBox chkDoiPT;
        private System.Windows.Forms.CheckBox chkAn;
        private System.Windows.Forms.CheckBox chkKS;
        private System.Windows.Forms.NumericUpDown numSao;
        private System.Windows.Forms.TextBox txtGhiChuDD;
        private System.Windows.Forms.Button btnThemDD;

        // Chang Controls
        private System.Windows.Forms.DataGridView dgvChang;
        private System.Windows.Forms.NumericUpDown numChang;
        private System.Windows.Forms.ComboBox cboPT;
        private System.Windows.Forms.TextBox txtGhiChuPT;
        private System.Windows.Forms.Button btnThemChang;

        // DTQ Controls
        private System.Windows.Forms.DataGridView dgvTQ;
        private System.Windows.Forms.ComboBox cboDTQ;
        private System.Windows.Forms.NumericUpDown numThuTuTQ;
        private System.Windows.Forms.Button btnThemTQ;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.tabTour = new System.Windows.Forms.TabControl();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.tabDiemDung = new System.Windows.Forms.TabPage();
            this.tabChang = new System.Windows.Forms.TabPage();
            this.tabDTQ = new System.Windows.Forms.TabPage();

            this.dgvTour = new System.Windows.Forms.DataGridView();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.numNgay = new System.Windows.Forms.NumericUpDown();
            this.numDem = new System.Windows.Forms.NumericUpDown();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.btnThemTour = new System.Windows.Forms.Button();

            this.dgvDiemDung = new System.Windows.Forms.DataGridView();
            this.numThuTu = new System.Windows.Forms.NumericUpDown();
            this.txtDiemDung = new System.Windows.Forms.TextBox();
            this.chkDoiPT = new System.Windows.Forms.CheckBox();
            this.chkAn = new System.Windows.Forms.CheckBox();
            this.chkKS = new System.Windows.Forms.CheckBox();
            this.numSao = new System.Windows.Forms.NumericUpDown();
            this.txtGhiChuDD = new System.Windows.Forms.TextBox();
            this.btnThemDD = new System.Windows.Forms.Button();

            this.dgvChang = new System.Windows.Forms.DataGridView();
            this.numChang = new System.Windows.Forms.NumericUpDown();
            this.cboPT = new System.Windows.Forms.ComboBox();
            this.txtGhiChuPT = new System.Windows.Forms.TextBox();
            this.btnThemChang = new System.Windows.Forms.Button();

            this.dgvTQ = new System.Windows.Forms.DataGridView();
            this.cboDTQ = new System.Windows.Forms.ComboBox();
            this.numThuTuTQ = new System.Windows.Forms.NumericUpDown();
            this.btnThemTQ = new System.Windows.Forms.Button();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabTour.SuspendLayout();
            this.tabInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();

            this.tabDiemDung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSao)).BeginInit();

            this.tabChang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChang)).BeginInit();

            this.tabDTQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTuTQ)).BeginInit();
            this.SuspendLayout();

            // cboTour
            this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.Location = new System.Drawing.Point(260, 12);
            this.cboTour.Size = new System.Drawing.Size(300, 23);
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.cboTour_SelectedIndexChanged);

            // TabControl
            this.tabTour.Controls.Add(this.tabInfo);
            this.tabTour.Controls.Add(this.tabDiemDung);
            this.tabTour.Controls.Add(this.tabChang);
            this.tabTour.Controls.Add(this.tabDTQ);
            this.tabTour.Location = new System.Drawing.Point(12, 45);
            this.tabTour.Size = new System.Drawing.Size(960, 480);

            // Tab Info
            this.tabInfo.Text = "Tour";
            this.dgvTour.Location = new System.Drawing.Point(10, 10);
            this.dgvTour.Size = new System.Drawing.Size(930, 320);
            this.dgvTour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txtMa.Location = new System.Drawing.Point(80, 345); this.txtMa.Size = new System.Drawing.Size(100, 23);
            this.txtTen.Location = new System.Drawing.Point(260, 345); this.txtTen.Size = new System.Drawing.Size(200, 23);
            this.numNgay.Location = new System.Drawing.Point(530, 345); this.numNgay.Size = new System.Drawing.Size(60, 23);
            this.numDem.Location = new System.Drawing.Point(660, 345); this.numDem.Size = new System.Drawing.Size(60, 23);
            this.numGia.Location = new System.Drawing.Point(80, 380); this.numGia.Size = new System.Drawing.Size(150, 23); this.numGia.Maximum = 1000000000;
            this.txtMoTa.Location = new System.Drawing.Point(260, 380); this.txtMoTa.Size = new System.Drawing.Size(460, 23);
            this.btnThemTour.Location = new System.Drawing.Point(780, 355); this.btnThemTour.Size = new System.Drawing.Size(100, 40); this.btnThemTour.Text = "Thêm tour";
            this.btnThemTour.Click += new System.EventHandler(this.btnThemTour_Click);
            this.tabInfo.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvTour, new System.Windows.Forms.Label { Text = "Mã tour:", Location = new System.Drawing.Point(20, 348) }, this.txtMa,
                new System.Windows.Forms.Label { Text = "Tên tour:", Location = new System.Drawing.Point(200, 348) }, this.txtTen,
                new System.Windows.Forms.Label { Text = "Số ngày:", Location = new System.Drawing.Point(470, 348) }, this.numNgay,
                new System.Windows.Forms.Label { Text = "Số đêm:", Location = new System.Drawing.Point(600, 348) }, this.numDem,
                new System.Windows.Forms.Label { Text = "Đơn giá:", Location = new System.Drawing.Point(20, 383) }, this.numGia,
                new System.Windows.Forms.Label { Text = "Mô tả:", Location = new System.Drawing.Point(210, 383) }, this.txtMoTa, this.btnThemTour
            });

            // Tab DiemDung
            this.tabDiemDung.Text = "Điểm dừng";
            this.dgvDiemDung.Location = new System.Drawing.Point(10, 10);
            this.dgvDiemDung.Size = new System.Drawing.Size(930, 320);
            this.dgvDiemDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.numThuTu.Location = new System.Drawing.Point(80, 345); this.numThuTu.Size = new System.Drawing.Size(60, 23);
            this.txtDiemDung.Location = new System.Drawing.Point(240, 345); this.txtDiemDung.Size = new System.Drawing.Size(200, 23);
            this.chkDoiPT.Location = new System.Drawing.Point(460, 345); this.chkDoiPT.Text = "Đổi PT";
            this.chkAn.Location = new System.Drawing.Point(540, 345); this.chkAn.Text = "Có nơi ăn";
            this.chkKS.Location = new System.Drawing.Point(630, 345); this.chkKS.Text = "Có KS";
            this.chkKS.CheckedChanged += new System.EventHandler(this.chkKS_CheckedChanged);
            this.numSao.Location = new System.Drawing.Point(770, 345); this.numSao.Size = new System.Drawing.Size(50, 23); this.numSao.Minimum = 2; this.numSao.Maximum = 5; this.numSao.Enabled = false;
            this.txtGhiChuDD.Location = new System.Drawing.Point(80, 380); this.txtGhiChuDD.Size = new System.Drawing.Size(600, 23);
            this.btnThemDD.Location = new System.Drawing.Point(720, 375); this.btnThemDD.Size = new System.Drawing.Size(120, 35); this.btnThemDD.Text = "Thêm điểm dừng";
            this.btnThemDD.Click += new System.EventHandler(this.btnThemDD_Click);
            this.tabDiemDung.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvDiemDung, new System.Windows.Forms.Label { Text = "Thứ tự:", Location = new System.Drawing.Point(20, 348) }, this.numThuTu,
                new System.Windows.Forms.Label { Text = "Tên điểm:", Location = new System.Drawing.Point(160, 348) }, this.txtDiemDung,
                this.chkDoiPT, this.chkAn, this.chkKS, new System.Windows.Forms.Label { Text = "Hạng sao:", Location = new System.Drawing.Point(700, 348) }, this.numSao,
                new System.Windows.Forms.Label { Text = "Ghi chú:", Location = new System.Drawing.Point(20, 383) }, this.txtGhiChuDD, this.btnThemDD
            });

            // Tab Chang
            this.tabChang.Text = "Phương tiện theo chặng";
            this.dgvChang.Location = new System.Drawing.Point(10, 10);
            this.dgvChang.Size = new System.Drawing.Size(930, 340);
            this.dgvChang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.numChang.Location = new System.Drawing.Point(80, 365); this.numChang.Size = new System.Drawing.Size(60, 23);
            this.cboPT.Location = new System.Drawing.Point(240, 365); this.cboPT.Size = new System.Drawing.Size(200, 23); this.cboPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtGhiChuPT.Location = new System.Drawing.Point(80, 400); this.txtGhiChuPT.Size = new System.Drawing.Size(600, 23);
            this.btnThemChang.Location = new System.Drawing.Point(720, 395); this.btnThemChang.Size = new System.Drawing.Size(120, 35); this.btnThemChang.Text = "Gắn phương tiện";
            this.btnThemChang.Click += new System.EventHandler(this.btnThemChang_Click);
            this.tabChang.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvChang, new System.Windows.Forms.Label { Text = "Chặng thứ:", Location = new System.Drawing.Point(10, 368) }, this.numChang,
                new System.Windows.Forms.Label { Text = "Phương tiện:", Location = new System.Drawing.Point(150, 368) }, this.cboPT,
                new System.Windows.Forms.Label { Text = "Ghi chú:", Location = new System.Drawing.Point(10, 403) }, this.txtGhiChuPT, this.btnThemChang
            });

            // Tab DTQ
            this.tabDTQ.Text = "Điểm tham quan";
            this.dgvTQ.Location = new System.Drawing.Point(10, 10);
            this.dgvTQ.Size = new System.Drawing.Size(930, 350);
            this.dgvTQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cboDTQ.Location = new System.Drawing.Point(110, 380); this.cboDTQ.Size = new System.Drawing.Size(250, 23); this.cboDTQ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numThuTuTQ.Location = new System.Drawing.Point(440, 380); this.numThuTuTQ.Size = new System.Drawing.Size(60, 23);
            this.btnThemTQ.Location = new System.Drawing.Point(720, 375); this.btnThemTQ.Size = new System.Drawing.Size(120, 35); this.btnThemTQ.Text = "Gắn điểm TQ";
            this.btnThemTQ.Click += new System.EventHandler(this.btnThemTQ_Click);
            this.tabDTQ.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvTQ, new System.Windows.Forms.Label { Text = "Điểm tham quan:", Location = new System.Drawing.Point(10, 383) }, this.cboDTQ,
                new System.Windows.Forms.Label { Text = "Thứ tự:", Location = new System.Drawing.Point(380, 383) }, this.numThuTuTQ, this.btnThemTQ
            });

            // Form
            this.btnDong.Location = new System.Drawing.Point(860, 530);
            this.btnDong.Size = new System.Drawing.Size(110, 35);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(984, 575);
            this.Controls.Add(new System.Windows.Forms.Label { Text = "Tour đang chọn (cho các tab hành trình):", Location = new System.Drawing.Point(15, 15), AutoSize = true });
            this.Controls.Add(this.cboTour);
            this.Controls.Add(this.tabTour);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tour - hành trình";
            this.Load += new System.EventHandler(this.FrmTour_Load);
            this.tabTour.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            this.tabDiemDung.ResumeLayout(false);
            this.tabDiemDung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSao)).EndInit();
            this.tabChang.ResumeLayout(false);
            this.tabChang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numChang)).EndInit();
            this.tabDTQ.ResumeLayout(false);
            this.tabDTQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThuTuTQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}