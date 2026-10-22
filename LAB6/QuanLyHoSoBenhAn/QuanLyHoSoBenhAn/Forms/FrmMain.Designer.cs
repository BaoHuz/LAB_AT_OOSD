namespace QuanLyHoSoBenhAn.Forms
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
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.btnLichHen = new System.Windows.Forms.Button();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTiepNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichHen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhamChua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhamBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXetNghiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLapToa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPhatThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoanTat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(116)))), ((int)(((byte)(144)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(684, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnTiepNhan);
            this.pnlButtons.Controls.Add(this.btnLichHen);
            this.pnlButtons.Controls.Add(this.btnKhamBenh);
            this.pnlButtons.Controls.Add(this.btnHoanTat);
            this.pnlButtons.Controls.Add(this.btnThoat);
            this.pnlButtons.Location = new System.Drawing.Point(142, 90);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(400, 310);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnTiepNhan.Location = new System.Drawing.Point(20, 10);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(360, 48);
            this.btnTiepNhan.TabIndex = 0;
            this.btnTiepNhan.Text = "Đăng ký mới && Cấp HSBA";
            this.btnTiepNhan.UseVisualStyleBackColor = true;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // btnLichHen
            // 
            this.btnLichHen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLichHen.Location = new System.Drawing.Point(20, 68);
            this.btnLichHen.Name = "btnLichHen";
            this.btnLichHen.Size = new System.Drawing.Size(360, 48);
            this.btnLichHen.TabIndex = 1;
            this.btnLichHen.Text = "Đặt lịch khám định kỳ";
            this.btnLichHen.UseVisualStyleBackColor = true;
            this.btnLichHen.Click += new System.EventHandler(this.btnLichHen_Click);
            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnKhamBenh.Location = new System.Drawing.Point(20, 126);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(360, 48);
            this.btnKhamBenh.TabIndex = 2;
            this.btnKhamBenh.Text = "Khám bệnh && Lập toa thuốc";
            this.btnKhamBenh.UseVisualStyleBackColor = true;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHoanTat.Location = new System.Drawing.Point(20, 184);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(360, 48);
            this.btnHoanTat.TabIndex = 3;
            this.btnHoanTat.Text = "Kết thúc && Chốt hồ sơ đợt khám";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnThoat.Location = new System.Drawing.Point(20, 242);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(360, 48);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát chương trình";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(425, 17);
            this.lblStatus.Text = "Hệ thống Quản lý Hồ sơ Bệnh án | SV: Nguyễn Hữu Bảo - MSSV: 1250080016";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTiepNhan,
            this.mnuKhamChua});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTiepNhan
            // 
            this.mnuTiepNhan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangKy,
            this.mnuHoSo,
            this.mnuLichHen});
            this.mnuTiepNhan.Name = "mnuTiepNhan";
            this.mnuTiepNhan.Size = new System.Drawing.Size(115, 20);
            this.mnuTiepNhan.Text = "Tiếp nhận && Hồ sơ";
            // 
            // mnuDangKy
            // 
            this.mnuDangKy.Name = "mnuDangKy";
            this.mnuDangKy.Size = new System.Drawing.Size(180, 22);
            this.mnuDangKy.Text = "1. Đăng ký mới";
            this.mnuDangKy.Click += new System.EventHandler(this.btnTiepNhan_Click);
            // 
            // mnuHoSo
            // 
            this.mnuHoSo.Name = "mnuHoSo";
            this.mnuHoSo.Size = new System.Drawing.Size(180, 22);
            this.mnuHoSo.Text = "2. Tra cứu Hồ sơ";
            this.mnuHoSo.Click += new System.EventHandler(this.mnuHoSo_Click);
            // 
            // mnuLichHen
            // 
            this.mnuLichHen.Name = "mnuLichHen";
            this.mnuLichHen.Size = new System.Drawing.Size(180, 22);
            this.mnuLichHen.Text = "3. Đặt Lịch hẹn";
            this.mnuLichHen.Click += new System.EventHandler(this.btnLichHen_Click);
            // 
            // mnuKhamChua
            // 
            this.mnuKhamChua.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhamBenh,
            this.mnuXetNghiem,
            this.mnuLapToa,
            this.mnuThanhToan,
            this.mnuPhatThuoc,
            this.mnuHoanTat});
            this.mnuKhamChua.Name = "mnuKhamChua";
            this.mnuKhamChua.Size = new System.Drawing.Size(118, 20);
            this.mnuKhamChua.Text = "Khám bệnh && Dịch vụ";
            // 
            // mnuKhamBenh
            // 
            this.mnuKhamBenh.Name = "mnuKhamBenh";
            this.mnuKhamBenh.Size = new System.Drawing.Size(180, 22);
            this.mnuKhamBenh.Text = "4. Phiếu khám bệnh";
            this.mnuKhamBenh.Click += new System.EventHandler(this.mnuKhamBenh_Click);
            // 
            // mnuXetNghiem
            // 
            this.mnuXetNghiem.Name = "mnuXetNghiem";
            this.mnuXetNghiem.Size = new System.Drawing.Size(180, 22);
            this.mnuXetNghiem.Text = "5. Cận lâm sàng / XN";
            this.mnuXetNghiem.Click += new System.EventHandler(this.mnuXetNghiem_Click);
            // 
            // mnuLapToa
            // 
            this.mnuLapToa.Name = "mnuLapToa";
            this.mnuLapToa.Size = new System.Drawing.Size(180, 22);
            this.mnuLapToa.Text = "6. Lập Toa thuốc";
            this.mnuLapToa.Click += new System.EventHandler(this.btnKhamBenh_Click);
            // 
            // mnuThanhToan
            // 
            this.mnuThanhToan.Name = "mnuThanhToan";
            this.mnuThanhToan.Size = new System.Drawing.Size(180, 22);
            this.mnuThanhToan.Text = "7. Thanh toán Viện phí";
            this.mnuThanhToan.Click += new System.EventHandler(this.mnuThanhToan_Click);
            // 
            // mnuPhatThuoc
            // 
            this.mnuPhatThuoc.Name = "mnuPhatThuoc";
            this.mnuPhatThuoc.Size = new System.Drawing.Size(180, 22);
            this.mnuPhatThuoc.Text = "8. Xác nhận Phát thuốc";
            this.mnuPhatThuoc.Click += new System.EventHandler(this.mnuPhatThuoc_Click);
            // 
            // mnuHoanTat
            // 
            this.mnuHoanTat.Name = "mnuHoanTat";
            this.mnuHoanTat.Size = new System.Drawing.Size(180, 22);
            this.mnuHoanTat.Text = "9. Chốt Hồ sơ đợt khám";
            this.mnuHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Hồ sơ Bệnh án - Bệnh viện Đa khoa";
            this.pnlButtons.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.Button btnLichHen;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTiepNhan;
        private System.Windows.Forms.ToolStripMenuItem mnuDangKy;
        private System.Windows.Forms.ToolStripMenuItem mnuHoSo;
        private System.Windows.Forms.ToolStripMenuItem mnuLichHen;
        private System.Windows.Forms.ToolStripMenuItem mnuKhamChua;
        private System.Windows.Forms.ToolStripMenuItem mnuKhamBenh;
        private System.Windows.Forms.ToolStripMenuItem mnuXetNghiem;
        private System.Windows.Forms.ToolStripMenuItem mnuLapToa;
        private System.Windows.Forms.ToolStripMenuItem mnuThanhToan;
        private System.Windows.Forms.ToolStripMenuItem mnuPhatThuoc;
        private System.Windows.Forms.ToolStripMenuItem mnuHoanTat;
    }
}