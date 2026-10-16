namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmLapToa
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
            this.grpThongTinPhieu = new System.Windows.Forms.GroupBox();
            this.lblMaToa = new System.Windows.Forms.Label();
            this.txtMaToa = new System.Windows.Forms.TextBox();
            this.lblMaPK = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblMaBS = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.lblChanDoan = new System.Windows.Forms.Label();
            this.txtChanDoan = new System.Windows.Forms.TextBox();

            this.grpKeThuoc = new System.Windows.Forms.GroupBox();
            this.lblThuoc = new System.Windows.Forms.Label();
            this.cboThuoc = new System.Windows.Forms.ComboBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblLieuDung = new System.Windows.Forms.Label();
            this.txtLieuDung = new System.Windows.Forms.TextBox();
            this.lblCachDung = new System.Windows.Forms.Label();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.btnThemThuoc = new System.Windows.Forms.Button();
            this.btnXoaThuoc = new System.Windows.Forms.Button();

            this.grpDanhSachThuoc = new System.Windows.Forms.GroupBox();
            this.dgvChiTietToa = new System.Windows.Forms.DataGridView();

            this.lblDanDo = new System.Windows.Forms.Label();
            this.txtDanDo = new System.Windows.Forms.TextBox();

            this.btnLuuToa = new System.Windows.Forms.Button();
            this.btnInToa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            this.grpThongTinPhieu.SuspendLayout();
            this.grpKeThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.grpDanhSachThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietToa)).BeginInit();
            this.SuspendLayout();

            // 
            // grpThongTinPhieu
            // 
            this.grpThongTinPhieu.Controls.Add(this.lblMaToa);
            this.grpThongTinPhieu.Controls.Add(this.txtMaToa);
            this.grpThongTinPhieu.Controls.Add(this.lblMaPK);
            this.grpThongTinPhieu.Controls.Add(this.txtMaPhieuKham);
            this.grpThongTinPhieu.Controls.Add(this.lblMaBS);
            this.grpThongTinPhieu.Controls.Add(this.txtMaBS);
            this.grpThongTinPhieu.Controls.Add(this.lblChanDoan);
            this.grpThongTinPhieu.Controls.Add(this.txtChanDoan);
            this.grpThongTinPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTinPhieu.Location = new System.Drawing.Point(12, 12);
            this.grpThongTinPhieu.Name = "grpThongTinPhieu";
            this.grpThongTinPhieu.Size = new System.Drawing.Size(760, 110);
            this.grpThongTinPhieu.TabIndex = 0;
            this.grpThongTinPhieu.TabStop = false;
            this.grpThongTinPhieu.Text = "THÔNG TIN PHIẾU KHÁM & MÃ TOA";

            // lblMaToa & txtMaToa
            this.lblMaToa.Location = new System.Drawing.Point(15, 28);
            this.lblMaToa.Size = new System.Drawing.Size(60, 20);
            this.lblMaToa.Text = "Mã toa:";
            this.txtMaToa.Location = new System.Drawing.Point(80, 25);
            this.txtMaToa.Size = new System.Drawing.Size(150, 23);

            // lblMaPK & txtMaPhieuKham
            this.lblMaPK.Location = new System.Drawing.Point(250, 28);
            this.lblMaPK.Size = new System.Drawing.Size(70, 20);
            this.lblMaPK.Text = "Mã phiếu:";
            this.txtMaPhieuKham.Location = new System.Drawing.Point(320, 25);
            this.txtMaPhieuKham.Size = new System.Drawing.Size(150, 23);

            // lblMaBS & txtMaBS
            this.lblMaBS.Location = new System.Drawing.Point(490, 28);
            this.lblMaBS.Size = new System.Drawing.Size(60, 20);
            this.lblMaBS.Text = "Bác sĩ:";
            this.txtMaBS.Location = new System.Drawing.Point(550, 25);
            this.txtMaBS.Size = new System.Drawing.Size(190, 23);
            this.txtMaBS.ReadOnly = true;

            // lblChanDoan & txtChanDoan
            this.lblChanDoan.Location = new System.Drawing.Point(15, 65);
            this.lblChanDoan.Size = new System.Drawing.Size(70, 20);
            this.lblChanDoan.Text = "Chẩn đoán:";
            this.txtChanDoan.Location = new System.Drawing.Point(80, 62);
            this.txtChanDoan.Size = new System.Drawing.Size(660, 23);
            this.txtChanDoan.ReadOnly = true;

            // 
            // grpKeThuoc
            // 
            this.grpKeThuoc.Controls.Add(this.lblThuoc);
            this.grpKeThuoc.Controls.Add(this.cboThuoc);
            this.grpKeThuoc.Controls.Add(this.lblSoLuong);
            this.grpKeThuoc.Controls.Add(this.numSoLuong);
            this.grpKeThuoc.Controls.Add(this.lblLieuDung);
            this.grpKeThuoc.Controls.Add(this.txtLieuDung);
            this.grpKeThuoc.Controls.Add(this.lblCachDung);
            this.grpKeThuoc.Controls.Add(this.txtCachDung);
            this.grpKeThuoc.Controls.Add(this.btnThemThuoc);
            this.grpKeThuoc.Controls.Add(this.btnXoaThuoc);
            this.grpKeThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpKeThuoc.Location = new System.Drawing.Point(12, 130);
            this.grpKeThuoc.Name = "grpKeThuoc";
            this.grpKeThuoc.Size = new System.Drawing.Size(760, 100);
            this.grpKeThuoc.TabIndex = 1;
            this.grpKeThuoc.TabStop = false;
            this.grpKeThuoc.Text = "KÊ THUỐC ĐIỀU TRỊ";

            // lblThuoc & cboThuoc
            this.lblThuoc.Location = new System.Drawing.Point(15, 28);
            this.lblThuoc.Text = "Chọn thuốc:";
            this.cboThuoc.Location = new System.Drawing.Point(90, 25);
            this.cboThuoc.Size = new System.Drawing.Size(260, 23);
            this.cboThuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblSoLuong & numSoLuong
            this.lblSoLuong.Location = new System.Drawing.Point(370, 28);
            this.lblSoLuong.Text = "Số lượng:";
            this.numSoLuong.Location = new System.Drawing.Point(435, 25);
            this.numSoLuong.Size = new System.Drawing.Size(70, 23);
            this.numSoLuong.Minimum = 1;
            this.numSoLuong.Maximum = 500;
            this.numSoLuong.Value = 10;

            // btnThemThuoc & btnXoaThuoc
            this.btnThemThuoc.Location = new System.Drawing.Point(530, 23);
            this.btnThemThuoc.Size = new System.Drawing.Size(100, 28);
            this.btnThemThuoc.Text = "+ Thêm thuốc";
            this.btnThemThuoc.UseVisualStyleBackColor = true;
            this.btnThemThuoc.Click += new System.EventHandler(this.btnThemThuoc_Click);

            this.btnXoaThuoc.Location = new System.Drawing.Point(640, 23);
            this.btnXoaThuoc.Size = new System.Drawing.Size(100, 28);
            this.btnXoaThuoc.Text = "- Xóa dòng";
            this.btnXoaThuoc.UseVisualStyleBackColor = true;
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);

            // lblLieuDung & txtLieuDung
            this.lblLieuDung.Location = new System.Drawing.Point(15, 62);
            this.lblLieuDung.Text = "Liều dùng:";
            this.txtLieuDung.Location = new System.Drawing.Point(90, 59);
            this.txtLieuDung.Size = new System.Drawing.Size(260, 23);

            // lblCachDung & txtCachDung
            this.lblCachDung.Location = new System.Drawing.Point(370, 62);
            this.lblCachDung.Text = "Cách dùng:";
            this.txtCachDung.Location = new System.Drawing.Point(435, 59);
            this.txtCachDung.Size = new System.Drawing.Size(305, 23);

            // 
            // grpDanhSachThuoc
            // 
            this.grpDanhSachThuoc.Controls.Add(this.dgvChiTietToa);
            this.grpDanhSachThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDanhSachThuoc.Location = new System.Drawing.Point(12, 240);
            this.grpDanhSachThuoc.Name = "grpDanhSachThuoc";
            this.grpDanhSachThuoc.Size = new System.Drawing.Size(760, 200);
            this.grpDanhSachThuoc.TabIndex = 2;
            this.grpDanhSachThuoc.TabStop = false;
            this.grpDanhSachThuoc.Text = "DANH SÁCH THUỐC TRONG TOA";

            // dgvChiTietToa
            this.dgvChiTietToa.AllowUserToAddRows = false;
            this.dgvChiTietToa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietToa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietToa.Location = new System.Drawing.Point(3, 19);
            this.dgvChiTietToa.Name = "dgvChiTietToa";
            this.dgvChiTietToa.ReadOnly = true;
            this.dgvChiTietToa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietToa.Size = new System.Drawing.Size(754, 178);

            // 
            // lblDanDo & txtDanDo
            // 
            this.lblDanDo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDanDo.Location = new System.Drawing.Point(12, 450);
            this.lblDanDo.Size = new System.Drawing.Size(120, 20);
            this.lblDanDo.Text = "Lời dặn bác sĩ:";

            this.txtDanDo.Location = new System.Drawing.Point(12, 470);
            this.txtDanDo.Multiline = true;
            this.txtDanDo.Size = new System.Drawing.Size(760, 50);

            // 
            // Buttons: Lưu, In, Đóng
            // 
            this.btnLuuToa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuuToa.Location = new System.Drawing.Point(420, 530);
            this.btnLuuToa.Size = new System.Drawing.Size(110, 32);
            this.btnLuuToa.Text = "💾 Lưu Toa Thuốc";
            this.btnLuuToa.UseVisualStyleBackColor = true;
            this.btnLuuToa.Click += new System.EventHandler(this.btnLuuToa_Click);

            this.btnInToa.Enabled = false;
            this.btnInToa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnInToa.Location = new System.Drawing.Point(540, 530);
            this.btnInToa.Size = new System.Drawing.Size(110, 32);
            this.btnInToa.Text = "🖨️ In Toa Thuốc";
            this.btnInToa.UseVisualStyleBackColor = true;
            this.btnInToa.Click += new System.EventHandler(this.btnInToa_Click);

            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.Location = new System.Drawing.Point(660, 530);
            this.btnDong.Size = new System.Drawing.Size(110, 32);
            this.btnDong.Text = "Thoát";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            // 
            // FrmLapToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 575);
            this.Controls.Add(this.grpThongTinPhieu);
            this.Controls.Add(this.grpKeThuoc);
            this.Controls.Add(this.grpDanhSachThuoc);
            this.Controls.Add(this.lblDanDo);
            this.Controls.Add(this.txtDanDo);
            this.Controls.Add(this.btnLuuToa);
            this.Controls.Add(this.btnInToa);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLapToa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LẬP TOA THUỐC ĐIỀU TRỊ - BỆNH VIỆN ĐA KHOA";
            this.Load += new System.EventHandler(this.FrmLapToa_Load);

            this.grpThongTinPhieu.ResumeLayout(false);
            this.grpThongTinPhieu.PerformLayout();
            this.grpKeThuoc.ResumeLayout(false);
            this.grpKeThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.grpDanhSachThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietToa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTinPhieu;
        private System.Windows.Forms.Label lblMaToa;
        private System.Windows.Forms.TextBox txtMaToa;
        private System.Windows.Forms.Label lblMaPK;
        private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label lblMaBS;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Label lblChanDoan;
        private System.Windows.Forms.TextBox txtChanDoan;

        private System.Windows.Forms.GroupBox grpKeThuoc;
        private System.Windows.Forms.Label lblThuoc;
        private System.Windows.Forms.ComboBox cboThuoc;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblLieuDung;
        private System.Windows.Forms.TextBox txtLieuDung;
        private System.Windows.Forms.Label lblCachDung;
        private System.Windows.Forms.TextBox txtCachDung;
        private System.Windows.Forms.Button btnThemThuoc;
        private System.Windows.Forms.Button btnXoaThuoc;

        private System.Windows.Forms.GroupBox grpDanhSachThuoc;
        private System.Windows.Forms.DataGridView dgvChiTietToa;

        private System.Windows.Forms.Label lblDanDo;
        private System.Windows.Forms.TextBox txtDanDo;

        private System.Windows.Forms.Button btnLuuToa;
        private System.Windows.Forms.Button btnInToa;
        private System.Windows.Forms.Button btnDong;
    }
}