namespace QuanLyKhachSan.Forms
{
    partial class FrmDanhMuc
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
            this.tabDanhMuc = new System.Windows.Forms.TabControl();
            this.tabKhuVuc = new System.Windows.Forms.TabPage();
            this.lblKhuMa = new System.Windows.Forms.Label();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.lblKhuTen = new System.Windows.Forms.Label();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.btnThemKhu = new System.Windows.Forms.Button();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVVaiTro = new System.Windows.Forms.Label();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.tabLoaiTienNghi = new System.Windows.Forms.TabPage();
            this.lblLoaiMa = new System.Windows.Forms.Label();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.lblLoaiTen = new System.Windows.Forms.Label();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.tabDichVu = new System.Windows.Forms.TabPage();
            this.lblDVMa = new System.Windows.Forms.Label();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.lblDVTen = new System.Windows.Forms.Label();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.lblDVDVT = new System.Windows.Forms.Label();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.lblDVGia = new System.Windows.Forms.Label();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemDV = new System.Windows.Forms.Button();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.tabQuyDinhDenBu = new System.Windows.Forms.TabPage();
            this.lblQDMa = new System.Windows.Forms.Label();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.lblQDLoai = new System.Windows.Forms.Label();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.lblQDMucDo = new System.Windows.Forms.Label();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.lblQDTien = new System.Windows.Forms.Label();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.btnThemQD = new System.Windows.Forms.Button();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabDanhMuc.SuspendLayout();
            this.tabKhuVuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabLoaiTienNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            this.tabDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.tabQuyDinhDenBu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDanhMuc
            // 
            this.tabDanhMuc.Controls.Add(this.tabKhuVuc);
            this.tabDanhMuc.Controls.Add(this.tabNhanVien);
            this.tabDanhMuc.Controls.Add(this.tabLoaiTienNghi);
            this.tabDanhMuc.Controls.Add(this.tabDichVu);
            this.tabDanhMuc.Controls.Add(this.tabQuyDinhDenBu);
            this.tabDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDanhMuc.Location = new System.Drawing.Point(10, 10);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.SelectedIndex = 3;
            this.tabDanhMuc.Size = new System.Drawing.Size(764, 410);
            this.tabDanhMuc.TabIndex = 0;
            // 
            // tabKhuVuc
            // 
            this.tabKhuVuc.Controls.Add(this.lblKhuMa);
            this.tabKhuVuc.Controls.Add(this.txtKhuMa);
            this.tabKhuVuc.Controls.Add(this.lblKhuTen);
            this.tabKhuVuc.Controls.Add(this.txtKhuTen);
            this.tabKhuVuc.Controls.Add(this.btnThemKhu);
            this.tabKhuVuc.Controls.Add(this.dgvKhu);
            this.tabKhuVuc.Location = new System.Drawing.Point(4, 26);
            this.tabKhuVuc.Name = "tabKhuVuc";
            this.tabKhuVuc.Padding = new System.Windows.Forms.Padding(10);
            this.tabKhuVuc.Size = new System.Drawing.Size(756, 380);
            this.tabKhuVuc.TabIndex = 0;
            this.tabKhuVuc.Text = "Khu vực";
            this.tabKhuVuc.UseVisualStyleBackColor = true;
            // 
            // lblKhuMa
            // 
            this.lblKhuMa.AutoSize = true;
            this.lblKhuMa.Location = new System.Drawing.Point(15, 18);
            this.lblKhuMa.Name = "lblKhuMa";
            this.lblKhuMa.Size = new System.Drawing.Size(30, 17);
            this.lblKhuMa.TabIndex = 0;
            this.lblKhuMa.Text = "Mã:";
            // 
            // txtKhuMa
            // 
            this.txtKhuMa.Location = new System.Drawing.Point(55, 15);
            this.txtKhuMa.Name = "txtKhuMa";
            this.txtKhuMa.Size = new System.Drawing.Size(150, 25);
            this.txtKhuMa.TabIndex = 1;
            // 
            // lblKhuTen
            // 
            this.lblKhuTen.AutoSize = true;
            this.lblKhuTen.Location = new System.Drawing.Point(230, 18);
            this.lblKhuTen.Name = "lblKhuTen";
            this.lblKhuTen.Size = new System.Drawing.Size(31, 17);
            this.lblKhuTen.TabIndex = 2;
            this.lblKhuTen.Text = "Tên:";
            // 
            // txtKhuTen
            // 
            this.txtKhuTen.Location = new System.Drawing.Point(270, 15);
            this.txtKhuTen.Name = "txtKhuTen";
            this.txtKhuTen.Size = new System.Drawing.Size(200, 25);
            this.txtKhuTen.TabIndex = 3;
            // 
            // btnThemKhu
            // 
            this.btnThemKhu.Location = new System.Drawing.Point(645, 12);
            this.btnThemKhu.Name = "btnThemKhu";
            this.btnThemKhu.Size = new System.Drawing.Size(95, 30);
            this.btnThemKhu.TabIndex = 4;
            this.btnThemKhu.Text = "Thêm";
            this.btnThemKhu.UseVisualStyleBackColor = true;
            this.btnThemKhu.Click += new System.EventHandler(this.btnThemKhu_Click);
            // 
            // dgvKhu
            // 
            this.dgvKhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Location = new System.Drawing.Point(10, 55);
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.Size = new System.Drawing.Size(733, 312);
            this.dgvKhu.TabIndex = 5;
            // 
            // tabNhanVien
            // 
            this.tabNhanVien.Controls.Add(this.lblNVMa);
            this.tabNhanVien.Controls.Add(this.txtNVMa);
            this.tabNhanVien.Controls.Add(this.lblNVTen);
            this.tabNhanVien.Controls.Add(this.txtNVTen);
            this.tabNhanVien.Controls.Add(this.lblNVVaiTro);
            this.tabNhanVien.Controls.Add(this.txtNVVaiTro);
            this.tabNhanVien.Controls.Add(this.lblNVSDT);
            this.tabNhanVien.Controls.Add(this.txtNVSDT);
            this.tabNhanVien.Controls.Add(this.btnThemNV);
            this.tabNhanVien.Controls.Add(this.dgvNV);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 26);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(10);
            this.tabNhanVien.Size = new System.Drawing.Size(756, 380);
            this.tabNhanVien.TabIndex = 1;
            this.tabNhanVien.Text = "Nhân viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;
            // 
            // lblNVMa
            // 
            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(10, 18);
            this.lblNVMa.Name = "lblNVMa";
            this.lblNVMa.Size = new System.Drawing.Size(30, 17);
            this.lblNVMa.TabIndex = 0;
            this.lblNVMa.Text = "Mã:";
            // 
            // txtNVMa
            // 
            this.txtNVMa.Location = new System.Drawing.Point(42, 15);
            this.txtNVMa.Name = "txtNVMa";
            this.txtNVMa.Size = new System.Drawing.Size(90, 25);
            this.txtNVMa.TabIndex = 1;
            // 
            // lblNVTen
            // 
            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location = new System.Drawing.Point(140, 18);
            this.lblNVTen.Name = "lblNVTen";
            this.lblNVTen.Size = new System.Drawing.Size(31, 17);
            this.lblNVTen.TabIndex = 2;
            this.lblNVTen.Text = "Tên:";
            // 
            // txtNVTen
            // 
            this.txtNVTen.Location = new System.Drawing.Point(173, 15);
            this.txtNVTen.Name = "txtNVTen";
            this.txtNVTen.Size = new System.Drawing.Size(140, 25);
            this.txtNVTen.TabIndex = 3;
            // 
            // lblNVVaiTro
            // 
            this.lblNVVaiTro.AutoSize = true;
            this.lblNVVaiTro.Location = new System.Drawing.Point(320, 18);
            this.lblNVVaiTro.Name = "lblNVVaiTro";
            this.lblNVVaiTro.Size = new System.Drawing.Size(49, 17);
            this.lblNVVaiTro.TabIndex = 4;
            this.lblNVVaiTro.Text = "Vai trò:";
            // 
            // txtNVVaiTro
            // 
            this.txtNVVaiTro.Location = new System.Drawing.Point(372, 15);
            this.txtNVVaiTro.Name = "txtNVVaiTro";
            this.txtNVVaiTro.Size = new System.Drawing.Size(110, 25);
            this.txtNVVaiTro.TabIndex = 5;
            // 
            // lblNVSDT
            // 
            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(490, 18);
            this.lblNVSDT.Name = "lblNVSDT";
            this.lblNVSDT.Size = new System.Drawing.Size(34, 17);
            this.lblNVSDT.TabIndex = 6;
            this.lblNVSDT.Text = "SĐT:";
            // 
            // txtNVSDT
            // 
            this.txtNVSDT.Location = new System.Drawing.Point(527, 15);
            this.txtNVSDT.Name = "txtNVSDT";
            this.txtNVSDT.Size = new System.Drawing.Size(110, 25);
            this.txtNVSDT.TabIndex = 7;
            // 
            // btnThemNV
            // 
            this.btnThemNV.Location = new System.Drawing.Point(648, 12);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(95, 30);
            this.btnThemNV.TabIndex = 8;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // dgvNV
            // 
            this.dgvNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(10, 55);
            this.dgvNV.Name = "dgvNV";
            this.dgvNV.Size = new System.Drawing.Size(733, 312);
            this.dgvNV.TabIndex = 9;
            // 
            // tabLoaiTienNghi
            // 
            this.tabLoaiTienNghi.Controls.Add(this.lblLoaiMa);
            this.tabLoaiTienNghi.Controls.Add(this.txtLoaiMa);
            this.tabLoaiTienNghi.Controls.Add(this.lblLoaiTen);
            this.tabLoaiTienNghi.Controls.Add(this.txtLoaiTen);
            this.tabLoaiTienNghi.Controls.Add(this.btnThemLoaiTN);
            this.tabLoaiTienNghi.Controls.Add(this.dgvLoaiTN);
            this.tabLoaiTienNghi.Location = new System.Drawing.Point(4, 26);
            this.tabLoaiTienNghi.Name = "tabLoaiTienNghi";
            this.tabLoaiTienNghi.Padding = new System.Windows.Forms.Padding(10);
            this.tabLoaiTienNghi.Size = new System.Drawing.Size(756, 380);
            this.tabLoaiTienNghi.TabIndex = 2;
            this.tabLoaiTienNghi.Text = "Loại tiện nghi";
            this.tabLoaiTienNghi.UseVisualStyleBackColor = true;
            // 
            // lblLoaiMa
            // 
            this.lblLoaiMa.AutoSize = true;
            this.lblLoaiMa.Location = new System.Drawing.Point(15, 18);
            this.lblLoaiMa.Name = "lblLoaiMa";
            this.lblLoaiMa.Size = new System.Drawing.Size(30, 17);
            this.lblLoaiMa.TabIndex = 0;
            this.lblLoaiMa.Text = "Mã:";
            // 
            // txtLoaiMa
            // 
            this.txtLoaiMa.Location = new System.Drawing.Point(55, 15);
            this.txtLoaiMa.Name = "txtLoaiMa";
            this.txtLoaiMa.Size = new System.Drawing.Size(150, 25);
            this.txtLoaiMa.TabIndex = 1;
            // 
            // lblLoaiTen
            // 
            this.lblLoaiTen.AutoSize = true;
            this.lblLoaiTen.Location = new System.Drawing.Point(230, 18);
            this.lblLoaiTen.Name = "lblLoaiTen";
            this.lblLoaiTen.Size = new System.Drawing.Size(31, 17);
            this.lblLoaiTen.TabIndex = 2;
            this.lblLoaiTen.Text = "Tên:";
            // 
            // txtLoaiTen
            // 
            this.txtLoaiTen.Location = new System.Drawing.Point(270, 15);
            this.txtLoaiTen.Name = "txtLoaiTen";
            this.txtLoaiTen.Size = new System.Drawing.Size(200, 25);
            this.txtLoaiTen.TabIndex = 3;
            // 
            // btnThemLoaiTN
            // 
            this.btnThemLoaiTN.Location = new System.Drawing.Point(645, 12);
            this.btnThemLoaiTN.Name = "btnThemLoaiTN";
            this.btnThemLoaiTN.Size = new System.Drawing.Size(95, 30);
            this.btnThemLoaiTN.TabIndex = 4;
            this.btnThemLoaiTN.Text = "Thêm";
            this.btnThemLoaiTN.UseVisualStyleBackColor = true;
            this.btnThemLoaiTN.Click += new System.EventHandler(this.btnThemLoaiTN_Click);
            // 
            // dgvLoaiTN
            // 
            this.dgvLoaiTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTN.Location = new System.Drawing.Point(10, 55);
            this.dgvLoaiTN.Name = "dgvLoaiTN";
            this.dgvLoaiTN.Size = new System.Drawing.Size(733, 312);
            this.dgvLoaiTN.TabIndex = 5;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.lblDVMa);
            this.tabDichVu.Controls.Add(this.txtDVMa);
            this.tabDichVu.Controls.Add(this.lblDVTen);
            this.tabDichVu.Controls.Add(this.txtDVTen);
            this.tabDichVu.Controls.Add(this.lblDVDVT);
            this.tabDichVu.Controls.Add(this.txtDVDVT);
            this.tabDichVu.Controls.Add(this.lblDVGia);
            this.tabDichVu.Controls.Add(this.numDVGia);
            this.tabDichVu.Controls.Add(this.btnThemDV);
            this.tabDichVu.Controls.Add(this.dgvDV);
            this.tabDichVu.Location = new System.Drawing.Point(4, 26);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.Padding = new System.Windows.Forms.Padding(10);
            this.tabDichVu.Size = new System.Drawing.Size(756, 380);
            this.tabDichVu.TabIndex = 3;
            this.tabDichVu.Text = "Dịch vụ";
            this.tabDichVu.UseVisualStyleBackColor = true;
            // 
            // lblDVMa
            // 
            this.lblDVMa.AutoSize = true;
            this.lblDVMa.Location = new System.Drawing.Point(10, 18);
            this.lblDVMa.Name = "lblDVMa";
            this.lblDVMa.Size = new System.Drawing.Size(30, 17);
            this.lblDVMa.TabIndex = 0;
            this.lblDVMa.Text = "Mã:";
            // 
            // txtDVMa
            // 
            this.txtDVMa.Location = new System.Drawing.Point(45, 15);
            this.txtDVMa.Name = "txtDVMa";
            this.txtDVMa.Size = new System.Drawing.Size(120, 25);
            this.txtDVMa.TabIndex = 1;
            this.txtDVMa.Text = "DV01";
            // 
            // lblDVTen
            // 
            this.lblDVTen.AutoSize = true;
            this.lblDVTen.Location = new System.Drawing.Point(180, 18);
            this.lblDVTen.Name = "lblDVTen";
            this.lblDVTen.Size = new System.Drawing.Size(31, 17);
            this.lblDVTen.TabIndex = 2;
            this.lblDVTen.Text = "Tên:";
            // 
            // txtDVTen
            // 
            this.txtDVTen.Location = new System.Drawing.Point(215, 15);
            this.txtDVTen.Name = "txtDVTen";
            this.txtDVTen.Size = new System.Drawing.Size(160, 25);
            this.txtDVTen.TabIndex = 3;
            this.txtDVTen.Text = "Ăn sáng";
            // 
            // lblDVDVT
            // 
            this.lblDVDVT.AutoSize = true;
            this.lblDVDVT.Location = new System.Drawing.Point(390, 18);
            this.lblDVDVT.Name = "lblDVDVT";
            this.lblDVDVT.Size = new System.Drawing.Size(102, 17);
            this.lblDVDVT.TabIndex = 4;
            this.lblDVDVT.Text = "Đơn vị / Vai trò:";
            // 
            // txtDVDVT
            // 
            this.txtDVDVT.Location = new System.Drawing.Point(495, 15);
            this.txtDVDVT.Name = "txtDVDVT";
            this.txtDVDVT.Size = new System.Drawing.Size(115, 25);
            this.txtDVDVT.TabIndex = 5;
            this.txtDVDVT.Text = "Suất";
            // 
            // lblDVGia
            // 
            this.lblDVGia.AutoSize = true;
            this.lblDVGia.Location = new System.Drawing.Point(615, 18);
            this.lblDVGia.Name = "lblDVGia";
            this.lblDVGia.Size = new System.Drawing.Size(30, 17);
            this.lblDVGia.TabIndex = 6;
            this.lblDVGia.Text = "Giá:";
            this.lblDVGia.Visible = false;
            // 
            // numDVGia
            // 
            this.numDVGia.DecimalPlaces = 2;
            this.numDVGia.Location = new System.Drawing.Point(618, 15);
            this.numDVGia.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDVGia.Name = "numDVGia";
            this.numDVGia.Size = new System.Drawing.Size(20, 25);
            this.numDVGia.TabIndex = 7;
            this.numDVGia.Visible = false;
            // 
            // btnThemDV
            // 
            this.btnThemDV.Location = new System.Drawing.Point(645, 12);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(98, 30);
            this.btnThemDV.TabIndex = 8;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.UseVisualStyleBackColor = true;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // dgvDV
            // 
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(10, 55);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.Size = new System.Drawing.Size(733, 312);
            this.dgvDV.TabIndex = 9;
            // 
            // tabQuyDinhDenBu
            // 
            this.tabQuyDinhDenBu.Controls.Add(this.lblQDMa);
            this.tabQuyDinhDenBu.Controls.Add(this.txtQDMa);
            this.tabQuyDinhDenBu.Controls.Add(this.lblQDLoai);
            this.tabQuyDinhDenBu.Controls.Add(this.cboQDLoai);
            this.tabQuyDinhDenBu.Controls.Add(this.lblQDMucDo);
            this.tabQuyDinhDenBu.Controls.Add(this.txtQDMucDo);
            this.tabQuyDinhDenBu.Controls.Add(this.lblQDTien);
            this.tabQuyDinhDenBu.Controls.Add(this.numQDTien);
            this.tabQuyDinhDenBu.Controls.Add(this.btnThemQD);
            this.tabQuyDinhDenBu.Controls.Add(this.dgvQD);
            this.tabQuyDinhDenBu.Location = new System.Drawing.Point(4, 26);
            this.tabQuyDinhDenBu.Name = "tabQuyDinhDenBu";
            this.tabQuyDinhDenBu.Padding = new System.Windows.Forms.Padding(10);
            this.tabQuyDinhDenBu.Size = new System.Drawing.Size(756, 380);
            this.tabQuyDinhDenBu.TabIndex = 4;
            this.tabQuyDinhDenBu.Text = "Quy định đền bù";
            this.tabQuyDinhDenBu.UseVisualStyleBackColor = true;
            // 
            // lblQDMa
            // 
            this.lblQDMa.AutoSize = true;
            this.lblQDMa.Location = new System.Drawing.Point(10, 18);
            this.lblQDMa.Name = "lblQDMa";
            this.lblQDMa.Size = new System.Drawing.Size(30, 17);
            this.lblQDMa.TabIndex = 0;
            this.lblQDMa.Text = "Mã:";
            // 
            // txtQDMa
            // 
            this.txtQDMa.Location = new System.Drawing.Point(42, 15);
            this.txtQDMa.Name = "txtQDMa";
            this.txtQDMa.Size = new System.Drawing.Size(80, 25);
            this.txtQDMa.TabIndex = 1;
            // 
            // lblQDLoai
            // 
            this.lblQDLoai.AutoSize = true;
            this.lblQDLoai.Location = new System.Drawing.Point(130, 18);
            this.lblQDLoai.Name = "lblQDLoai";
            this.lblQDLoai.Size = new System.Drawing.Size(35, 17);
            this.lblQDLoai.TabIndex = 2;
            this.lblQDLoai.Text = "Loại:";
            // 
            // cboQDLoai
            // 
            this.cboQDLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQDLoai.FormattingEnabled = true;
            this.cboQDLoai.Location = new System.Drawing.Point(168, 15);
            this.cboQDLoai.Name = "cboQDLoai";
            this.cboQDLoai.Size = new System.Drawing.Size(120, 25);
            this.cboQDLoai.TabIndex = 3;
            // 
            // lblQDMucDo
            // 
            this.lblQDMucDo.AutoSize = true;
            this.lblQDMucDo.Location = new System.Drawing.Point(295, 18);
            this.lblQDMucDo.Name = "lblQDMucDo";
            this.lblQDMucDo.Size = new System.Drawing.Size(55, 17);
            this.lblQDMucDo.TabIndex = 4;
            this.lblQDMucDo.Text = "Mức độ:";
            // 
            // txtQDMucDo
            // 
            this.txtQDMucDo.Location = new System.Drawing.Point(352, 15);
            this.txtQDMucDo.Name = "txtQDMucDo";
            this.txtQDMucDo.Size = new System.Drawing.Size(120, 25);
            this.txtQDMucDo.TabIndex = 5;
            // 
            // lblQDTien
            // 
            this.lblQDTien.AutoSize = true;
            this.lblQDTien.Location = new System.Drawing.Point(480, 18);
            this.lblQDTien.Name = "lblQDTien";
            this.lblQDTien.Size = new System.Drawing.Size(51, 17);
            this.lblQDTien.TabIndex = 6;
            this.lblQDTien.Text = "Số tiền:";
            // 
            // numQDTien
            // 
            this.numQDTien.DecimalPlaces = 2;
            this.numQDTien.Location = new System.Drawing.Point(533, 15);
            this.numQDTien.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numQDTien.Name = "numQDTien";
            this.numQDTien.Size = new System.Drawing.Size(105, 25);
            this.numQDTien.TabIndex = 7;
            // 
            // btnThemQD
            // 
            this.btnThemQD.Location = new System.Drawing.Point(648, 12);
            this.btnThemQD.Name = "btnThemQD";
            this.btnThemQD.Size = new System.Drawing.Size(95, 30);
            this.btnThemQD.TabIndex = 8;
            this.btnThemQD.Text = "Thêm";
            this.btnThemQD.UseVisualStyleBackColor = true;
            this.btnThemQD.Click += new System.EventHandler(this.btnThemQD_Click);
            // 
            // dgvQD
            // 
            this.dgvQD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQD.Location = new System.Drawing.Point(10, 55);
            this.dgvQD.Name = "dgvQD";
            this.dgvQD.Size = new System.Drawing.Size(733, 312);
            this.dgvQD.TabIndex = 9;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(675, 425);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 30);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabDanhMuc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDanhMuc";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục khách sạn";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabDanhMuc.ResumeLayout(false);
            this.tabKhuVuc.ResumeLayout(false);
            this.tabKhuVuc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.tabNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabLoaiTienNghi.ResumeLayout(false);
            this.tabLoaiTienNghi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            this.tabDichVu.ResumeLayout(false);
            this.tabDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.tabQuyDinhDenBu.ResumeLayout(false);
            this.tabQuyDinhDenBu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDanhMuc;
        private System.Windows.Forms.TabPage tabKhuVuc;
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.TabPage tabLoaiTienNghi;
        private System.Windows.Forms.TabPage tabDichVu;
        private System.Windows.Forms.TabPage tabQuyDinhDenBu;
        private System.Windows.Forms.Button btnDong;


        private System.Windows.Forms.Label lblKhuMa;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.Label lblKhuTen;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Button btnThemKhu;
        private System.Windows.Forms.DataGridView dgvKhu;


        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVVaiTro;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.DataGridView dgvNV;


        private System.Windows.Forms.Label lblLoaiMa;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.Label lblLoaiTen;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Button btnThemLoaiTN;
        private System.Windows.Forms.DataGridView dgvLoaiTN;


        private System.Windows.Forms.Label lblDVMa;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.Label lblDVTen;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.Label lblDVDVT;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.Label lblDVGia;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.Button btnThemDV;
        private System.Windows.Forms.DataGridView dgvDV;


        private System.Windows.Forms.Label lblQDMa;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.Label lblQDLoai;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.Label lblQDMucDo;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.Label lblQDTien;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Button btnThemQD;
        private System.Windows.Forms.DataGridView dgvQD;
    }
}