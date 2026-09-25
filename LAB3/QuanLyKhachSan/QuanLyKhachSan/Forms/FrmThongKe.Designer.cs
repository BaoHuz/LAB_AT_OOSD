namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
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
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.lblPhieuDat = new System.Windows.Forms.Label();
            this.lblDangO = new System.Windows.Forms.Label();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblDenBu = new System.Windows.Forms.Label();
            this.lblDVSudung = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTu.Location = new System.Drawing.Point(30, 25);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(58, 17);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(95, 22);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(120, 25);
            this.dtTu.TabIndex = 1;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDen.Location = new System.Drawing.Point(240, 25);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(66, 17);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(312, 22);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(120, 25);
            this.dtDen.TabIndex = 3;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(455, 20);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(110, 30);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lblPhieuDat
            // 
            this.lblPhieuDat.AutoSize = true;
            this.lblPhieuDat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuDat.ForeColor = System.Drawing.Color.FromArgb(20, 40, 110);
            this.lblPhieuDat.Location = new System.Drawing.Point(30, 75);
            this.lblPhieuDat.Name = "lblPhieuDat";
            this.lblPhieuDat.Size = new System.Drawing.Size(102, 20);
            this.lblPhieuDat.TabIndex = 5;
            this.lblPhieuDat.Text = "Phiếu đặt: 28";
            // 
            // lblDangO
            // 
            this.lblDangO.AutoSize = true;
            this.lblDangO.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangO.ForeColor = System.Drawing.Color.FromArgb(20, 40, 110);
            this.lblDangO.Location = new System.Drawing.Point(410, 75);
            this.lblDangO.Name = "lblDangO";
            this.lblDangO.Size = new System.Drawing.Size(76, 20);
            this.lblDangO.TabIndex = 6;
            this.lblDangO.Text = "Đang ở: 7";
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoaDon.ForeColor = System.Drawing.Color.FromArgb(20, 40, 110);
            this.lblHoaDon.Location = new System.Drawing.Point(30, 115);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(95, 20);
            this.lblHoaDon.TabIndex = 7;
            this.lblHoaDon.Text = "Hóa đơn: 21";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(20, 40, 110);
            this.lblDoanhThu.Location = new System.Drawing.Point(410, 115);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(209, 20);
            this.lblDoanhThu.TabIndex = 8;
            this.lblDoanhThu.Text = "Doanh thu HĐ: 52.600.000 đ";
            // 
            // lblDenBu
            // 
            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenBu.ForeColor = System.Drawing.Color.FromArgb(20, 40, 110);
            this.lblDenBu.Location = new System.Drawing.Point(30, 155);
            this.lblDenBu.Name = "lblDenBu";
            this.lblDenBu.Size = new System.Drawing.Size(189, 20);
            this.lblDenBu.TabIndex = 9;
            this.lblDenBu.Text = "Tổng đền bù: 2.100.000 đ";
            // 
            // lblDVSudung
            // 
            this.lblDVSudung.AutoSize = true;
            this.lblDVSudung.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVSudung.Location = new System.Drawing.Point(30, 205);
            this.lblDVSudung.Name = "lblDVSudung";
            this.lblDVSudung.Size = new System.Drawing.Size(107, 17);
            this.lblDVSudung.TabIndex = 10;
            this.lblDVSudung.Text = "Dịch vụ sử dụng:";
            // 
            // dgvDV
            // 
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDV.Location = new System.Drawing.Point(30, 230);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.Size = new System.Drawing.Size(730, 200);
            this.dgvDV.TabIndex = 11;
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.Location = new System.Drawing.Point(0, 0);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.Size = new System.Drawing.Size(0, 0);
            this.dgvTongHop.TabIndex = 12;
            this.dgvTongHop.Visible = false;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(0, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(0, 0);
            this.btnDong.TabIndex = 13;
            this.btnDong.Visible = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 455);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.lblDVSudung);
            this.Controls.Add(this.lblDenBu);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.lblHoaDon);
            this.Controls.Add(this.lblDangO);
            this.Controls.Add(this.lblPhieuDat);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblTu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê khách sạn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label lblPhieuDat;
        private System.Windows.Forms.Label lblDangO;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Label lblDenBu;
        private System.Windows.Forms.Label lblDVSudung;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.Button btnDong;
    }
}