namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmKhamBenh
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
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblTrieuChung = new System.Windows.Forms.Label();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.lblChanDoan = new System.Windows.Forms.Label();
            this.txtChanDoan = new System.Windows.Forms.TextBox();
            this.btnLuuPhieuKham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaHoSo
            // 
            this.lblMaHoSo.AutoSize = true;
            this.lblMaHoSo.Location = new System.Drawing.Point(30, 30);
            this.lblMaHoSo.Name = "lblMaHoSo";
            this.lblMaHoSo.Size = new System.Drawing.Size(98, 16);
            this.lblMaHoSo.Text = "Mã hồ sơ bệnh án:";
            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Location = new System.Drawing.Point(145, 27);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Size = new System.Drawing.Size(180, 22);
            // 
            // lblMaPhieuKham
            // 
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Location = new System.Drawing.Point(350, 30);
            this.lblMaPhieuKham.Name = "lblMaPhieuKham";
            this.lblMaPhieuKham.Size = new System.Drawing.Size(101, 16);
            this.lblMaPhieuKham.Text = "Mã phiếu khám:";
            // 
            // txtMaPhieuKham
            // 
            this.txtMaPhieuKham.Location = new System.Drawing.Point(460, 27);
            this.txtMaPhieuKham.Name = "txtMaPhieuKham";
            this.txtMaPhieuKham.ReadOnly = true;
            this.txtMaPhieuKham.Size = new System.Drawing.Size(150, 22);
            // 
            // lblTrieuChung
            // 
            this.lblTrieuChung.AutoSize = true;
            this.lblTrieuChung.Location = new System.Drawing.Point(30, 80);
            this.lblTrieuChung.Name = "lblTrieuChung";
            this.lblTrieuChung.Size = new System.Drawing.Size(81, 16);
            this.lblTrieuChung.Text = "Triệu chứng:";
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Location = new System.Drawing.Point(145, 77);
            this.txtTrieuChung.Multiline = true;
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(465, 60);
            // 
            // lblChanDoan
            // 
            this.lblChanDoan.AutoSize = true;
            this.lblChanDoan.Location = new System.Drawing.Point(30, 160);
            this.lblChanDoan.Name = "lblChanDoan";
            this.lblChanDoan.Size = new System.Drawing.Size(75, 16);
            this.lblChanDoan.Text = "Chẩn đoán:";
            // 
            // txtChanDoan
            // 
            this.txtChanDoan.Location = new System.Drawing.Point(145, 157);
            this.txtChanDoan.Multiline = true;
            this.txtChanDoan.Name = "txtChanDoan";
            this.txtChanDoan.Size = new System.Drawing.Size(465, 60);
            // 
            // btnLuuPhieuKham
            // 
            this.btnLuuPhieuKham.Location = new System.Drawing.Point(460, 235);
            this.btnLuuPhieuKham.Name = "btnLuuPhieuKham";
            this.btnLuuPhieuKham.Size = new System.Drawing.Size(150, 35);
            this.btnLuuPhieuKham.Text = "Tạo Phiếu Khám";
            this.btnLuuPhieuKham.UseVisualStyleBackColor = true;
            this.btnLuuPhieuKham.Click += new System.EventHandler(this.btnLuuPhieuKham_Click);
            // 
            // FrmKhamBenh
            // 
            this.ClientSize = new System.Drawing.Size(645, 295);
            this.Controls.Add(this.btnLuuPhieuKham);
            this.Controls.Add(this.txtChanDoan);
            this.Controls.Add(this.lblChanDoan);
            this.Controls.Add(this.txtTrieuChung);
            this.Controls.Add(this.lblTrieuChung);
            this.Controls.Add(this.txtMaPhieuKham);
            this.Controls.Add(this.lblMaPhieuKham);
            this.Controls.Add(this.txtMaHoSo);
            this.Controls.Add(this.lblMaHoSo);
            this.Name = "FrmKhamBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁM BỆNH & CHẨN ĐOÁN LÂM SÀNG";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Label lblMaPhieuKham;
        private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label lblTrieuChung;
        private System.Windows.Forms.TextBox txtTrieuChung;
        private System.Windows.Forms.Label lblChanDoan;
        private System.Windows.Forms.TextBox txtChanDoan;
        private System.Windows.Forms.Button btnLuuPhieuKham;
    }
}