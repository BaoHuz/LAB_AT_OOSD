namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmPhatThuoc
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
            this.lblMaToaThuoc = new System.Windows.Forms.Label();
            this.txtMaToaThuoc = new System.Windows.Forms.TextBox();
            this.btnPhatThuoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMaToaThuoc
            // 
            this.lblMaToaThuoc.AutoSize = true;
            this.lblMaToaThuoc.Location = new System.Drawing.Point(30, 35);
            this.lblMaToaThuoc.Name = "lblMaToaThuoc";
            this.lblMaToaThuoc.Size = new System.Drawing.Size(89, 16);
            this.lblMaToaThuoc.Text = "Mã toa thuốc:";
            // 
            // txtMaToaThuoc
            // 
            this.txtMaToaThuoc.Location = new System.Drawing.Point(135, 32);
            this.txtMaToaThuoc.Name = "txtMaToaThuoc";
            this.txtMaToaThuoc.Size = new System.Drawing.Size(200, 22);
            // 
            // btnPhatThuoc
            // 
            this.btnPhatThuoc.Location = new System.Drawing.Point(185, 80);
            this.btnPhatThuoc.Name = "btnPhatThuoc";
            this.btnPhatThuoc.Size = new System.Drawing.Size(150, 35);
            this.btnPhatThuoc.Text = "Xác Nhận Phát";
            this.btnPhatThuoc.UseVisualStyleBackColor = true;
            this.btnPhatThuoc.Click += new System.EventHandler(this.btnPhatThuoc_Click);
            // 
            // FrmPhatThuoc
            // 
            this.ClientSize = new System.Drawing.Size(370, 140);
            this.Controls.Add(this.btnPhatThuoc);
            this.Controls.Add(this.txtMaToaThuoc);
            this.Controls.Add(this.lblMaToaThuoc);
            this.Name = "FrmPhatThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XÁC NHẬN PHÁT THUỐC";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaToaThuoc;
        private System.Windows.Forms.TextBox txtMaToaThuoc;
        private System.Windows.Forms.Button btnPhatThuoc;
    }
}