namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmDangKyLe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ComboBox cboChuyen;
        private System.Windows.Forms.ComboBox cboDiemBan;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.NumericUpDown numNguoi;
        private System.Windows.Forms.Label lblThanhTien;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtSo = new System.Windows.Forms.TextBox();
            this.cboChuyen = new System.Windows.Forms.ComboBox();
            this.cboDiemBan = new System.Windows.Forms.ComboBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.numNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblThanhTien = new System.Windows.Forms.Label();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();

            this.txtSo.Location = new System.Drawing.Point(90, 15); this.txtSo.Size = new System.Drawing.Size(120, 23);
            this.cboChuyen.Location = new System.Drawing.Point(280, 15); this.cboChuyen.Size = new System.Drawing.Size(350, 23); this.cboChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyen.SelectedIndexChanged += new System.EventHandler(this.TinhTien);

            this.cboDiemBan.Location = new System.Drawing.Point(90, 50); this.cboDiemBan.Size = new System.Drawing.Size(150, 23); this.cboDiemBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTen.Location = new System.Drawing.Point(340, 50); this.txtTen.Size = new System.Drawing.Size(180, 23);
            this.txtDT.Location = new System.Drawing.Point(600, 50); this.txtDT.Size = new System.Drawing.Size(120, 23);

            this.numNguoi.Location = new System.Drawing.Point(90, 85); this.numNguoi.Size = new System.Drawing.Size(60, 23); this.numNguoi.Value = 1; this.numNguoi.Minimum = 1; this.numNguoi.Maximum = 11;
            this.numNguoi.ValueChanged += new System.EventHandler(this.TinhTien);

            this.lblThanhTien.Location = new System.Drawing.Point(240, 88); this.lblThanhTien.Size = new System.Drawing.Size(150, 20); this.lblThanhTien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.btnDangKy.Location = new System.Drawing.Point(600, 80); this.btnDangKy.Size = new System.Drawing.Size(180, 35); this.btnDangKy.Text = "Đăng ký và thanh toán vé";
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);

            this.dgv.Location = new System.Drawing.Point(12, 130);
            this.dgv.Size = new System.Drawing.Size(776, 320);
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.btnDong.Location = new System.Drawing.Point(680, 460); this.btnDong.Size = new System.Drawing.Size(108, 30); this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                new System.Windows.Forms.Label { Text = "Số đăng ký:", Location = new System.Drawing.Point(10, 18) }, this.txtSo,
                new System.Windows.Forms.Label { Text = "Chuyến:", Location = new System.Drawing.Point(225, 18) }, this.cboChuyen,
                new System.Windows.Forms.Label { Text = "Điểm bán vé:", Location = new System.Drawing.Point(10, 53) }, this.cboDiemBan,
                new System.Windows.Forms.Label { Text = "Người đăng ký:", Location = new System.Drawing.Point(250, 53) }, this.txtTen,
                new System.Windows.Forms.Label { Text = "Điện thoại:", Location = new System.Drawing.Point(530, 53) }, this.txtDT,
                new System.Windows.Forms.Label { Text = "Số người:", Location = new System.Drawing.Point(10, 88) }, this.numNguoi,
                new System.Windows.Forms.Label { Text = "Thành tiền:", Location = new System.Drawing.Point(165, 88) }, this.lblThanhTien,
                this.btnDangKy, this.dgv, this.btnDong
            });

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDangKyLe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký khách lẻ theo chuyến";
            this.Load += new System.EventHandler(this.FrmDangKyLe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}