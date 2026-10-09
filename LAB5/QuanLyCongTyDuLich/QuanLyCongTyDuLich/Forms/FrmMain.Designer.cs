namespace QuanLyCongTyDuLich.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnTour;
        private System.Windows.Forms.Button btnChuyenLe;
        private System.Windows.Forms.Button btnDangKyLe;
        private System.Windows.Forms.Button btnDangKyDoan;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnTour = new System.Windows.Forms.Button();
            this.btnChuyenLe = new System.Windows.Forms.Button();
            this.btnDangKyLe = new System.Windows.Forms.Button();
            this.btnDangKyDoan = new System.Windows.Forms.Button();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(12, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(600, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CÔNG TY DU LỊCH VĂN HÓA VIỆT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDanhMuc.Location = new System.Drawing.Point(50, 80);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(240, 50);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnTour
            // 
            this.btnTour.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTour.Location = new System.Drawing.Point(330, 80);
            this.btnTour.Name = "btnTour";
            this.btnTour.Size = new System.Drawing.Size(240, 50);
            this.btnTour.TabIndex = 2;
            this.btnTour.Text = "Tour - hành trình";
            this.btnTour.Click += new System.EventHandler(this.btnTour_Click);
            // 
            // btnChuyenLe
            // 
            this.btnChuyenLe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnChuyenLe.Location = new System.Drawing.Point(50, 145);
            this.btnChuyenLe.Name = "btnChuyenLe";
            this.btnChuyenLe.Size = new System.Drawing.Size(240, 50);
            this.btnChuyenLe.TabIndex = 3;
            this.btnChuyenLe.Text = "Lịch chuyến khách lẻ";
            this.btnChuyenLe.Click += new System.EventHandler(this.btnChuyenLe_Click);
            // 
            // btnDangKyLe
            // 
            this.btnDangKyLe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangKyLe.Location = new System.Drawing.Point(330, 145);
            this.btnDangKyLe.Name = "btnDangKyLe";
            this.btnDangKyLe.Size = new System.Drawing.Size(240, 50);
            this.btnDangKyLe.TabIndex = 4;
            this.btnDangKyLe.Text = "Đăng ký khách lẻ";
            this.btnDangKyLe.Click += new System.EventHandler(this.btnDangKyLe_Click);
            // 
            // btnDangKyDoan
            // 
            this.btnDangKyDoan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDangKyDoan.Location = new System.Drawing.Point(50, 210);
            this.btnDangKyDoan.Name = "btnDangKyDoan";
            this.btnDangKyDoan.Size = new System.Drawing.Size(240, 50);
            this.btnDangKyDoan.TabIndex = 5;
            this.btnDangKyDoan.Text = "Đăng ký theo đoàn";
            this.btnDangKyDoan.Click += new System.EventHandler(this.btnDangKyDoan_Click);
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPhanCong.Location = new System.Drawing.Point(330, 210);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(240, 50);
            this.btnPhanCong.TabIndex = 6;
            this.btnPhanCong.Text = "Phân công hướng dẫn viên";
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKetThuc.Location = new System.Drawing.Point(50, 275);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(240, 50);
            this.btnKetThuc.TabIndex = 7;
            this.btnKetThuc.Text = "Kết thúc tour - khảo sát";
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnThongKe.Location = new System.Drawing.Point(330, 275);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(240, 50);
            this.btnThongKe.TabIndex = 8;
            this.btnThongKe.Text = "Lương - thống kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.DarkRed;
            this.btnThoat.Location = new System.Drawing.Point(190, 345);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(240, 45);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.ClientSize = new System.Drawing.Size(624, 411);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.btnTour);
            this.Controls.Add(this.btnChuyenLe);
            this.Controls.Add(this.btnDangKyLe);
            this.Controls.Add(this.btnDangKyDoan);
            this.Controls.Add(this.btnPhanCong);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý công ty du lịch Văn Hóa Việt";
            this.ResumeLayout(false);
        }
    }
}