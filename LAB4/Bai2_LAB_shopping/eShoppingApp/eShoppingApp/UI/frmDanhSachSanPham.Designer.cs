namespace eShoppingApp.UI
{
    partial class frmDanhSachSanPham
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
            this.lblNhomSP = new System.Windows.Forms.Label();
            this.cbNhomSP = new System.Windows.Forms.ComboBox();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.btnThemGio = new System.Windows.Forms.Button();
            this.lblGioHang = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.btnXoaKhoiGio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(280, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(430, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "e-SHOPPING - MUA SẮM TRỰC TUYẾN";
            // 
            // lblNhomSP
            // 
            this.lblNhomSP.AutoSize = true;
            this.lblNhomSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomSP.Location = new System.Drawing.Point(20, 65);
            this.lblNhomSP.Name = "lblNhomSP";
            this.lblNhomSP.Size = new System.Drawing.Size(115, 19);
            this.lblNhomSP.TabIndex = 1;
            this.lblNhomSP.Text = "Nhóm sản phẩm:";
            // 
            // cbNhomSP
            // 
            this.cbNhomSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhomSP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhomSP.FormattingEnabled = true;
            this.cbNhomSP.Location = new System.Drawing.Point(140, 62);
            this.cbNhomSP.Name = "cbNhomSP";
            this.cbNhomSP.Size = new System.Drawing.Size(330, 25);
            this.cbNhomSP.TabIndex = 2;
            this.cbNhomSP.SelectedIndexChanged += new System.EventHandler(this.cbNhomSP_SelectedIndexChanged);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(20, 95);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(450, 360);
            this.dgvSanPham.TabIndex = 3;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.BackColor = System.Drawing.Color.Teal;
            this.btnXemChiTiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemChiTiet.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemChiTiet.ForeColor = System.Drawing.Color.White;
            this.btnXemChiTiet.Location = new System.Drawing.Point(20, 465);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(150, 40);
            this.btnXemChiTiet.TabIndex = 4;
            this.btnXemChiTiet.Text = "Xem chi tiết SP";
            this.btnXemChiTiet.UseVisualStyleBackColor = false;
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnThemGio
            // 
            this.btnThemGio.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemGio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGio.ForeColor = System.Drawing.Color.White;
            this.btnThemGio.Location = new System.Drawing.Point(180, 465);
            this.btnThemGio.Name = "btnThemGio";
            this.btnThemGio.Size = new System.Drawing.Size(290, 40);
            this.btnThemGio.TabIndex = 5;
            this.btnThemGio.Text = "Thêm vào giỏ hàng >>";
            this.btnThemGio.UseVisualStyleBackColor = false;
            this.btnThemGio.Click += new System.EventHandler(this.btnThemGio_Click);
            // 
            // lblGioHang
            // 
            this.lblGioHang.AutoSize = true;
            this.lblGioHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioHang.Location = new System.Drawing.Point(500, 65);
            this.lblGioHang.Name = "lblGioHang";
            this.lblGioHang.Size = new System.Drawing.Size(133, 20);
            this.lblGioHang.TabIndex = 6;
            this.lblGioHang.Text = "Giỏ Hàng Hiện Tại:";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(500, 95);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(460, 310);
            this.dgvGioHang.TabIndex = 7;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(500, 418);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(182, 21);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "Tổng cộng: 0 VNĐ";
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.BackColor = System.Drawing.Color.DarkOrange;
            this.btnTinhTien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinhTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.ForeColor = System.Drawing.Color.White;
            this.btnTinhTien.Location = new System.Drawing.Point(740, 465);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(220, 40);
            this.btnTinhTien.TabIndex = 10;
            this.btnTinhTien.Text = "TÍNH TIỀN (ĐẶT HÀNG)";
            this.btnTinhTien.UseVisualStyleBackColor = false;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // btnXoaKhoiGio
            // 
            this.btnXoaKhoiGio.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaKhoiGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoiGio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKhoiGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(500, 465);
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(120, 40);
            this.btnXoaKhoiGio.TabIndex = 9;
            this.btnXoaKhoiGio.Text = "Xóa khỏi giỏ";
            this.btnXoaKhoiGio.UseVisualStyleBackColor = false;
            this.btnXoaKhoiGio.Click += new System.EventHandler(this.btnXoaKhoiGio_Click);
            // 
            // frmDanhSachSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 521);
            this.Controls.Add(this.btnXemChiTiet);
            this.Controls.Add(this.btnXoaKhoiGio);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.lblGioHang);
            this.Controls.Add(this.btnThemGio);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.cbNhomSP);
            this.Controls.Add(this.lblNhomSP);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDanhSachSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Online e-SHOPPING";
            this.Load += new System.EventHandler(this.frmDanhSachSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNhomSP;
        private System.Windows.Forms.ComboBox cbNhomSP;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.Button btnXemChiTiet;
        private System.Windows.Forms.Button btnThemGio;
        private System.Windows.Forms.Label lblGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnXoaKhoiGio;
    }
}