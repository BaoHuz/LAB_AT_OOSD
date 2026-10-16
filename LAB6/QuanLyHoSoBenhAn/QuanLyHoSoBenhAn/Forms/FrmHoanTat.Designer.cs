namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmHoanTat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblMaPK = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.lblNguoiXN = new System.Windows.Forms.Label();
            this.txtNguoiXacNhan = new System.Windows.Forms.TextBox();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.lblMaPK.Text = "Mã Phiếu Khám:"; this.lblMaPK.Location = new System.Drawing.Point(30, 30);
            this.txtMaPhieuKham.Location = new System.Drawing.Point(140, 27); this.txtMaPhieuKham.Size = new System.Drawing.Size(200, 23);

            this.lblNguoiXN.Text = "Người Chốt HS:"; this.lblNguoiXN.Location = new System.Drawing.Point(30, 70);
            this.txtNguoiXacNhan.Location = new System.Drawing.Point(140, 67); this.txtNguoiXacNhan.Size = new System.Drawing.Size(200, 23);
            this.txtNguoiXacNhan.Text = "NV_NguyenThiHoa";

            this.btnHoanTat.Text = "🔒 Hoàn Tất Đợt Khám"; this.btnHoanTat.Location = new System.Drawing.Point(140, 110);
            this.btnHoanTat.Size = new System.Drawing.Size(120, 32);
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);

            this.btnThoat.Text = "Thoát"; this.btnThoat.Location = new System.Drawing.Point(270, 110);
            this.btnThoat.Size = new System.Drawing.Size(70, 32);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.ClientSize = new System.Drawing.Size(380, 165);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblMaPK, this.txtMaPhieuKham, this.lblNguoiXN, this.txtNguoiXacNhan, this.btnHoanTat, this.btnThoat
            });
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOÀN TẤT VÀ CHỐT HỒ SƠ ĐỢT KHÁM";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblMaPK; private System.Windows.Forms.TextBox txtMaPhieuKham;
        private System.Windows.Forms.Label lblNguoiXN; private System.Windows.Forms.TextBox txtNguoiXacNhan;
        private System.Windows.Forms.Button btnHoanTat; private System.Windows.Forms.Button btnThoat;
    }
}