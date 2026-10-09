namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmPhanCongHDV
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMaPC;
        private System.Windows.Forms.ComboBox cboHDV;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.ComboBox cboDoiTuong;
        private System.Windows.Forms.NumericUpDown numThuLao;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMaPC = new System.Windows.Forms.TextBox();
            this.cboHDV = new System.Windows.Forms.ComboBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.cboDoiTuong = new System.Windows.Forms.ComboBox();
            this.numThuLao = new System.Windows.Forms.NumericUpDown();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numThuLao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            this.txtMaPC.Location = new System.Drawing.Point(100, 15); this.txtMaPC.Size = new System.Drawing.Size(120, 23);
            this.cboHDV.Location = new System.Drawing.Point(340, 15); this.cboHDV.Size = new System.Drawing.Size(250, 23); this.cboHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboLoai.Location = new System.Drawing.Point(100, 50); this.cboLoai.Size = new System.Drawing.Size(120, 23); this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);

            this.cboDoiTuong.Location = new System.Drawing.Point(340, 50); this.cboDoiTuong.Size = new System.Drawing.Size(250, 23); this.cboDoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.numThuLao.Location = new System.Drawing.Point(100, 85); this.numThuLao.Size = new System.Drawing.Size(150, 23); this.numThuLao.Maximum = 100000000;

            this.btnPhanCong.Location = new System.Drawing.Point(620, 30); this.btnPhanCong.Size = new System.Drawing.Size(120, 45); this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);

            this.dgv.Location = new System.Drawing.Point(12, 130);
            this.dgv.Size = new System.Drawing.Size(776, 320);
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.btnDong.Location = new System.Drawing.Point(680, 460); this.btnDong.Size = new System.Drawing.Size(108, 30); this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Mã PC:", Location = new System.Drawing.Point(10, 18) }, this.txtMaPC,
                new System.Windows.Forms.Label { Text = "Hướng dẫn viên:", Location = new System.Drawing.Point(235, 18) }, this.cboHDV,
                new System.Windows.Forms.Label { Text = "Loại:", Location = new System.Drawing.Point(10, 53) }, this.cboLoai,
                new System.Windows.Forms.Label { Text = "Chuyến / đoàn:", Location = new System.Drawing.Point(235, 53) }, this.cboDoiTuong,
                new System.Windows.Forms.Label { Text = "Thù lao tour:", Location = new System.Drawing.Point(10, 88) }, this.numThuLao,
                this.btnPhanCong, this.dgv, this.btnDong
            });

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPhanCongHDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công hướng dẫn viên";
            this.Load += new System.EventHandler(this.FrmPhanCongHDV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numThuLao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}