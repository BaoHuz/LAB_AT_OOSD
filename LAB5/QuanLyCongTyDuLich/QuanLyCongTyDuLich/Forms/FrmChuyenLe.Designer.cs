namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmChuyenLe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.ComboBox cboTour;
        private System.Windows.Forms.DateTimePicker dtDi;
        private System.Windows.Forms.Label lblNgayVe;
        private System.Windows.Forms.TextBox txtDon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnDongDK;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMa = new System.Windows.Forms.TextBox();
            this.cboTour = new System.Windows.Forms.ComboBox();
            this.dtDi = new System.Windows.Forms.DateTimePicker();
            this.lblNgayVe = new System.Windows.Forms.Label();
            this.txtDon = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnDongDK = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            // Form Layout
            this.txtMa.Location = new System.Drawing.Point(90, 15); this.txtMa.Size = new System.Drawing.Size(150, 23);
            this.cboTour.Location = new System.Drawing.Point(300, 15); this.cboTour.Size = new System.Drawing.Size(350, 23); this.cboTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTour.SelectedIndexChanged += new System.EventHandler(this.TinhNgayVe);

            this.dtDi.Location = new System.Drawing.Point(90, 50); this.dtDi.Size = new System.Drawing.Size(150, 23); this.dtDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDi.ValueChanged += new System.EventHandler(this.TinhNgayVe);

            this.lblNgayVe.Location = new System.Drawing.Point(300, 53); this.lblNgayVe.Size = new System.Drawing.Size(150, 20); this.lblNgayVe.Text = "-";

            this.txtDon.Location = new System.Drawing.Point(90, 85); this.txtDon.Size = new System.Drawing.Size(560, 23);

            this.btnThem.Location = new System.Drawing.Point(670, 25); this.btnThem.Size = new System.Drawing.Size(110, 35); this.btnThem.Text = "Tạo chuyến";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnDongDK.Location = new System.Drawing.Point(670, 70); this.btnDongDK.Size = new System.Drawing.Size(110, 35); this.btnDongDK.Text = "Đóng đăng ký";
            this.btnDongDK.Click += new System.EventHandler(this.btnDongDK_Click);

            this.dgv.Location = new System.Drawing.Point(12, 125);
            this.dgv.Size = new System.Drawing.Size(776, 320);
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.btnDong.Location = new System.Drawing.Point(680, 455); this.btnDong.Size = new System.Drawing.Size(108, 30); this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Mã chuyến:", Location = new System.Drawing.Point(15, 18) }, this.txtMa,
                new System.Windows.Forms.Label { Text = "Tour:", Location = new System.Drawing.Point(260, 18) }, this.cboTour,
                new System.Windows.Forms.Label { Text = "Ngày đi:", Location = new System.Drawing.Point(15, 53) }, this.dtDi,
                new System.Windows.Forms.Label { Text = "Ngày về:", Location = new System.Drawing.Point(245, 53) }, this.lblNgayVe,
                new System.Windows.Forms.Label { Text = "Địa điểm đón:", Location = new System.Drawing.Point(10, 88) }, this.txtDon,
                this.btnThem, this.btnDongDK, this.dgv, this.btnDong
            });

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmChuyenLe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch chuyến khách lẻ";
            this.Load += new System.EventHandler(this.FrmChuyenLe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}