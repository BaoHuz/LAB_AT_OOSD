namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
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
            this.lblLuot = new System.Windows.Forms.Label();
            this.cboLuot = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.cboDV = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblSL = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnGhi = new System.Windows.Forms.Button();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLuot
            // 
            this.lblLuot.AutoSize = true;
            this.lblLuot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuot.Location = new System.Drawing.Point(20, 25);
            this.lblLuot.Name = "lblLuot";
            this.lblLuot.Size = new System.Drawing.Size(89, 17);
            this.lblLuot.TabIndex = 0;
            this.lblLuot.Text = "Phiếu lưu trú:";
            // 
            // cboLuot
            // 
            this.cboLuot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLuot.FormattingEnabled = true;
            this.cboLuot.Location = new System.Drawing.Point(115, 22);
            this.cboLuot.Name = "cboLuot";
            this.cboLuot.Size = new System.Drawing.Size(130, 25);
            this.cboLuot.TabIndex = 1;
            this.cboLuot.SelectedIndexChanged += new System.EventHandler(this.cboLuot_SelectedIndexChanged);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhong.Location = new System.Drawing.Point(265, 25);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(48, 17);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng:";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhong.Location = new System.Drawing.Point(319, 22);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(100, 25);
            this.txtPhong.TabIndex = 3;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDV.Location = new System.Drawing.Point(440, 25);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(54, 17);
            this.lblDV.TabIndex = 4;
            this.lblDV.Text = "Dịch vụ:";
            // 
            // cboDV
            // 
            this.cboDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDV.FormattingEnabled = true;
            this.cboDV.Location = new System.Drawing.Point(500, 22);
            this.cboDV.Name = "cboDV";
            this.cboDV.Size = new System.Drawing.Size(160, 25);
            this.cboDV.TabIndex = 5;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(20, 65);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(92, 17);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày sử dụng:";
            // 
            // dtNgay
            // 
            this.dtNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(115, 62);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(130, 25);
            this.dtNgay.TabIndex = 7;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSL.Location = new System.Drawing.Point(265, 65);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(64, 17);
            this.lblSL.TabIndex = 8;
            this.lblSL.Text = "Số lượng:";
            // 
            // numSL
            // 
            this.numSL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSL.Location = new System.Drawing.Point(335, 62);
            this.numSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(84, 25);
            this.numSL.TabIndex = 9;
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhi.Location = new System.Drawing.Point(500, 58);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(130, 32);
            this.btnGhi.TabIndex = 10;
            this.btnGhi.Text = "Ghi nhận";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLichSu.Location = new System.Drawing.Point(20, 105);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.Size = new System.Drawing.Size(640, 245);
            this.dgvLichSu.TabIndex = 11;
            // 
            // cboNV
            // 
            this.cboNV.Location = new System.Drawing.Point(0, 0);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(0, 21);
            this.cboNV.TabIndex = 12;
            this.cboNV.Visible = false;
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
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 370);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.cboDV);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.cboLuot);
            this.Controls.Add(this.lblLuot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLuot;
        private System.Windows.Forms.ComboBox cboLuot;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.ComboBox cboDV;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Button btnDong;
    }
}