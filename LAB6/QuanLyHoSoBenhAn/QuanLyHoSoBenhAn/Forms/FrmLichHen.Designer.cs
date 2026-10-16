namespace QuanLyHoSoBenhAn.Forms
{
    partial class FrmLichHen
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
            this.lblMaLichHen = new System.Windows.Forms.Label();
            this.txtMaLichHen = new System.Windows.Forms.TextBox();
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.lblNgayHen = new System.Windows.Forms.Label();
            this.dtpNgayHen = new System.Windows.Forms.DateTimePicker();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblMaLichHen & txtMaLichHen
            this.lblMaLichHen.Location = new System.Drawing.Point(30, 25);
            this.lblMaLichHen.Size = new System.Drawing.Size(90, 20);
            this.lblMaLichHen.Text = "Mã lịch hẹn:";
            this.txtMaLichHen.Location = new System.Drawing.Point(130, 22);
            this.txtMaLichHen.Size = new System.Drawing.Size(220, 23);

            // lblMaHoSo & txtMaHoSo
            this.lblMaHoSo.Location = new System.Drawing.Point(30, 65);
            this.lblMaHoSo.Size = new System.Drawing.Size(90, 20);
            this.lblMaHoSo.Text = "Mã hồ sơ (HS):";
            this.txtMaHoSo.Location = new System.Drawing.Point(130, 62);
            this.txtMaHoSo.Size = new System.Drawing.Size(220, 23);

            // lblNgayHen & dtpNgayHen
            this.lblNgayHen.Location = new System.Drawing.Point(30, 105);
            this.lblNgayHen.Size = new System.Drawing.Size(90, 20);
            this.lblNgayHen.Text = "Ngày giờ hẹn:";
            this.dtpNgayHen.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayHen.Location = new System.Drawing.Point(130, 102);
            this.dtpNgayHen.Size = new System.Drawing.Size(220, 23);

            // btnDatLich & btnThoat
            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDatLich.Location = new System.Drawing.Point(130, 145);
            this.btnDatLich.Size = new System.Drawing.Size(120, 32);
            this.btnDatLich.Text = "📅 Đặt Lịch Hẹn";
            this.btnDatLich.UseVisualStyleBackColor = true;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);

            this.btnThoat.Location = new System.Drawing.Point(260, 145);
            this.btnThoat.Size = new System.Drawing.Size(90, 32);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Form setup
            this.ClientSize = new System.Drawing.Size(384, 201);
            this.Controls.Add(this.lblMaLichHen);
            this.Controls.Add(this.txtMaLichHen);
            this.Controls.Add(this.lblMaHoSo);
            this.Controls.Add(this.txtMaHoSo);
            this.Controls.Add(this.lblNgayHen);
            this.Controls.Add(this.dtpNgayHen);
            this.Controls.Add(this.btnDatLich);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLichHen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐẶT LỊCH KHÁM ĐỊNH KỲ THEO QUÝ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblMaLichHen;
        private System.Windows.Forms.TextBox txtMaLichHen;
        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Label lblNgayHen;
        private System.Windows.Forms.DateTimePicker dtpNgayHen;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Button btnThoat;
    }
}