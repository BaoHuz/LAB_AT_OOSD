namespace eShoppingApp.UI
{
    partial class frmThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbNguoiNhan = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.gbGiaoHang = new System.Windows.Forms.GroupBox();
            this.cbKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.cbLoaiPhieu = new System.Windows.Forms.ComboBox();
            this.lblLoaiPhieu = new System.Windows.Forms.Label();
            this.gbThanhToan = new System.Windows.Forms.GroupBox();
            this.txtChuThe = new System.Windows.Forms.TextBox();
            this.lblChuThe = new System.Windows.Forms.Label();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.txtCSV = new System.Windows.Forms.TextBox();
            this.lblCSV = new System.Windows.Forms.Label();
            this.txtSoThe = new System.Windows.Forms.TextBox();
            this.lblSoThe = new System.Windows.Forms.Label();
            this.cbLoaiThe = new System.Windows.Forms.ComboBox();
            this.lblLoaiThe = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.gbNguoiNhan.SuspendLayout();
            this.gbGiaoHang.SuspendLayout();
            this.gbThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(60, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(437, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "XÁC NHẬN ĐƠN HÀNG VÀ THANH TOÁN THẺ";
            // 
            // gbNguoiNhan
            // 
            this.gbNguoiNhan.Controls.Add(this.txtEmail);
            this.gbNguoiNhan.Controls.Add(this.lblEmail);
            this.gbNguoiNhan.Controls.Add(this.txtSDT);
            this.gbNguoiNhan.Controls.Add(this.lblSDT);
            this.gbNguoiNhan.Controls.Add(this.txtDiaChi);
            this.gbNguoiNhan.Controls.Add(this.lblDiaChi);
            this.gbNguoiNhan.Controls.Add(this.txtHoTen);
            this.gbNguoiNhan.Controls.Add(this.lblHoTen);
            this.gbNguoiNhan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNguoiNhan.Location = new System.Drawing.Point(20, 50);
            this.gbNguoiNhan.Name = "gbNguoiNhan";
            this.gbNguoiNhan.Size = new System.Drawing.Size(510, 160);
            this.gbNguoiNhan.TabIndex = 1;
            this.gbNguoiNhan.TabStop = false;
            this.gbNguoiNhan.Text = "1. Thông tin người nhận hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(120, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 23);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "an.nguyen@gmail.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(15, 123);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(120, 90);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(360, 23);
            this.txtSDT.TabIndex = 5;
            this.txtSDT.Text = "0903123456";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(15, 93);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(79, 15);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(120, 60);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(360, 23);
            this.txtDiaChi.TabIndex = 3;
            this.txtDiaChi.Text = "123 Nguyễn Huệ, Quận 1, TP.HCM";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(15, 63);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(104, 15);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ giao hàng:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(120, 30);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(360, 23);
            this.txtHoTen.TabIndex = 1;
            this.txtHoTen.Text = "Nguyễn Văn An";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(15, 33);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(96, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ tên người nhận:";
            // 
            // gbGiaoHang
            // 
            this.gbGiaoHang.Controls.Add(this.cbKhuVuc);
            this.gbGiaoHang.Controls.Add(this.lblKhuVuc);
            this.gbGiaoHang.Controls.Add(this.cbLoaiPhieu);
            this.gbGiaoHang.Controls.Add(this.lblLoaiPhieu);
            this.gbGiaoHang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGiaoHang.Location = new System.Drawing.Point(20, 220);
            this.gbGiaoHang.Name = "gbGiaoHang";
            this.gbGiaoHang.Size = new System.Drawing.Size(510, 90);
            this.gbGiaoHang.TabIndex = 2;
            this.gbGiaoHang.TabStop = false;
            this.gbGiaoHang.Text = "2. Hình thức giao hàng";
            // 
            // cbKhuVuc
            // 
            this.cbKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKhuVuc.FormattingEnabled = true;
            this.cbKhuVuc.Items.AddRange(new object[] {
            "NoiThanh",
            "NgoaiThanh"});
            this.cbKhuVuc.Location = new System.Drawing.Point(340, 35);
            this.cbKhuVuc.Name = "cbKhuVuc";
            this.cbKhuVuc.Size = new System.Drawing.Size(140, 23);
            this.cbKhuVuc.TabIndex = 3;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuVuc.Location = new System.Drawing.Point(280, 38);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(54, 15);
            this.lblKhuVuc.TabIndex = 2;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // cbLoaiPhieu
            // 
            this.cbLoaiPhieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhieu.FormattingEnabled = true;
            this.cbLoaiPhieu.Items.AddRange(new object[] {
            "THUONG",
            "CPN",
            "CPN_TRONG_NGAY"});
            this.cbLoaiPhieu.Location = new System.Drawing.Point(120, 35);
            this.cbLoaiPhieu.Name = "cbLoaiPhieu";
            this.cbLoaiPhieu.Size = new System.Drawing.Size(140, 23);
            this.cbLoaiPhieu.TabIndex = 1;
            // 
            // lblLoaiPhieu
            // 
            this.lblLoaiPhieu.AutoSize = true;
            this.lblLoaiPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhieu.Location = new System.Drawing.Point(15, 38);
            this.lblLoaiPhieu.Name = "lblLoaiPhieu";
            this.lblLoaiPhieu.Size = new System.Drawing.Size(66, 15);
            this.lblLoaiPhieu.TabIndex = 0;
            this.lblLoaiPhieu.Text = "Loại phiếu:";
            // 
            // gbThanhToan
            // 
            this.gbThanhToan.Controls.Add(this.txtChuThe);
            this.gbThanhToan.Controls.Add(this.lblChuThe);
            this.gbThanhToan.Controls.Add(this.txtExpiry);
            this.gbThanhToan.Controls.Add(this.lblExpiry);
            this.gbThanhToan.Controls.Add(this.txtCSV);
            this.gbThanhToan.Controls.Add(this.lblCSV);
            this.gbThanhToan.Controls.Add(this.txtSoThe);
            this.gbThanhToan.Controls.Add(this.lblSoThe);
            this.gbThanhToan.Controls.Add(this.cbLoaiThe);
            this.gbThanhToan.Controls.Add(this.lblLoaiThe);
            this.gbThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThanhToan.Location = new System.Drawing.Point(20, 320);
            this.gbThanhToan.Name = "gbThanhToan";
            this.gbThanhToan.Size = new System.Drawing.Size(510, 160);
            this.gbThanhToan.TabIndex = 3;
            this.gbThanhToan.TabStop = false;
            this.gbThanhToan.Text = "3. Thông tin thẻ tín dụng";
            // 
            // txtChuThe
            // 
            this.txtChuThe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuThe.Location = new System.Drawing.Point(120, 120);
            this.txtChuThe.Name = "txtChuThe";
            this.txtChuThe.Size = new System.Drawing.Size(360, 23);
            this.txtChuThe.TabIndex = 9;
            this.txtChuThe.Text = "NGUYEN VAN AN";
            // 
            // lblChuThe
            // 
            this.lblChuThe.AutoSize = true;
            this.lblChuThe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuThe.Location = new System.Drawing.Point(15, 123);
            this.lblChuThe.Name = "lblChuThe";
            this.lblChuThe.Size = new System.Drawing.Size(73, 15);
            this.lblChuThe.TabIndex = 8;
            this.lblChuThe.Text = "Tên chủ thẻ:";
            // 
            // txtExpiry
            // 
            this.txtExpiry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiry.Location = new System.Drawing.Point(380, 90);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(100, 23);
            this.txtExpiry.TabIndex = 7;
            this.txtExpiry.Text = "12/28";
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiry.Location = new System.Drawing.Point(280, 93);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(95, 15);
            this.lblExpiry.TabIndex = 6;
            this.lblExpiry.Text = "Hạn dùng (MM/YY):";
            // 
            // txtCSV
            // 
            this.txtCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCSV.Location = new System.Drawing.Point(120, 90);
            this.txtCSV.Name = "txtCSV";
            this.txtCSV.Size = new System.Drawing.Size(140, 23);
            this.txtCSV.TabIndex = 5;
            this.txtCSV.Text = "123";
            // 
            // lblCSV
            // 
            this.lblCSV.AutoSize = true;
            this.lblCSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCSV.Location = new System.Drawing.Point(15, 93);
            this.lblCSV.Name = "lblCSV";
            this.lblCSV.Size = new System.Drawing.Size(53, 15);
            this.lblCSV.TabIndex = 4;
            this.lblCSV.Text = "Mã CSV:";
            // 
            // txtSoThe
            // 
            this.txtSoThe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoThe.Location = new System.Drawing.Point(120, 60);
            this.txtSoThe.Name = "txtSoThe";
            this.txtSoThe.Size = new System.Drawing.Size(360, 23);
            this.txtSoThe.TabIndex = 3;
            this.txtSoThe.Text = "4111222233331234";
            // 
            // lblSoThe
            // 
            this.lblSoThe.AutoSize = true;
            this.lblSoThe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoThe.Location = new System.Drawing.Point(15, 63);
            this.lblSoThe.Name = "lblSoThe";
            this.lblSoThe.Size = new System.Drawing.Size(43, 15);
            this.lblSoThe.TabIndex = 2;
            this.lblSoThe.Text = "Số thẻ:";
            // 
            // cbLoaiThe
            // 
            this.cbLoaiThe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiThe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiThe.FormattingEnabled = true;
            this.cbLoaiThe.Items.AddRange(new object[] {
            "VISA",
            "Master",
            "Discover",
            "Amex"});
            this.cbLoaiThe.Location = new System.Drawing.Point(120, 30);
            this.cbLoaiThe.Name = "cbLoaiThe";
            this.cbLoaiThe.Size = new System.Drawing.Size(140, 23);
            this.cbLoaiThe.TabIndex = 1;
            // 
            // lblLoaiThe
            // 
            this.lblLoaiThe.AutoSize = true;
            this.lblLoaiThe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiThe.Location = new System.Drawing.Point(15, 33);
            this.lblLoaiThe.Name = "lblLoaiThe";
            this.lblLoaiThe.Size = new System.Drawing.Size(52, 15);
            this.lblLoaiThe.TabIndex = 0;
            this.lblLoaiThe.Text = "Loại thẻ:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(20, 495);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(199, 21);
            this.lblTongTien.TabIndex = 4;
            this.lblTongTien.Text = "TỔNG THANH TOÁN: 0 VNĐ";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.ForestGreen;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(300, 530);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(140, 40);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "XÁC NHẬN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Gray;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(450, 530);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(80, 40);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 591);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.gbThanhToan);
            this.Controls.Add(this.gbGiaoHang);
            this.Controls.Add(this.gbNguoiNhan);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán Đơn hàng e-SHOPPING";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.gbNguoiNhan.ResumeLayout(false);
            this.gbNguoiNhan.PerformLayout();
            this.gbGiaoHang.ResumeLayout(false);
            this.gbGiaoHang.PerformLayout();
            this.gbThanhToan.ResumeLayout(false);
            this.gbThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbNguoiNhan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.GroupBox gbGiaoHang;
        private System.Windows.Forms.ComboBox cbKhuVuc;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.ComboBox cbLoaiPhieu;
        private System.Windows.Forms.Label lblLoaiPhieu;
        private System.Windows.Forms.GroupBox gbThanhToan;
        private System.Windows.Forms.TextBox txtChuThe;
        private System.Windows.Forms.Label lblChuThe;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.TextBox txtCSV;
        private System.Windows.Forms.Label lblCSV;
        private System.Windows.Forms.TextBox txtSoThe;
        private System.Windows.Forms.Label lblSoThe;
        private System.Windows.Forms.ComboBox cbLoaiThe;
        private System.Windows.Forms.Label lblLoaiThe;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuy;
    }
}