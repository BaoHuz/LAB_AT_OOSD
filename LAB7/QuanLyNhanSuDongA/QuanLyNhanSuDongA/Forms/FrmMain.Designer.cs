namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnTuyenDung = new System.Windows.Forms.Button();
            this.btnHopDongBaoHiem = new System.Windows.Forms.Button();
            this.btnQDLuongChucVu = new System.Windows.Forms.Button();
            this.btnKeHoachChamCong = new System.Windows.Forms.Button();
            this.btnPhuTroi = new System.Windows.Forms.Button();
            this.btnKhenThuongKyLuat = new System.Windows.Forms.Button();
            this.btnBangLuongThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(45)))), ((int)(((byte)(95)))));
            this.lblTitle.Location = new System.Drawing.Point(175, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CÔNG TY CỔ PHẦN SƠN ĐÔNG Á";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDanhMuc.Location = new System.Drawing.Point(80, 80);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(300, 50);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "Danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            this.btnTuyenDung.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTuyenDung.Location = new System.Drawing.Point(400, 80);
            this.btnTuyenDung.Name = "btnTuyenDung";
            this.btnTuyenDung.Size = new System.Drawing.Size(300, 50);
            this.btnTuyenDung.TabIndex = 2;
            this.btnTuyenDung.Text = "Tuyển dụng – thử việc";
            this.btnTuyenDung.UseVisualStyleBackColor = true;
            this.btnTuyenDung.Click += new System.EventHandler(this.btnTuyenDung_Click);
            this.btnHopDongBaoHiem.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnHopDongBaoHiem.Location = new System.Drawing.Point(80, 145);
            this.btnHopDongBaoHiem.Name = "btnHopDongBaoHiem";
            this.btnHopDongBaoHiem.Size = new System.Drawing.Size(300, 50);
            this.btnHopDongBaoHiem.TabIndex = 3;
            this.btnHopDongBaoHiem.Text = "Hợp đồng – bảo hiểm";
            this.btnHopDongBaoHiem.UseVisualStyleBackColor = true;
            this.btnHopDongBaoHiem.Click += new System.EventHandler(this.btnHopDongBaoHiem_Click);
            this.btnQDLuongChucVu.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnQDLuongChucVu.Location = new System.Drawing.Point(400, 145);
            this.btnQDLuongChucVu.Name = "btnQDLuongChucVu";
            this.btnQDLuongChucVu.Size = new System.Drawing.Size(300, 50);
            this.btnQDLuongChucVu.TabIndex = 4;
            this.btnQDLuongChucVu.Text = "Quyết định lương – chức vụ";
            this.btnQDLuongChucVu.UseVisualStyleBackColor = true;
            this.btnQDLuongChucVu.Click += new System.EventHandler(this.btnQDLuongChucVu_Click);
            this.btnKeHoachChamCong.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnKeHoachChamCong.Location = new System.Drawing.Point(80, 210);
            this.btnKeHoachChamCong.Name = "btnKeHoachChamCong";
            this.btnKeHoachChamCong.Size = new System.Drawing.Size(300, 50);
            this.btnKeHoachChamCong.TabIndex = 5;
            this.btnKeHoachChamCong.Text = "Kế hoạch – chấm công";
            this.btnKeHoachChamCong.UseVisualStyleBackColor = true;
            this.btnKeHoachChamCong.Click += new System.EventHandler(this.btnKeHoachChamCong_Click);
            this.btnPhuTroi.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPhuTroi.Location = new System.Drawing.Point(400, 210);
            this.btnPhuTroi.Name = "btnPhuTroi";
            this.btnPhuTroi.Size = new System.Drawing.Size(300, 50);
            this.btnPhuTroi.TabIndex = 6;
            this.btnPhuTroi.Text = "Phiếu phụ trội";
            this.btnPhuTroi.UseVisualStyleBackColor = true;
            this.btnPhuTroi.Click += new System.EventHandler(this.btnPhuTroi_Click);
            this.btnKhenThuongKyLuat.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnKhenThuongKyLuat.Location = new System.Drawing.Point(80, 275);
            this.btnKhenThuongKyLuat.Name = "btnKhenThuongKyLuat";
            this.btnKhenThuongKyLuat.Size = new System.Drawing.Size(300, 50);
            this.btnKhenThuongKyLuat.TabIndex = 7;
            this.btnKhenThuongKyLuat.Text = "Khen thưởng – kỷ luật";
            this.btnKhenThuongKyLuat.UseVisualStyleBackColor = true;
            this.btnKhenThuongKyLuat.Click += new System.EventHandler(this.btnKhenThuongKyLuat_Click);
            this.btnBangLuongThongKe.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnBangLuongThongKe.Location = new System.Drawing.Point(400, 275);
            this.btnBangLuongThongKe.Name = "btnBangLuongThongKe";
            this.btnBangLuongThongKe.Size = new System.Drawing.Size(300, 50);
            this.btnBangLuongThongKe.TabIndex = 8;
            this.btnBangLuongThongKe.Text = "Bảng lương – thống kê";
            this.btnBangLuongThongKe.UseVisualStyleBackColor = true;
            this.btnBangLuongThongKe.Click += new System.EventHandler(this.btnBangLuongThongKe_Click);
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnThoat.Location = new System.Drawing.Point(240, 350);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(300, 50);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(780, 430);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBangLuongThongKe);
            this.Controls.Add(this.btnKhenThuongKyLuat);
            this.Controls.Add(this.btnPhuTroi);
            this.Controls.Add(this.btnKeHoachChamCong);
            this.Controls.Add(this.btnQDLuongChucVu);
            this.Controls.Add(this.btnHopDongBaoHiem);
            this.Controls.Add(this.btnTuyenDung);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân sự công ty sơn Đông Á";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnTuyenDung;
        private System.Windows.Forms.Button btnHopDongBaoHiem;
        private System.Windows.Forms.Button btnQDLuongChucVu;
        private System.Windows.Forms.Button btnKeHoachChamCong;
        private System.Windows.Forms.Button btnPhuTroi;
        private System.Windows.Forms.Button btnKhenThuongKyLuat;
        private System.Windows.Forms.Button btnBangLuongThongKe;
        private System.Windows.Forms.Button btnThoat;
    }
}