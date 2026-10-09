namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabDanhMuc;
        private System.Windows.Forms.TabPage tabPT;
        private System.Windows.Forms.TabPage tabDB;
        private System.Windows.Forms.TabPage tabHDV;
        private System.Windows.Forms.TabPage tabDTQ;
        private System.Windows.Forms.Button btnDong;

        // PT Controls
        private System.Windows.Forms.DataGridView dgvPT;
        private System.Windows.Forms.TextBox txtPTMa;
        private System.Windows.Forms.TextBox txtPTTen;
        private System.Windows.Forms.TextBox txtPTGhiChu;
        private System.Windows.Forms.Button btnThemPT;

        // DB Controls
        private System.Windows.Forms.DataGridView dgvDB;
        private System.Windows.Forms.TextBox txtDBMa;
        private System.Windows.Forms.TextBox txtDBTen;
        private System.Windows.Forms.TextBox txtDBDiaChi;
        private System.Windows.Forms.TextBox txtDBDT;
        private System.Windows.Forms.Button btnThemDB;

        // HDV Controls
        private System.Windows.Forms.DataGridView dgvHDV;
        private System.Windows.Forms.TextBox txtHDVMa;
        private System.Windows.Forms.TextBox txtHDVTen;
        private System.Windows.Forms.TextBox txtHDVDT;
        private System.Windows.Forms.NumericUpDown numLuong;
        private System.Windows.Forms.Button btnThemHDV;

        // DTQ Controls
        private System.Windows.Forms.DataGridView dgvDTQ;
        private System.Windows.Forms.TextBox txtDTQMa;
        private System.Windows.Forms.TextBox txtDTQTen;
        private System.Windows.Forms.TextBox txtDTQDiaDiem;
        private System.Windows.Forms.TextBox txtDTQNoiDung;
        private System.Windows.Forms.TextBox txtDTQYNghia;
        private System.Windows.Forms.Button btnThemDTQ;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabDanhMuc = new System.Windows.Forms.TabControl();
            this.tabPT = new System.Windows.Forms.TabPage();
            this.dgvPT = new System.Windows.Forms.DataGridView();
            this.txtPTMa = new System.Windows.Forms.TextBox();
            this.txtPTTen = new System.Windows.Forms.TextBox();
            this.txtPTGhiChu = new System.Windows.Forms.TextBox();
            this.btnThemPT = new System.Windows.Forms.Button();

            this.tabDB = new System.Windows.Forms.TabPage();
            this.dgvDB = new System.Windows.Forms.DataGridView();
            this.txtDBMa = new System.Windows.Forms.TextBox();
            this.txtDBTen = new System.Windows.Forms.TextBox();
            this.txtDBDiaChi = new System.Windows.Forms.TextBox();
            this.txtDBDT = new System.Windows.Forms.TextBox();
            this.btnThemDB = new System.Windows.Forms.Button();

            this.tabHDV = new System.Windows.Forms.TabPage();
            this.dgvHDV = new System.Windows.Forms.DataGridView();
            this.txtHDVMa = new System.Windows.Forms.TextBox();
            this.txtHDVTen = new System.Windows.Forms.TextBox();
            this.txtHDVDT = new System.Windows.Forms.TextBox();
            this.numLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThemHDV = new System.Windows.Forms.Button();

            this.tabDTQ = new System.Windows.Forms.TabPage();
            this.dgvDTQ = new System.Windows.Forms.DataGridView();
            this.txtDTQMa = new System.Windows.Forms.TextBox();
            this.txtDTQTen = new System.Windows.Forms.TextBox();
            this.txtDTQDiaDiem = new System.Windows.Forms.TextBox();
            this.txtDTQNoiDung = new System.Windows.Forms.TextBox();
            this.txtDTQYNghia = new System.Windows.Forms.TextBox();
            this.btnThemDTQ = new System.Windows.Forms.Button();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabDanhMuc.SuspendLayout();
            this.tabPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).BeginInit();
            this.tabDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).BeginInit();
            this.tabHDV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong)).BeginInit();
            this.tabDTQ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTQ)).BeginInit();
            this.SuspendLayout();

            // TabControl
            this.tabDanhMuc.Controls.Add(this.tabPT);
            this.tabDanhMuc.Controls.Add(this.tabDB);
            this.tabDanhMuc.Controls.Add(this.tabHDV);
            this.tabDanhMuc.Controls.Add(this.tabDTQ);
            this.tabDanhMuc.Location = new System.Drawing.Point(12, 12);
            this.tabDanhMuc.Size = new System.Drawing.Size(960, 500);

            // Tab PT
            this.tabPT.Text = "Phương tiện";
            this.dgvPT.Location = new System.Drawing.Point(10, 10);
            this.dgvPT.Size = new System.Drawing.Size(930, 380);
            this.dgvPT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txtPTMa.Location = new System.Drawing.Point(80, 410); this.txtPTMa.Size = new System.Drawing.Size(120, 23);
            this.txtPTTen.Location = new System.Drawing.Point(280, 410); this.txtPTTen.Size = new System.Drawing.Size(200, 23);
            this.txtPTGhiChu.Location = new System.Drawing.Point(80, 440); this.txtPTGhiChu.Size = new System.Drawing.Size(400, 23);
            this.btnThemPT.Location = new System.Drawing.Point(730, 420); this.btnThemPT.Size = new System.Drawing.Size(100, 35); this.btnThemPT.Text = "Thêm";
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            this.tabPT.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvPT, new System.Windows.Forms.Label { Text = "Mã PT:", Location = new System.Drawing.Point(20, 413) }, this.txtPTMa,
                new System.Windows.Forms.Label { Text = "Tên PT:", Location = new System.Drawing.Point(220, 413) }, this.txtPTTen,
                new System.Windows.Forms.Label { Text = "Ghi chú:", Location = new System.Drawing.Point(20, 443) }, this.txtPTGhiChu, this.btnThemPT
            });

            // Tab DB
            this.tabDB.Text = "Điểm bán vé";
            this.dgvDB.Location = new System.Drawing.Point(10, 10);
            this.dgvDB.Size = new System.Drawing.Size(930, 380);
            this.dgvDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txtDBMa.Location = new System.Drawing.Point(80, 410); this.txtDBMa.Size = new System.Drawing.Size(120, 23);
            this.txtDBTen.Location = new System.Drawing.Point(280, 410); this.txtDBTen.Size = new System.Drawing.Size(200, 23);
            this.txtDBDiaChi.Location = new System.Drawing.Point(550, 410); this.txtDBDiaChi.Size = new System.Drawing.Size(200, 23);
            this.txtDBDT.Location = new System.Drawing.Point(80, 440); this.txtDBDT.Size = new System.Drawing.Size(120, 23);
            this.btnThemDB.Location = new System.Drawing.Point(780, 420); this.btnThemDB.Size = new System.Drawing.Size(100, 35); this.btnThemDB.Text = "Thêm";
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            this.tabDB.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvDB, new System.Windows.Forms.Label { Text = "Mã DB:", Location = new System.Drawing.Point(20, 413) }, this.txtDBMa,
                new System.Windows.Forms.Label { Text = "Tên DB:", Location = new System.Drawing.Point(220, 413) }, this.txtDBTen,
                new System.Windows.Forms.Label { Text = "Địa chỉ:", Location = new System.Drawing.Point(490, 413) }, this.txtDBDiaChi,
                new System.Windows.Forms.Label { Text = "Điện thoại:", Location = new System.Drawing.Point(10, 443) }, this.txtDBDT, this.btnThemDB
            });

            // Tab HDV
            this.tabHDV.Text = "Hướng dẫn viên";
            this.dgvHDV.Location = new System.Drawing.Point(10, 10);
            this.dgvHDV.Size = new System.Drawing.Size(930, 380);
            this.dgvHDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txtHDVMa.Location = new System.Drawing.Point(80, 410); this.txtHDVMa.Size = new System.Drawing.Size(120, 23);
            this.txtHDVTen.Location = new System.Drawing.Point(280, 410); this.txtHDVTen.Size = new System.Drawing.Size(200, 23);
            this.txtHDVDT.Location = new System.Drawing.Point(550, 410); this.txtHDVDT.Size = new System.Drawing.Size(150, 23);
            this.numLuong.Location = new System.Drawing.Point(80, 440); this.numLuong.Size = new System.Drawing.Size(150, 23);
            this.numLuong.Maximum = 1000000000;
            this.btnThemHDV.Location = new System.Drawing.Point(780, 420); this.btnThemHDV.Size = new System.Drawing.Size(100, 35); this.btnThemHDV.Text = "Thêm";
            this.btnThemHDV.Click += new System.EventHandler(this.btnThemHDV_Click);
            this.tabHDV.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvHDV, new System.Windows.Forms.Label { Text = "Mã HDV:", Location = new System.Drawing.Point(20, 413) }, this.txtHDVMa,
                new System.Windows.Forms.Label { Text = "Họ tên:", Location = new System.Drawing.Point(220, 413) }, this.txtHDVTen,
                new System.Windows.Forms.Label { Text = "Điện thoại:", Location = new System.Drawing.Point(490, 413) }, this.txtHDVDT,
                new System.Windows.Forms.Label { Text = "Lương CB:", Location = new System.Drawing.Point(10, 443) }, this.numLuong, this.btnThemHDV
            });

            // Tab DTQ
            this.tabDTQ.Text = "Điểm tham quan";
            this.dgvDTQ.Location = new System.Drawing.Point(10, 10);
            this.dgvDTQ.Size = new System.Drawing.Size(930, 350);
            this.dgvDTQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txtDTQMa.Location = new System.Drawing.Point(80, 380); this.txtDTQMa.Size = new System.Drawing.Size(120, 23);
            this.txtDTQTen.Location = new System.Drawing.Point(280, 380); this.txtDTQTen.Size = new System.Drawing.Size(200, 23);
            this.txtDTQDiaDiem.Location = new System.Drawing.Point(550, 380); this.txtDTQDiaDiem.Size = new System.Drawing.Size(200, 23);
            this.txtDTQNoiDung.Location = new System.Drawing.Point(80, 415); this.txtDTQNoiDung.Size = new System.Drawing.Size(670, 23);
            this.txtDTQYNghia.Location = new System.Drawing.Point(80, 445); this.txtDTQYNghia.Size = new System.Drawing.Size(670, 23);
            this.btnThemDTQ.Location = new System.Drawing.Point(780, 410); this.btnThemDTQ.Size = new System.Drawing.Size(100, 35); this.btnThemDTQ.Text = "Thêm";
            this.btnThemDTQ.Click += new System.EventHandler(this.btnThemDTQ_Click);
            this.tabDTQ.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvDTQ, new System.Windows.Forms.Label { Text = "Mã DTQ:", Location = new System.Drawing.Point(20, 383) }, this.txtDTQMa,
                new System.Windows.Forms.Label { Text = "Tên DTQ:", Location = new System.Drawing.Point(220, 383) }, this.txtDTQTen,
                new System.Windows.Forms.Label { Text = "Địa điểm:", Location = new System.Drawing.Point(490, 383) }, this.txtDTQDiaDiem,
                new System.Windows.Forms.Label { Text = "Nội dung:", Location = new System.Drawing.Point(20, 418) }, this.txtDTQNoiDung,
                new System.Windows.Forms.Label { Text = "Ý nghĩa:", Location = new System.Drawing.Point(20, 448) }, this.txtDTQYNghia, this.btnThemDTQ
            });

            // Form
            this.btnDong.Location = new System.Drawing.Point(860, 520);
            this.btnDong.Size = new System.Drawing.Size(110, 35);
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.tabDanhMuc);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabDanhMuc.ResumeLayout(false);
            this.tabPT.ResumeLayout(false);
            this.tabPT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPT)).EndInit();
            this.tabDB.ResumeLayout(false);
            this.tabDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDB)).EndInit();
            this.tabHDV.ResumeLayout(false);
            this.tabHDV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLuong)).EndInit();
            this.tabDTQ.ResumeLayout(false);
            this.tabDTQ.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTQ)).EndInit();
            this.ResumeLayout(false);
        }
    }
}