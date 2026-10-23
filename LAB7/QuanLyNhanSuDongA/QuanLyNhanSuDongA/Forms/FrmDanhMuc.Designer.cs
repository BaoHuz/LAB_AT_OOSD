namespace QuanLyNhanSuDongA.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPB = new System.Windows.Forms.TabPage { Text = "Phòng Ban" };
            this.tabCa = new System.Windows.Forms.TabPage { Text = "Ca Làm Việc" };
            this.tabCV = new System.Windows.Forms.TabPage { Text = "Chức Vụ" };

            this.dgvPhongBan = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Dock = System.Windows.Forms.DockStyle.Fill };
            this.tabPB.Controls.Add(this.dgvPhongBan);

            this.dgvCaLam = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Dock = System.Windows.Forms.DockStyle.Fill };
            this.tabCa.Controls.Add(this.dgvCaLam);

            this.dgvChucVu = new System.Windows.Forms.DataGridView { AutoGenerateColumns = true, ReadOnly = true, AllowUserToAddRows = false, AllowUserToDeleteRows = false, AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells, SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect, BackgroundColor = System.Drawing.SystemColors.Window, Dock = System.Windows.Forms.DockStyle.Fill };
            this.tabCV.Controls.Add(this.dgvChucVu);

            this.tabMain.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabPB, this.tabCa, this.tabCV });
            this.tabMain.Location = new System.Drawing.Point(15, 15);
            this.tabMain.Size = new System.Drawing.Size(650, 320);

            this.btnDong = new System.Windows.Forms.Button { Text = "Đóng", Location = new System.Drawing.Point(560, 345), Size = new System.Drawing.Size(105, 30) };
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmDanhMuc_Load);
            this.ClientSize = new System.Drawing.Size(680, 385);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.tabMain, this.btnDong });
            this.Text = "Quản lý Danh mục Hệ thống";
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPB, tabCa, tabCV;
        private System.Windows.Forms.DataGridView dgvPhongBan, dgvCaLam, dgvChucVu;
        private System.Windows.Forms.Button btnDong;
    }
}