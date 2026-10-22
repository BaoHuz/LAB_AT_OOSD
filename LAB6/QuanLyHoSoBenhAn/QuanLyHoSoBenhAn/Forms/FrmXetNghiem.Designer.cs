namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmXetNghiem
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
            this.lblMaChiDinh = new System.Windows.Forms.Label();
            this.txtMaChiDinh = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnCapNhatKetQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaChiDinh
            // 
            this.lblMaChiDinh.AutoSize = true;
            this.lblMaChiDinh.Location = new System.Drawing.Point(30, 30);
            this.lblMaChiDinh.Name = "lblMaChiDinh";
            this.lblMaChiDinh.Size = new System.Drawing.Size(125, 16);
            this.lblMaChiDinh.Text = "Mã chỉ định xét nghiệm:";
            // 
            // txtMaChiDinh
            // 
            this.txtMaChiDinh.Location = new System.Drawing.Point(165, 27);
            this.txtMaChiDinh.Name = "txtMaChiDinh";
            this.txtMaChiDinh.Size = new System.Drawing.Size(180, 22);
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(30, 75);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(120, 16);
            this.lblKetQua.Text = "Kết quả xét nghiệm:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(165, 72);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(380, 100);
            // 
            // btnCapNhatKetQua
            // 
            this.btnCapNhatKetQua.Location = new System.Drawing.Point(395, 190);
            this.btnCapNhatKetQua.Name = "btnCapNhatKetQua";
            this.btnCapNhatKetQua.Size = new System.Drawing.Size(150, 35);
            this.btnCapNhatKetQua.Text = "Lưu Kết Quả";
            this.btnCapNhatKetQua.UseVisualStyleBackColor = true;
            this.btnCapNhatKetQua.Click += new System.EventHandler(this.btnCapNhatKetQua_Click);
            // 
            // FrmXetNghiem
            // 
            this.ClientSize = new System.Drawing.Size(580, 245);
            this.Controls.Add(this.btnCapNhatKetQua);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtMaChiDinh);
            this.Controls.Add(this.lblMaChiDinh);
            this.Name = "FrmXetNghiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẬP NHẬT KẾT QUẢ XÉT NGHIỆM";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaChiDinh;
        private System.Windows.Forms.TextBox txtMaChiDinh;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnCapNhatKetQua;
    }
}