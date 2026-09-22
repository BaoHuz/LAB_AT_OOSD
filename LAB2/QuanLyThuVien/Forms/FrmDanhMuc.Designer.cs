namespace QuanLyThuVien.Forms
{
    partial class FrmDanhMuc
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabNV = new System.Windows.Forms.TabPage();
            this.lblNVMa = new System.Windows.Forms.Label();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.lblNVHo = new System.Windows.Forms.Label();
            this.txtNVHo = new System.Windows.Forms.TextBox();
            this.lblNVTen = new System.Windows.Forms.Label();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.lblNVPhai = new System.Windows.Forms.Label();
            this.cboNVPhai = new System.Windows.Forms.ComboBox();
            this.lblNVNgaySinh = new System.Windows.Forms.Label();
            this.dtNVNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNVChucVu = new System.Windows.Forms.Label();
            this.txtNVChucVu = new System.Windows.Forms.TextBox();
            this.lblNVSDT = new System.Windows.Forms.Label();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnNVThem = new System.Windows.Forms.Button();
            this.btnNVCapNhat = new System.Windows.Forms.Button();
            this.btnNVXoa = new System.Windows.Forms.Button();
            this.btnNVMoi = new System.Windows.Forms.Button();
            this.dgvNV = new System.Windows.Forms.DataGridView();

            this.tabTL = new System.Windows.Forms.TabPage();
            this.lblTLMa = new System.Windows.Forms.Label();
            this.txtTLMa = new System.Windows.Forms.TextBox();
            this.lblTLTen = new System.Windows.Forms.Label();
            this.txtTLTen = new System.Windows.Forms.TextBox();
            this.btnTLThem = new System.Windows.Forms.Button();
            this.btnTLCapNhat = new System.Windows.Forms.Button();
            this.btnTLXoa = new System.Windows.Forms.Button();
            this.btnTLMoi = new System.Windows.Forms.Button();
            this.dgvTL = new System.Windows.Forms.DataGridView();

            this.tabNXB = new System.Windows.Forms.TabPage();
            this.lblNXBMa = new System.Windows.Forms.Label();
            this.txtNXBMa = new System.Windows.Forms.TextBox();
            this.lblNXBDiaChi = new System.Windows.Forms.Label();
            this.txtNXBDiaChi = new System.Windows.Forms.TextBox();
            this.lblNXBSDT = new System.Windows.Forms.Label();
            this.txtNXBSDT = new System.Windows.Forms.TextBox();
            this.btnNXBThem = new System.Windows.Forms.Button();
            this.btnNXBCapNhat = new System.Windows.Forms.Button();
            this.btnNXBXoa = new System.Windows.Forms.Button();
            this.btnNXBMoi = new System.Windows.Forms.Button();
            this.dgvNXB = new System.Windows.Forms.DataGridView();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabs.SuspendLayout();
            this.tabNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            this.tabTL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).BeginInit();
            this.tabNXB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).BeginInit();
            this.SuspendLayout();


            this.tabs.Controls.Add(this.tabNV);
            this.tabs.Controls.Add(this.tabTL);
            this.tabs.Controls.Add(this.tabNXB);
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1020, 620);
            this.tabs.TabIndex = 0;


            this.tabNV.Controls.Add(this.lblNVMa);
            this.tabNV.Controls.Add(this.txtNVMa);
            this.tabNV.Controls.Add(this.lblNVHo);
            this.tabNV.Controls.Add(this.txtNVHo);
            this.tabNV.Controls.Add(this.lblNVTen);
            this.tabNV.Controls.Add(this.txtNVTen);
            this.tabNV.Controls.Add(this.lblNVPhai);
            this.tabNV.Controls.Add(this.cboNVPhai);
            this.tabNV.Controls.Add(this.lblNVNgaySinh);
            this.tabNV.Controls.Add(this.dtNVNgaySinh);
            this.tabNV.Controls.Add(this.lblNVChucVu);
            this.tabNV.Controls.Add(this.txtNVChucVu);
            this.tabNV.Controls.Add(this.lblNVSDT);
            this.tabNV.Controls.Add(this.txtNVSDT);
            this.tabNV.Controls.Add(this.btnNVThem);
            this.tabNV.Controls.Add(this.btnNVCapNhat);
            this.tabNV.Controls.Add(this.btnNVXoa);
            this.tabNV.Controls.Add(this.btnNVMoi);
            this.tabNV.Controls.Add(this.dgvNV);
            this.tabNV.Location = new System.Drawing.Point(4, 30);
            this.tabNV.Name = "tabNV";
            this.tabNV.Padding = new System.Windows.Forms.Padding(3);
            this.tabNV.Size = new System.Drawing.Size(1012, 586);
            this.tabNV.TabIndex = 0;
            this.tabNV.Text = "Nhân viên";
            this.tabNV.UseVisualStyleBackColor = true;


            this.lblNVMa.AutoSize = true;
            this.lblNVMa.Location = new System.Drawing.Point(20, 25);
            this.lblNVMa.Text = "Mã nhân viên:";

            this.txtNVMa.Location = new System.Drawing.Point(130, 22);
            this.txtNVMa.Size = new System.Drawing.Size(180, 29);

            this.lblNVHo.AutoSize = true;
            this.lblNVHo.Location = new System.Drawing.Point(20, 65);
            this.lblNVHo.Text = "Họ:";

            this.txtNVHo.Location = new System.Drawing.Point(130, 62);
            this.txtNVHo.Size = new System.Drawing.Size(180, 29);

            this.lblNVTen.AutoSize = true;
            this.lblNVTen.Location = new System.Drawing.Point(20, 105);
            this.lblNVTen.Text = "Tên:";

            this.txtNVTen.Location = new System.Drawing.Point(130, 102);
            this.txtNVTen.Size = new System.Drawing.Size(180, 29);

            this.lblNVPhai.AutoSize = true;
            this.lblNVPhai.Location = new System.Drawing.Point(340, 25);
            this.lblNVPhai.Text = "Phái:";

            this.cboNVPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNVPhai.Location = new System.Drawing.Point(440, 22);
            this.cboNVPhai.Size = new System.Drawing.Size(180, 29);

            this.lblNVNgaySinh.AutoSize = true;
            this.lblNVNgaySinh.Location = new System.Drawing.Point(340, 65);
            this.lblNVNgaySinh.Text = "Ngày sinh:";

            this.dtNVNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNVNgaySinh.Location = new System.Drawing.Point(440, 62);
            this.dtNVNgaySinh.Size = new System.Drawing.Size(180, 29);

            this.lblNVChucVu.AutoSize = true;
            this.lblNVChucVu.Location = new System.Drawing.Point(340, 105);
            this.lblNVChucVu.Text = "Chức vụ:";

            this.txtNVChucVu.Location = new System.Drawing.Point(440, 102);
            this.txtNVChucVu.Size = new System.Drawing.Size(180, 29);

            this.lblNVSDT.AutoSize = true;
            this.lblNVSDT.Location = new System.Drawing.Point(20, 145);
            this.lblNVSDT.Text = "Điện thoại:";

            this.txtNVSDT.Location = new System.Drawing.Point(130, 142);
            this.txtNVSDT.Size = new System.Drawing.Size(180, 29);


            this.btnNVThem.Location = new System.Drawing.Point(680, 22);
            this.btnNVThem.Size = new System.Drawing.Size(100, 35);
            this.btnNVThem.Text = "Thêm";
            this.btnNVThem.Click += new System.EventHandler(this.btnNVThem_Click);

            this.btnNVCapNhat.Location = new System.Drawing.Point(790, 22);
            this.btnNVCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnNVCapNhat.Text = "Cập nhật";
            this.btnNVCapNhat.Click += new System.EventHandler(this.btnNVCapNhat_Click);

            this.btnNVXoa.Location = new System.Drawing.Point(680, 65);
            this.btnNVXoa.Size = new System.Drawing.Size(100, 35);
            this.btnNVXoa.Text = "Xóa";
            this.btnNVXoa.Click += new System.EventHandler(this.btnNVXoa_Click);

            this.btnNVMoi.Location = new System.Drawing.Point(790, 65);
            this.btnNVMoi.Size = new System.Drawing.Size(100, 35);
            this.btnNVMoi.Text = "Làm mới";
            this.btnNVMoi.Click += new System.EventHandler(this.btnNVMoi_Click);


            this.dgvNV.AllowUserToAddRows = false;
            this.dgvNV.AllowUserToDeleteRows = false;
            this.dgvNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNV.Location = new System.Drawing.Point(20, 190);
            this.dgvNV.MultiSelect = false;
            this.dgvNV.ReadOnly = true;
            this.dgvNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNV.Size = new System.Drawing.Size(970, 370);
            this.dgvNV.SelectionChanged += new System.EventHandler(this.dgvNV_SelectionChanged);


            this.tabTL.Controls.Add(this.lblTLMa);
            this.tabTL.Controls.Add(this.txtTLMa);
            this.tabTL.Controls.Add(this.lblTLTen);
            this.tabTL.Controls.Add(this.txtTLTen);
            this.tabTL.Controls.Add(this.btnTLThem);
            this.tabTL.Controls.Add(this.btnTLCapNhat);
            this.tabTL.Controls.Add(this.btnTLXoa);
            this.tabTL.Controls.Add(this.btnTLMoi);
            this.tabTL.Controls.Add(this.dgvTL);
            this.tabTL.Location = new System.Drawing.Point(4, 30);
            this.tabTL.Name = "tabTL";
            this.tabTL.Padding = new System.Windows.Forms.Padding(3);
            this.tabTL.Size = new System.Drawing.Size(1012, 586);
            this.tabTL.TabIndex = 1;
            this.tabTL.Text = "Thể loại";
            this.tabTL.UseVisualStyleBackColor = true;


            this.lblTLMa.AutoSize = true;
            this.lblTLMa.Location = new System.Drawing.Point(20, 30);
            this.lblTLMa.Text = "Mã thể loại:";

            this.txtTLMa.Location = new System.Drawing.Point(130, 27);
            this.txtTLMa.Size = new System.Drawing.Size(220, 29);

            this.lblTLTen.AutoSize = true;
            this.lblTLTen.Location = new System.Drawing.Point(20, 75);
            this.lblTLTen.Text = "Tên thể loại:";

            this.txtTLTen.Location = new System.Drawing.Point(130, 72);
            this.txtTLTen.Size = new System.Drawing.Size(220, 29);

            this.btnTLThem.Location = new System.Drawing.Point(400, 27);
            this.btnTLThem.Size = new System.Drawing.Size(100, 35);
            this.btnTLThem.Text = "Thêm";
            this.btnTLThem.Click += new System.EventHandler(this.btnTLThem_Click);

            this.btnTLCapNhat.Location = new System.Drawing.Point(510, 27);
            this.btnTLCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnTLCapNhat.Text = "Cập nhật";
            this.btnTLCapNhat.Click += new System.EventHandler(this.btnTLCapNhat_Click);

            this.btnTLXoa.Location = new System.Drawing.Point(400, 70);
            this.btnTLXoa.Size = new System.Drawing.Size(100, 35);
            this.btnTLXoa.Text = "Xóa";
            this.btnTLXoa.Click += new System.EventHandler(this.btnTLXoa_Click);

            this.btnTLMoi.Location = new System.Drawing.Point(510, 70);
            this.btnTLMoi.Size = new System.Drawing.Size(100, 35);
            this.btnTLMoi.Text = "Làm mới";
            this.btnTLMoi.Click += new System.EventHandler(this.btnTLMoi_Click);

            this.dgvTL.AllowUserToAddRows = false;
            this.dgvTL.AllowUserToDeleteRows = false;
            this.dgvTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTL.Location = new System.Drawing.Point(20, 130);
            this.dgvTL.MultiSelect = false;
            this.dgvTL.ReadOnly = true;
            this.dgvTL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTL.Size = new System.Drawing.Size(970, 430);
            this.dgvTL.SelectionChanged += new System.EventHandler(this.dgvTL_SelectionChanged);


            this.tabNXB.Controls.Add(this.lblNXBMa);
            this.tabNXB.Controls.Add(this.txtNXBMa);
            this.tabNXB.Controls.Add(this.lblNXBDiaChi);
            this.tabNXB.Controls.Add(this.txtNXBDiaChi);
            this.tabNXB.Controls.Add(this.lblNXBSDT);
            this.tabNXB.Controls.Add(this.txtNXBSDT);
            this.tabNXB.Controls.Add(this.btnNXBThem);
            this.tabNXB.Controls.Add(this.btnNXBCapNhat);
            this.tabNXB.Controls.Add(this.btnNXBXoa);
            this.tabNXB.Controls.Add(this.btnNXBMoi);
            this.tabNXB.Controls.Add(this.dgvNXB);
            this.tabNXB.Location = new System.Drawing.Point(4, 30);
            this.tabNXB.Name = "tabNXB";
            this.tabNXB.Size = new System.Drawing.Size(1012, 586);
            this.tabNXB.TabIndex = 2;
            this.tabNXB.Text = "Nhà xuất bản";
            this.tabNXB.UseVisualStyleBackColor = true;


            this.lblNXBMa.AutoSize = true;
            this.lblNXBMa.Location = new System.Drawing.Point(20, 25);
            this.lblNXBMa.Text = "Mã NXB:";

            this.txtNXBMa.Location = new System.Drawing.Point(130, 22);
            this.txtNXBMa.Size = new System.Drawing.Size(220, 29);

            this.lblNXBDiaChi.AutoSize = true;
            this.lblNXBDiaChi.Location = new System.Drawing.Point(20, 65);
            this.lblNXBDiaChi.Text = "Địa chỉ:";

            this.txtNXBDiaChi.Location = new System.Drawing.Point(130, 62);
            this.txtNXBDiaChi.Size = new System.Drawing.Size(220, 29);

            this.lblNXBSDT.AutoSize = true;
            this.lblNXBSDT.Location = new System.Drawing.Point(20, 105);
            this.lblNXBSDT.Text = "Điện thoại:";

            this.txtNXBSDT.Location = new System.Drawing.Point(130, 102);
            this.txtNXBSDT.Size = new System.Drawing.Size(220, 29);

            this.btnNXBThem.Location = new System.Drawing.Point(400, 22);
            this.btnNXBThem.Size = new System.Drawing.Size(100, 35);
            this.btnNXBThem.Text = "Thêm";
            this.btnNXBThem.Click += new System.EventHandler(this.btnNXBThem_Click);

            this.btnNXBCapNhat.Location = new System.Drawing.Point(510, 22);
            this.btnNXBCapNhat.Size = new System.Drawing.Size(100, 35);
            this.btnNXBCapNhat.Text = "Cập nhật";
            this.btnNXBCapNhat.Click += new System.EventHandler(this.btnNXBCapNhat_Click);

            this.btnNXBXoa.Location = new System.Drawing.Point(400, 65);
            this.btnNXBXoa.Size = new System.Drawing.Size(100, 35);
            this.btnNXBXoa.Text = "Xóa";
            this.btnNXBXoa.Click += new System.EventHandler(this.btnNXBXoa_Click);

            this.btnNXBMoi.Location = new System.Drawing.Point(510, 65);
            this.btnNXBMoi.Size = new System.Drawing.Size(100, 35);
            this.btnNXBMoi.Text = "Làm mới";
            this.btnNXBMoi.Click += new System.EventHandler(this.btnNXBMoi_Click);

            this.dgvNXB.AllowUserToAddRows = false;
            this.dgvNXB.AllowUserToDeleteRows = false;
            this.dgvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNXB.Location = new System.Drawing.Point(20, 150);
            this.dgvNXB.MultiSelect = false;
            this.dgvNXB.ReadOnly = true;
            this.dgvNXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNXB.Size = new System.Drawing.Size(970, 410);
            this.dgvNXB.SelectionChanged += new System.EventHandler(this.dgvNXB_SelectionChanged);


            this.btnDong.Location = new System.Drawing.Point(920, 640);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(110, 35);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 685);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmDanhMuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh mục và nhân viên";
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.tabs.ResumeLayout(false);
            this.tabNV.ResumeLayout(false);
            this.tabNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            this.tabTL.ResumeLayout(false);
            this.tabTL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTL)).EndInit();
            this.tabNXB.ResumeLayout(false);
            this.tabNXB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNXB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.TabPage tabTL;
        private System.Windows.Forms.TabPage tabNXB;


        private System.Windows.Forms.Label lblNVMa;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.Label lblNVHo;
        private System.Windows.Forms.TextBox txtNVHo;
        private System.Windows.Forms.Label lblNVTen;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.Label lblNVPhai;
        private System.Windows.Forms.ComboBox cboNVPhai;
        private System.Windows.Forms.Label lblNVNgaySinh;
        private System.Windows.Forms.DateTimePicker dtNVNgaySinh;
        private System.Windows.Forms.Label lblNVChucVu;
        private System.Windows.Forms.TextBox txtNVChucVu;
        private System.Windows.Forms.Label lblNVSDT;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnNVThem;
        private System.Windows.Forms.Button btnNVCapNhat;
        private System.Windows.Forms.Button btnNVXoa;
        private System.Windows.Forms.Button btnNVMoi;
        private System.Windows.Forms.DataGridView dgvNV;


        private System.Windows.Forms.Label lblTLMa;
        private System.Windows.Forms.TextBox txtTLMa;
        private System.Windows.Forms.Label lblTLTen;
        private System.Windows.Forms.TextBox txtTLTen;
        private System.Windows.Forms.Button btnTLThem;
        private System.Windows.Forms.Button btnTLCapNhat;
        private System.Windows.Forms.Button btnTLXoa;
        private System.Windows.Forms.Button btnTLMoi;
        private System.Windows.Forms.DataGridView dgvTL;


        private System.Windows.Forms.Label lblNXBMa;
        private System.Windows.Forms.TextBox txtNXBMa;
        private System.Windows.Forms.Label lblNXBDiaChi;
        private System.Windows.Forms.TextBox txtNXBDiaChi;
        private System.Windows.Forms.Label lblNXBSDT;
        private System.Windows.Forms.TextBox txtNXBSDT;
        private System.Windows.Forms.Button btnNXBThem;
        private System.Windows.Forms.Button btnNXBCapNhat;
        private System.Windows.Forms.Button btnNXBXoa;
        private System.Windows.Forms.Button btnNXBMoi;
        private System.Windows.Forms.DataGridView dgvNXB;

        private System.Windows.Forms.Button btnDong;
    }
}