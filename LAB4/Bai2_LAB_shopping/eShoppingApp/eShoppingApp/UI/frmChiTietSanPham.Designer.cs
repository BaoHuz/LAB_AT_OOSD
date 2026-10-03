namespace eShoppingApp.UI
{
    partial class frmChiTietSanPham
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

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblNhaSX = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.lblTinhTrang = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(120, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 25);
            this.lblTitle.Text = "THÔNG TIN SẢN PHẨM";
            // 
            // lblTenSP
            // 
            this.lblTenSP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTenSP.Location = new System.Drawing.Point(20, 50);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(400, 25);
            this.lblTenSP.Text = "Tên sản phẩm: ";
            // 
            // lblNhaSX
            // 
            this.lblNhaSX.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNhaSX.Location = new System.Drawing.Point(20, 80);
            this.lblNhaSX.Name = "lblNhaSX";
            this.lblNhaSX.Size = new System.Drawing.Size(400, 20);
            this.lblNhaSX.Text = "Nhà sản xuất: ";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGiaBan.ForeColor = System.Drawing.Color.Red;
            this.lblGiaBan.Location = new System.Drawing.Point(20, 105);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(400, 20);
            this.lblGiaBan.Text = "Giá bán: ";
            // 
            // lblTinhTrang
            // 
            this.lblTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTinhTrang.Location = new System.Drawing.Point(20, 130);
            this.lblTinhTrang.Name = "lblTinhTrang";
            this.lblTinhTrang.Size = new System.Drawing.Size(400, 20);
            this.lblTinhTrang.Text = "Tình trạng: ";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(20, 180);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ReadOnly = true;
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(400, 120);
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMoTa.Location = new System.Drawing.Point(20, 155);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(126, 17);
            this.lblMoTa.Text = "Mô tả / Thông số KT:";
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Gray;
            this.btnDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(320, 315);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // frmChiTietSanPham
            // 
            this.ClientSize = new System.Drawing.Size(444, 361);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblMoTa);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblTinhTrang);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblNhaSX);
            this.Controls.Add(this.lblTenSP);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi Tiết Sản Phẩm";
            this.Load += new System.EventHandler(this.frmChiTietSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblNhaSX;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.Label lblTinhTrang;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Button btnDong;
    }
}