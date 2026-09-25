namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblQT = new System.Windows.Forms.Label();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.tabDatPhong = new System.Windows.Forms.TabPage();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.lblKenh = new System.Windows.Forms.Label();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.lblCoc = new System.Windows.Forms.Label();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.lblPhieuDatPhong = new System.Windows.Forms.Label();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblLap = new System.Windows.Forms.Label();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.lblNhan = new System.Windows.Forms.Label();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.lblTra = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.tabNhanPhong = new System.Windows.Forms.TabPage();
            this.lblPhieuChon = new System.Windows.Forms.Label();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.lblNguoiPhong = new System.Windows.Forms.Label();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.lblNguoiTen = new System.Windows.Forms.Label();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.lblNguoiCMND = new System.Windows.Forms.Label();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.lblNguoiQT = new System.Windows.Forms.Label();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.tabMain.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.tabDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            this.tabNhanPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabKhachHang);
            this.tabMain.Controls.Add(this.tabDatPhong);
            this.tabMain.Controls.Add(this.tabNhanPhong);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(10, 10);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 1;
            this.tabMain.Size = new System.Drawing.Size(844, 460);
            this.tabMain.TabIndex = 0;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Controls.Add(this.lblMaKH);
            this.tabKhachHang.Controls.Add(this.txtMaKH);
            this.tabKhachHang.Controls.Add(this.lblTenKH);
            this.tabKhachHang.Controls.Add(this.txtTenKH);
            this.tabKhachHang.Controls.Add(this.lblCMND);
            this.tabKhachHang.Controls.Add(this.txtCMND);
            this.tabKhachHang.Controls.Add(this.lblQT);
            this.tabKhachHang.Controls.Add(this.txtQT);
            this.tabKhachHang.Controls.Add(this.lblSDT);
            this.tabKhachHang.Controls.Add(this.txtSDT);
            this.tabKhachHang.Controls.Add(this.btnThemKhach);
            this.tabKhachHang.Controls.Add(this.dgvKhach);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 26);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(10);
            this.tabKhachHang.Size = new System.Drawing.Size(836, 430);
            this.tabKhachHang.TabIndex = 0;
            this.tabKhachHang.Text = "Khách hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(10, 18);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(101, 17);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(115, 15);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(110, 25);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(235, 18);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(50, 17);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Họ tên:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(288, 15);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(140, 25);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(440, 18);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(91, 17);
            this.lblCMND.TabIndex = 4;
            this.lblCMND.Text = "CCCD / CMND:";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(535, 15);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(110, 25);
            this.txtCMND.TabIndex = 5;
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(655, 18);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(66, 17);
            this.lblQT.TabIndex = 6;
            this.lblQT.Text = "Quốc tịch:";
            // 
            // txtQT
            // 
            this.txtQT.Location = new System.Drawing.Point(725, 15);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(100, 25);
            this.txtQT.TabIndex = 7;
            this.txtQT.Text = "Việt Nam";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(10, 52);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(88, 17);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(115, 49);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(110, 25);
            this.txtSDT.TabIndex = 9;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(715, 47);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(110, 30);
            this.btnThemKhach.TabIndex = 10;
            this.btnThemKhach.Text = "Thêm khách";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // dgvKhach
            // 
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(10, 85);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.Size = new System.Drawing.Size(815, 335);
            this.dgvKhach.TabIndex = 11;
            // 
            // tabDatPhong
            // 
            this.tabDatPhong.Controls.Add(this.lblSoPhieu);
            this.tabDatPhong.Controls.Add(this.txtSoPhieu);
            this.tabDatPhong.Controls.Add(this.lblKhach);
            this.tabDatPhong.Controls.Add(this.cboKhach);
            this.tabDatPhong.Controls.Add(this.lblKenh);
            this.tabDatPhong.Controls.Add(this.cboKenh);
            this.tabDatPhong.Controls.Add(this.lblCoc);
            this.tabDatPhong.Controls.Add(this.numCoc);
            this.tabDatPhong.Controls.Add(this.dgvPhong);
            this.tabDatPhong.Controls.Add(this.dgvChon);
            this.tabDatPhong.Controls.Add(this.btnLapPhieu);
            this.tabDatPhong.Controls.Add(this.lblPhieuDatPhong);
            this.tabDatPhong.Controls.Add(this.dgvPhieu);
            this.tabDatPhong.Controls.Add(this.lblNV);
            this.tabDatPhong.Controls.Add(this.cboNV);
            this.tabDatPhong.Controls.Add(this.lblLap);
            this.tabDatPhong.Controls.Add(this.dtLap);
            this.tabDatPhong.Controls.Add(this.lblNhan);
            this.tabDatPhong.Controls.Add(this.dtNhan);
            this.tabDatPhong.Controls.Add(this.lblTra);
            this.tabDatPhong.Controls.Add(this.dtTra);
            this.tabDatPhong.Controls.Add(this.lblSoNguoi);
            this.tabDatPhong.Controls.Add(this.numSoNguoi);
            this.tabDatPhong.Controls.Add(this.btnThemPhong);
            this.tabDatPhong.Controls.Add(this.btnBoPhong);
            this.tabDatPhong.Location = new System.Drawing.Point(4, 26);
            this.tabDatPhong.Name = "tabDatPhong";
            this.tabDatPhong.Padding = new System.Windows.Forms.Padding(10);
            this.tabDatPhong.Size = new System.Drawing.Size(836, 430);
            this.tabDatPhong.TabIndex = 1;
            this.tabDatPhong.Text = "Đặt phòng";
            this.tabDatPhong.UseVisualStyleBackColor = true;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(10, 18);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(87, 17);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu đặt:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(98, 15);
            this.txtSoPhieu.Name = "txtSoPhieuFiles";
            this.txtSoPhieu.Size = new System.Drawing.Size(120, 25);
            this.txtSoPhieu.TabIndex = 1;
            this.txtSoPhieu.Text = "DP001";
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(230, 18);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(46, 17);
            this.lblKhach.TabIndex = 2;
            this.lblKhach.Text = "Khách:";
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(278, 15);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(160, 25);
            this.cboKhach.TabIndex = 3;
            // 
            // lblKenh
            // 
            this.lblKenh.AutoSize = true;
            this.lblKenh.Location = new System.Drawing.Point(450, 18);
            this.lblKenh.Name = "lblKenh";
            this.lblKenh.Size = new System.Drawing.Size(62, 17);
            this.lblKenh.TabIndex = 4;
            this.lblKenh.Text = "Kênh đặt:";
            // 
            // cboKenh
            // 
            this.cboKenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKenh.FormattingEnabled = true;
            this.cboKenh.Location = new System.Drawing.Point(515, 15);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(120, 25);
            this.cboKenh.TabIndex = 5;
            // 
            // lblCoc
            // 
            this.lblCoc.AutoSize = true;
            this.lblCoc.Location = new System.Drawing.Point(645, 18);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(60, 17);
            this.lblCoc.TabIndex = 6;
            this.lblCoc.Text = "Tiền cọc:";
            // 
            // numCoc
            // 
            this.numCoc.DecimalPlaces = 2;
            this.numCoc.Location = new System.Drawing.Point(708, 15);
            this.numCoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(115, 25);
            this.numCoc.TabIndex = 7;
            this.numCoc.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(10, 52);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(400, 180);
            this.dgvPhong.TabIndex = 8;
            // 
            // dgvChon
            // 
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Location = new System.Drawing.Point(423, 52);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.Size = new System.Drawing.Size(400, 180);
            this.dgvChon.TabIndex = 9;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(688, 240);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(135, 32);
            this.btnLapPhieu.TabIndex = 10;
            this.btnLapPhieu.Text = "Lập phiếu đặt";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // lblPhieuDatPhong
            // 
            this.lblPhieuDatPhong.AutoSize = true;
            this.lblPhieuDatPhong.Location = new System.Drawing.Point(10, 255);
            this.lblPhieuDatPhong.Name = "lblPhieuDatPhong";
            this.lblPhieuDatPhong.Size = new System.Drawing.Size(107, 17);
            this.lblPhieuDatPhong.TabIndex = 11;
            this.lblPhieuDatPhong.Text = "Phiếu đặt phòng:";
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(10, 278);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.Size = new System.Drawing.Size(813, 142);
            this.dgvPhieu.TabIndex = 12;
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);
            // 
            // lblNV
            // 
            this.lblNV.Location = new System.Drawing.Point(0, 0);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(0, 0);
            this.lblNV.TabIndex = 13;
            this.lblNV.Visible = false;
            // 
            // cboNV
            // 
            this.cboNV.Location = new System.Drawing.Point(0, 0);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(0, 25);
            this.cboNV.TabIndex = 14;
            this.cboNV.Visible = false;
            // 
            // lblLap
            // 
            this.lblLap.Location = new System.Drawing.Point(0, 0);
            this.lblLap.Name = "lblLap";
            this.lblLap.Size = new System.Drawing.Size(0, 0);
            this.lblLap.TabIndex = 15;
            this.lblLap.Visible = false;
            // 
            // dtLap
            // 
            this.dtLap.Location = new System.Drawing.Point(0, 0);
            this.dtLap.Name = "dtLap";
            this.dtLap.Size = new System.Drawing.Size(0, 25);
            this.dtLap.TabIndex = 16;
            this.dtLap.Visible = false;
            // 
            // lblNhan
            // 
            this.lblNhan.Location = new System.Drawing.Point(0, 0);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(0, 0);
            this.lblNhan.TabIndex = 17;
            this.lblNhan.Visible = false;
            // 
            // dtNhan
            // 
            this.dtNhan.Location = new System.Drawing.Point(0, 0);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(0, 25);
            this.dtNhan.TabIndex = 18;
            this.dtNhan.Visible = false;
            // 
            // lblTra
            // 
            this.lblTra.Location = new System.Drawing.Point(0, 0);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(0, 0);
            this.lblTra.TabIndex = 19;
            this.lblTra.Visible = false;
            // 
            // dtTra
            // 
            this.dtTra.Location = new System.Drawing.Point(0, 0);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(0, 25);
            this.dtTra.TabIndex = 20;
            this.dtTra.Visible = false;
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.Location = new System.Drawing.Point(0, 0);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(0, 0);
            this.lblSoNguoi.TabIndex = 21;
            this.lblSoNguoi.Visible = false;
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(0, 0);
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(0, 25);
            this.numSoNguoi.TabIndex = 22;
            this.numSoNguoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoNguoi.Visible = false;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(0, 0);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(0, 0);
            this.btnThemPhong.TabIndex = 23;
            this.btnThemPhong.Visible = false;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnBoPhong
            // 
            this.btnBoPhong.Location = new System.Drawing.Point(0, 0);
            this.btnBoPhong.Name = "btnBoPhong";
            this.btnBoPhong.Size = new System.Drawing.Size(0, 0);
            this.btnBoPhong.TabIndex = 24;
            this.btnBoPhong.Visible = false;
            this.btnBoPhong.Click += new System.EventHandler(this.btnBoPhong_Click);
            // 
            // tabNhanPhong
            // 
            this.tabNhanPhong.Controls.Add(this.lblPhieuChon);
            this.tabNhanPhong.Controls.Add(this.txtPhieuChon);
            this.tabNhanPhong.Controls.Add(this.lblNguoiPhong);
            this.tabNhanPhong.Controls.Add(this.txtNguoiPhong);
            this.tabNhanPhong.Controls.Add(this.lblNguoiTen);
            this.tabNhanPhong.Controls.Add(this.txtNguoiTen);
            this.tabNhanPhong.Controls.Add(this.lblNguoiCMND);
            this.tabNhanPhong.Controls.Add(this.txtNguoiCMND);
            this.tabNhanPhong.Controls.Add(this.lblNguoiQT);
            this.tabNhanPhong.Controls.Add(this.txtNguoiQT);
            this.tabNhanPhong.Controls.Add(this.btnThemNguoi);
            this.tabNhanPhong.Controls.Add(this.btnNhanPhong);
            this.tabNhanPhong.Controls.Add(this.btnNoShow);
            this.tabNhanPhong.Controls.Add(this.dgvCT);
            this.tabNhanPhong.Controls.Add(this.dgvNguoi);
            this.tabNhanPhong.Location = new System.Drawing.Point(4, 26);
            this.tabNhanPhong.Name = "tabNhanPhong";
            this.tabNhanPhong.Padding = new System.Windows.Forms.Padding(10);
            this.tabNhanPhong.Size = new System.Drawing.Size(836, 430);
            this.tabNhanPhong.TabIndex = 2;
            this.tabNhanPhong.Text = "Nhận phòng / Người lưu trú";
            this.tabNhanPhong.UseVisualStyleBackColor = true;
            // 
            // lblPhieuChon
            // 
            this.lblPhieuChon.AutoSize = true;
            this.lblPhieuChon.Location = new System.Drawing.Point(10, 18);
            this.lblPhieuChon.Name = "lblPhieuChon";
            this.lblPhieuChon.Size = new System.Drawing.Size(74, 17);
            this.lblPhieuChon.TabIndex = 0;
            this.lblPhieuChon.Text = "Phiếu chọn:";
            // 
            // txtPhieuChon
            // 
            this.txtPhieuChon.Location = new System.Drawing.Point(88, 15);
            this.txtPhieuChon.Name = "txtPhieuChon";
            this.txtPhieuChon.ReadOnly = true;
            this.txtPhieuChon.Size = new System.Drawing.Size(100, 25);
            this.txtPhieuChon.TabIndex = 1;
            // 
            // lblNguoiPhong
            // 
            this.lblNguoiPhong.AutoSize = true;
            this.lblNguoiPhong.Location = new System.Drawing.Point(200, 18);
            this.lblNguoiPhong.Name = "lblNguoiPhong";
            this.lblNguoiPhong.Size = new System.Drawing.Size(48, 17);
            this.lblNguoiPhong.TabIndex = 2;
            this.lblNguoiPhong.Text = "Phòng:";
            // 
            // txtNguoiPhong
            // 
            this.txtNguoiPhong.Location = new System.Drawing.Point(252, 15);
            this.txtNguoiPhong.Name = "txtNguoiPhong";
            this.txtNguoiPhong.Size = new System.Drawing.Size(80, 25);
            this.txtNguoiPhong.TabIndex = 3;
            // 
            // lblNguoiTen
            // 
            this.lblNguoiTen.AutoSize = true;
            this.lblNguoiTen.Location = new System.Drawing.Point(340, 18);
            this.lblNguoiTen.Name = "lblNguoiTen";
            this.lblNguoiTen.Size = new System.Drawing.Size(50, 17);
            this.lblNguoiTen.TabIndex = 4;
            this.lblNguoiTen.Text = "Họ tên:";
            // 
            // txtNguoiTen
            // 
            this.txtNguoiTen.Location = new System.Drawing.Point(392, 15);
            this.txtNguoiTen.Name = "txtNguoiTen";
            this.txtNguoiTen.Size = new System.Drawing.Size(120, 25);
            this.txtNguoiTen.TabIndex = 5;
            // 
            // lblNguoiCMND
            // 
            this.lblNguoiCMND.AutoSize = true;
            this.lblNguoiCMND.Location = new System.Drawing.Point(520, 18);
            this.lblNguoiCMND.Name = "lblNguoiCMND";
            this.lblNguoiCMND.Size = new System.Drawing.Size(50, 17);
            this.lblNguoiCMND.TabIndex = 6;
            this.lblNguoiCMND.Text = "CMND:";
            // 
            // txtNguoiCMND
            // 
            this.txtNguoiCMND.Location = new System.Drawing.Point(572, 15);
            this.txtNguoiCMND.Name = "txtNguoiCMND";
            this.txtNguoiCMND.Size = new System.Drawing.Size(100, 25);
            this.txtNguoiCMND.TabIndex = 7;
            // 
            // lblNguoiQT
            // 
            this.lblNguoiQT.AutoSize = true;
            this.lblNguoiQT.Location = new System.Drawing.Point(680, 18);
            this.lblNguoiQT.Name = "lblNguoiQT";
            this.lblNguoiQT.Size = new System.Drawing.Size(66, 17);
            this.lblNguoiQT.TabIndex = 8;
            this.lblNguoiQT.Text = "Quốc tịch:";
            // 
            // txtNguoiQT
            // 
            this.txtNguoiQT.Location = new System.Drawing.Point(748, 15);
            this.txtNguoiQT.Name = "txtNguoiQT";
            this.txtNguoiQT.Size = new System.Drawing.Size(78, 25);
            this.txtNguoiQT.TabIndex = 9;
            this.txtNguoiQT.Text = "Việt Nam";
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Location = new System.Drawing.Point(716, 48);
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(110, 30);
            this.btnThemNguoi.TabIndex = 10;
            this.btnThemNguoi.Text = "Thêm người";
            this.btnThemNguoi.UseVisualStyleBackColor = true;
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Location = new System.Drawing.Point(580, 388);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(115, 32);
            this.btnNhanPhong.TabIndex = 11;
            this.btnNhanPhong.Text = "Nhận phòng";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnNoShow
            // 
            this.btnNoShow.Location = new System.Drawing.Point(705, 388);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(121, 32);
            this.btnNoShow.TabIndex = 12;
            this.btnNoShow.Text = "Báo Hủy (No-Show)";
            this.btnNoShow.UseVisualStyleBackColor = true;
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);
            // 
            // dgvCT
            // 
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(10, 85);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.Size = new System.Drawing.Size(816, 140);
            this.dgvCT.TabIndex = 13;
            // 
            // dgvNguoi
            // 
            this.dgvNguoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoi.Location = new System.Drawing.Point(10, 235);
            this.dgvNguoi.Name = "dgvNguoi";
            this.dgvNguoi.Size = new System.Drawing.Size(816, 145);
            this.dgvNguoi.TabIndex = 14;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(755, 480);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 32);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 522);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDatPhong";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load);
            this.tabMain.ResumeLayout(false);
            this.tabKhachHang.ResumeLayout(false);
            this.tabKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.tabDatPhong.ResumeLayout(false);
            this.tabDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            this.tabNhanPhong.ResumeLayout(false);
            this.tabNhanPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.TabPage tabDatPhong;
        private System.Windows.Forms.TabPage tabNhanPhong;
        private System.Windows.Forms.Button btnDong;


        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.DataGridView dgvKhach;


        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.Label lblKenh;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label lblPhieuDatPhong;
        private System.Windows.Forms.DataGridView dgvPhieu;

        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblLap;
        private System.Windows.Forms.DateTimePicker dtLap;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnBoPhong;


        private System.Windows.Forms.Label lblPhieuChon;
        private System.Windows.Forms.TextBox txtPhieuChon;
        private System.Windows.Forms.Label lblNguoiPhong;
        private System.Windows.Forms.TextBox txtNguoiPhong;
        private System.Windows.Forms.Label lblNguoiTen;
        private System.Windows.Forms.TextBox txtNguoiTen;
        private System.Windows.Forms.Label lblNguoiCMND;
        private System.Windows.Forms.TextBox txtNguoiCMND;
        private System.Windows.Forms.Label lblNguoiQT;
        private System.Windows.Forms.TextBox txtNguoiQT;
        private System.Windows.Forms.Button btnThemNguoi;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnNoShow;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.DataGridView dgvNguoi;
    }
}