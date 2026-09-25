namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
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
            this.lblDat = new System.Windows.Forms.Label();
            this.cboDat = new System.Windows.Forms.ComboBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.lblSoDB = new System.Windows.Forms.Label();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.lblDenBu = new System.Windows.Forms.Label();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.btnLapDB = new System.Windows.Forms.Button();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.lblHT = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.lblTienTT = new System.Windows.Forms.Label();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThemDB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDat.Location = new System.Drawing.Point(20, 20);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(95, 17);
            this.lblDat.TabIndex = 0;
            this.lblDat.Text = "Phiếu đang ở:";
            // 
            // cboDat
            // 
            this.cboDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDat.FormattingEnabled = true;
            this.cboDat.Location = new System.Drawing.Point(120, 17);
            this.cboDat.Name = "cboDat";
            this.cboDat.Size = new System.Drawing.Size(130, 25);
            this.cboDat.TabIndex = 1;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPhong.Location = new System.Drawing.Point(20, 52);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(230, 150);
            this.dgvPhong.TabIndex = 2;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            // 
            // dgvTN
            // 
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTN.Location = new System.Drawing.Point(260, 52);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.Size = new System.Drawing.Size(260, 150);
            this.dgvTN.TabIndex = 3;
            // 
            // dgvDBChon
            // 
            this.dgvDBChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBChon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDBChon.Location = new System.Drawing.Point(530, 52);
            this.dgvDBChon.Name = "dgvDBChon";
            this.dgvDBChon.Size = new System.Drawing.Size(270, 150);
            this.dgvDBChon.TabIndex = 4;
            // 
            // lblSoDB
            // 
            this.lblSoDB.AutoSize = true;
            this.lblSoDB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDB.Location = new System.Drawing.Point(20, 218);
            this.lblSoDB.Name = "lblSoDB";
            this.lblSoDB.Size = new System.Drawing.Size(109, 17);
            this.lblSoDB.TabIndex = 5;
            this.lblSoDB.Text = "Số phiếu đền bù:";
            // 
            // txtSoDB
            // 
            this.txtSoDB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDB.Location = new System.Drawing.Point(135, 215);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.Size = new System.Drawing.Size(100, 25);
            this.txtSoDB.TabIndex = 6;
            this.txtSoDB.Text = "DB001";
            // 
            // lblMucDo
            // 
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMucDo.Location = new System.Drawing.Point(255, 218);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(56, 17);
            this.lblMucDo.TabIndex = 7;
            this.lblMucDo.Text = "Mức độ:";
            // 
            // txtMucDo
            // 
            this.txtMucDo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucDo.Location = new System.Drawing.Point(315, 215);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.Size = new System.Drawing.Size(115, 25);
            this.txtMucDo.TabIndex = 8;
            this.txtMucDo.Text = "Hư hỏng nhẹ";
            // 
            // lblDenBu
            // 
            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDenBu.Location = new System.Drawing.Point(445, 218);
            this.lblDenBu.Name = "lblDenBu";
            this.lblDenBu.Size = new System.Drawing.Size(51, 17);
            this.lblDenBu.TabIndex = 9;
            this.lblDenBu.Text = "Số tiền:";
            // 
            // numDenBu
            // 
            this.numDenBu.DecimalPlaces = 2;
            this.numDenBu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDenBu.Location = new System.Drawing.Point(500, 215);
            this.numDenBu.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDenBu.Name = "numDenBu";
            this.numDenBu.Size = new System.Drawing.Size(110, 25);
            this.numDenBu.TabIndex = 10;
            this.numDenBu.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // btnLapDB
            // 
            this.btnLapDB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapDB.Location = new System.Drawing.Point(650, 212);
            this.btnLapDB.Name = "btnLapDB";
            this.btnLapDB.Size = new System.Drawing.Size(150, 30);
            this.btnLapDB.TabIndex = 11;
            this.btnLapDB.Text = "Lập phiếu đền bù";
            this.btnLapDB.UseVisualStyleBackColor = true;
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoHD.Location = new System.Drawing.Point(20, 258);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(80, 17);
            this.lblSoHD.TabIndex = 12;
            this.lblSoHD.Text = "Số hóa đơn:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoHD.Location = new System.Drawing.Point(105, 255);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(100, 25);
            this.txtSoHD.TabIndex = 13;
            this.txtSoHD.Text = "HD001";
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoNgay.Location = new System.Drawing.Point(220, 258);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(107, 17);
            this.lblSoNgay.TabIndex = 14;
            this.lblSoNgay.Text = "Số ngày tính tiền:";
            // 
            // numSoNgay
            // 
            this.numSoNgay.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoNgay.Location = new System.Drawing.Point(330, 255);
            this.numSoNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(60, 25);
            this.numSoNgay.TabIndex = 15;
            this.numSoNgay.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnLapHD
            // 
            this.btnLapHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHD.Location = new System.Drawing.Point(410, 252);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(110, 30);
            this.btnLapHD.TabIndex = 16;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHD.Location = new System.Drawing.Point(20, 290);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(780, 130);
            this.dgvHD.TabIndex = 17;
            this.dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHT.Location = new System.Drawing.Point(20, 435);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(65, 17);
            this.lblHT.TabIndex = 18;
            this.lblHT.Text = "Hình thức:";
            // 
            // cboHT
            // 
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHT.FormattingEnabled = true;
            this.cboHT.Location = new System.Drawing.Point(90, 432);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(120, 25);
            this.cboHT.TabIndex = 19;
            // 
            // lblTienTT
            // 
            this.lblTienTT.AutoSize = true;
            this.lblTienTT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienTT.Location = new System.Drawing.Point(225, 435);
            this.lblTienTT.Name = "lblTienTT";
            this.lblTienTT.Size = new System.Drawing.Size(51, 17);
            this.lblTienTT.TabIndex = 20;
            this.lblTienTT.Text = "Số tiền:";
            // 
            // numTienTT
            // 
            this.numTienTT.DecimalPlaces = 2;
            this.numTienTT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTienTT.Location = new System.Drawing.Point(280, 432);
            this.numTienTT.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTienTT.Name = "numTienTT";
            this.numTienTT.Size = new System.Drawing.Size(100, 25);
            this.numTienTT.TabIndex = 21;
            this.numTienTT.Value = new decimal(new int[] {
            1200000,
            0,
            0,
            0});
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(400, 428);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(110, 32);
            this.btnThanhToan.TabIndex = 22;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.Location = new System.Drawing.Point(530, 428);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(140, 32);
            this.btnTraPhong.TabIndex = 23;
            this.btnTraPhong.Text = "Hoàn tất trả phòng";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(0, 0);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(0, 20);
            this.txtPhong.TabIndex = 24;
            this.txtPhong.Visible = false;
            // 
            // cboNV
            // 
            this.cboNV.Location = new System.Drawing.Point(0, 0);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(0, 21);
            this.cboNV.TabIndex = 25;
            this.cboNV.Visible = false;
            // 
            // cboNV2
            // 
            this.cboNV2.Location = new System.Drawing.Point(0, 0);
            this.cboNV2.Name = "cboNV2";
            this.cboNV2.Size = new System.Drawing.Size(0, 21);
            this.cboNV2.TabIndex = 26;
            this.cboNV2.Visible = false;
            // 
            // txtHDChon
            // 
            this.txtHDChon.Location = new System.Drawing.Point(0, 0);
            this.txtHDChon.Name = "txtHDChon";
            this.txtHDChon.Size = new System.Drawing.Size(0, 20);
            this.txtHDChon.TabIndex = 27;
            this.txtHDChon.Visible = false;
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(0, 0);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(0, 20);
            this.txtMaTT.TabIndex = 28;
            this.txtMaTT.Text = "TT001";
            this.txtMaTT.Visible = false;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(0, 0);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(0, 0);
            this.btnDong.TabIndex = 29;
            this.btnDong.Visible = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThemDB
            // 
            this.btnThemDB.Location = new System.Drawing.Point(0, 0);
            this.btnThemDB.Name = "btnThemDB";
            this.btnThemDB.Size = new System.Drawing.Size(0, 0);
            this.btnThemDB.TabIndex = 30;
            this.btnThemDB.Visible = false;
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 475);
            this.Controls.Add(this.btnThemDB);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtMaTT);
            this.Controls.Add(this.txtHDChon);
            this.Controls.Add(this.cboNV2);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.numTienTT);
            this.Controls.Add(this.lblTienTT);
            this.Controls.Add(this.cboHT);
            this.Controls.Add(this.lblHT);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.btnLapHD);
            this.Controls.Add(this.numSoNgay);
            this.Controls.Add(this.lblSoNgay);
            this.Controls.Add(this.txtSoHD);
            this.Controls.Add(this.lblSoHD);
            this.Controls.Add(this.btnLapDB);
            this.Controls.Add(this.numDenBu);
            this.Controls.Add(this.lblDenBu);
            this.Controls.Add(this.txtMucDo);
            this.Controls.Add(this.lblMucDo);
            this.Controls.Add(this.txtSoDB);
            this.Controls.Add(this.lblSoDB);
            this.Controls.Add(this.dgvDBChon);
            this.Controls.Add(this.dgvTN);
            this.Controls.Add(this.dgvPhong);
            this.Controls.Add(this.cboDat);
            this.Controls.Add(this.lblDat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả phòng - Đền bù - Hóa đơn - Thanh toán";
            this.Load += new System.EventHandler(this.FrmTraPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.ComboBox cboDat;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.DataGridView dgvDBChon;
        private System.Windows.Forms.Label lblSoDB;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.Label lblDenBu;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.Button btnLapDB;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.Label lblTienTT;
        private System.Windows.Forms.NumericUpDown numTienTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.ComboBox cboNV2;
        private System.Windows.Forms.TextBox txtHDChon;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThemDB;
    }
}