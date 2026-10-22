namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmThanhToan
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
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaPhieuKham
            // 
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(30, 30);
            this.lblMaPhieuKham.Name = "lblMaPhieuKham";
            this.lblMaPhieuKham.Size = new System.Drawing.Size(101, 16);
            this.lblMaPhieuKham.Text = "Mã phiếu khám:";
            // 
            // txtMaPhieuKham
            // 
            this.txtMaPhieuKham.Location = new System.Drawing.Point(145, 27);
            this.txtMaPhieuKham.Name = "txtMaPhieuKham";
            this.txtMaPhieuKham.Size = new System.Drawing.Size(200, 22);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(30, 75);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(106, 16);
            this.lblTongTien.Text = "Tổng tiền (VNĐ):";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(145, 72);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(200, 22);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(195, 120);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(150, 35);
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // FrmThanhToan
            // 
            this.ClientSize = new System.Drawing.Size(380, 180);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtMaPhieuKham);
            this.Controls.Add(this.lblMaPhieuKham);
            this.Name = "FrmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THANH TOÁN VIỆN PHÍ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaPhieuKham;
        private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThanhToan;
    }
}