using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanLyKhachSan.Forms
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDanhMuc = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnDatPhong = new System.Windows.Forms.Button();
            this.btnDichVu = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.imgListIcons = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // imgListIcons
            // 
            this.imgListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListIcons.ImageSize = new System.Drawing.Size(32, 32);
            this.imgListIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(10, 50, 110);
            this.lblTitle.Location = new System.Drawing.Point(192, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(416, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ KHÁCH SẠN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDanhMuc.ImageList = this.imgListIcons;
            this.btnDanhMuc.ImageIndex = 0;
            this.btnDanhMuc.Location = new System.Drawing.Point(30, 95);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDanhMuc.Size = new System.Drawing.Size(230, 65);
            this.btnDanhMuc.TabIndex = 1;
            this.btnDanhMuc.Text = "   Danh mục";
            this.btnDanhMuc.UseVisualStyleBackColor = true;
            this.btnDanhMuc.Click += new System.EventHandler(this.btnDanhMuc_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPhong.ImageList = this.imgListIcons;
            this.btnPhong.ImageIndex = 1;
            this.btnPhong.Location = new System.Drawing.Point(280, 95);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPhong.Size = new System.Drawing.Size(230, 65);
            this.btnPhong.TabIndex = 2;
            this.btnPhong.Text = " Phòng - Tiện nghi";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnDatPhong
            // 
            this.btnDatPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDatPhong.ImageList = this.imgListIcons;
            this.btnDatPhong.ImageIndex = 2;
            this.btnDatPhong.Location = new System.Drawing.Point(530, 95);
            this.btnDatPhong.Name = "btnDatPhong";
            this.btnDatPhong.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDatPhong.Size = new System.Drawing.Size(230, 65);
            this.btnDatPhong.TabIndex = 3;
            this.btnDatPhong.Text = " Đặt / Nhận phòng";
            this.btnDatPhong.UseVisualStyleBackColor = true;
            this.btnDatPhong.Click += new System.EventHandler(this.btnDatPhong_Click);
            // 
            // btnDichVu
            // 
            this.btnDichVu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichVu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichVu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDichVu.ImageList = this.imgListIcons;
            this.btnDichVu.ImageIndex = 3;
            this.btnDichVu.Location = new System.Drawing.Point(30, 180);
            this.btnDichVu.Name = "btnDichVu";
            this.btnDichVu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDichVu.Size = new System.Drawing.Size(230, 65);
            this.btnDichVu.TabIndex = 4;
            this.btnDichVu.Text = " Sử dụng dịch vụ";
            this.btnDichVu.UseVisualStyleBackColor = true;
            this.btnDichVu.Click += new System.EventHandler(this.btnDichVu_Click);
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTraPhong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTraPhong.ImageList = this.imgListIcons;
            this.btnTraPhong.ImageIndex = 4;
            this.btnTraPhong.Location = new System.Drawing.Point(280, 180);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnTraPhong.Size = new System.Drawing.Size(230, 65);
            this.btnTraPhong.TabIndex = 5;
            this.btnTraPhong.Text = " Trả phòng - Thanh toán";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.ImageList = this.imgListIcons;
            this.btnThongKe.ImageIndex = 5;
            this.btnThongKe.Location = new System.Drawing.Point(530, 180);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnThongKe.Size = new System.Drawing.Size(230, 65);
            this.btnThongKe.TabIndex = 6;
            this.btnThongKe.Text = "   Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.ImageList = this.imgListIcons;
            this.btnThoat.ImageIndex = 6;
            this.btnThoat.Location = new System.Drawing.Point(280, 265);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnThoat.Size = new System.Drawing.Size(230, 65);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "     Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 360);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnTraPhong);
            this.Controls.Add(this.btnDichVu);
            this.Controls.Add(this.btnDatPhong);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnDanhMuc);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách sạn";


            this.TaoIconMacDinh();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private void TaoIconMacDinh()
        {
            this.imgListIcons.Images.Clear();


            Bitmap bmp0 = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp0))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRectangle(Brushes.RoyalBlue, 6, 2, 20, 28);
                g.FillRectangle(Brushes.White, 8, 5, 16, 22);
                g.FillEllipse(Brushes.DodgerBlue, 10, 8, 3, 3);
                g.FillEllipse(Brushes.DodgerBlue, 10, 14, 3, 3);
                g.FillEllipse(Brushes.DodgerBlue, 10, 20, 3, 3);
                using (Pen p = new Pen(Color.DodgerBlue, 2))
                {
                    g.DrawLine(p, 15, 10, 21, 10);
                    g.DrawLine(p, 15, 16, 21, 16);
                    g.DrawLine(p, 15, 22, 21, 22);
                }
            }
            this.imgListIcons.Images.Add(bmp0);


            Bitmap bmp1 = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp1))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRectangle(Brushes.SaddleBrown, 3, 8, 4, 18);
                g.FillRectangle(Brushes.SaddleBrown, 25, 14, 4, 12);
                g.FillRectangle(Brushes.LightSkyBlue, 8, 11, 6, 6);
                g.FillRectangle(Brushes.Chocolate, 7, 17, 21, 7);
            }
            this.imgListIcons.Images.Add(bmp1);


            Bitmap bmp2 = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp2))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen p = new Pen(Color.Orange, 4))
                {
                    g.DrawEllipse(p, 4, 4, 12, 12);
                    g.DrawLine(p, 14, 14, 26, 26);
                    g.DrawLine(p, 22, 22, 26, 18);
                    g.DrawLine(p, 25, 25, 29, 21);
                }
            }
            this.imgListIcons.Images.Add(bmp2);


            Bitmap bmp3 = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp3))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillEllipse(Brushes.SlateGray, 4, 4, 24, 24);
                g.FillEllipse(Brushes.White, 11, 11, 10, 10);
                for (int i = 0; i < 8; i++)
                {
                    double angle = i * System.Math.PI / 4;
                    int x = (int)(16 + 13 * System.Math.Cos(angle)) - 2;
                    int y = (int)(16 + 13 * System.Math.Sin(angle)) - 2;
                    g.FillRectangle(Brushes.SlateGray, x, y, 5, 5);
                }
            }
            this.imgListIcons.Images.Add(bmp3);


            Bitmap bmp4 = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp4))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRectangle(Brushes.MediumSeaGreen, 4, 8, 24, 16);
                using (Pen p = new Pen(Color.White, 2))
                {
                    g.DrawRectangle(p, 6, 10, 20, 12);
                }
                g.FillEllipse(Brushes.Gold, 12, 12, 8, 8);
            }
            this.imgListIcons.Images.Add(bmp4);


            Bitmap bmp5 = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp5))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRectangle(Brushes.DodgerBlue, 4, 18, 6, 10);
                g.FillRectangle(Brushes.Orange, 13, 12, 6, 16);
                g.FillRectangle(Brushes.LimeGreen, 22, 6, 6, 22);
            }
            this.imgListIcons.Images.Add(bmp5);


            Bitmap bmp6 = new Bitmap(32, 32);
            using (Graphics g = Graphics.FromImage(bmp6))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillRectangle(Brushes.Sienna, 4, 4, 12, 24);
                g.FillEllipse(Brushes.Gold, 13, 15, 2, 2);
                Point[] arrow = {
                    new Point(18, 13), new Point(24, 13), new Point(24, 10),
                    new Point(29, 16), new Point(24, 22), new Point(24, 19), new Point(18, 19)
                };
                g.FillPolygon(Brushes.ForestGreen, arrow);
            }
            this.imgListIcons.Images.Add(bmp6);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDanhMuc;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnDatPhong;
        private System.Windows.Forms.Button btnDichVu;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ImageList imgListIcons;
    }
}