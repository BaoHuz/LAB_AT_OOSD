using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmMain
    {
        private Label lblTitle;
        private FlowLayoutPanel flow;

        private Button btnTangVP;
        private Button btnKH;
        private Button btnHD;
        private Button btnTT;
        private Button btnDV;
        private Button btnHDDV;
        private Button btnGH;
        private Button btnNV;
        private Button btnThe;
        private Button btnKT;

        private Button B(string text, EventHandler click)
        {
            Button btn = new Button();

            btn.Text = text;
            btn.Width = 280;
            btn.Height = 65;
            btn.Margin = new Padding(15);

            btn.Font = new Font(
                "Times New Roman",
                13F,
                FontStyle.Bold
            );

            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderColor = Color.LightGray;
            btn.FlatAppearance.BorderSize = 1;

            btn.Cursor = Cursors.Hand;

            btn.Click += click;

            return btn;
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.flow = new FlowLayoutPanel();

            this.Text = "LAB8 - Quản lý cho thuê văn phòng";

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.ClientSize =
                new Size(1000, 700);

            this.MinimumSize =
                new Size(1000, 700);

            this.BackColor =
                Color.FromArgb(245, 245, 245);

            this.Font =
                new Font(
                    "Times New Roman",
                    12F,
                    FontStyle.Regular
                );


            this.lblTitle.Text =
                "HỆ THỐNG QUẢN LÝ CHO THUÊ VĂN PHÒNG CAO ỐC";

            this.lblTitle.Dock =
                DockStyle.Top;

            this.lblTitle.Height =
                110;

            this.lblTitle.TextAlign =
                ContentAlignment.MiddleCenter;

            this.lblTitle.Font =
                new Font(
                    "Times New Roman",
                    22F,
                    FontStyle.Bold
                );

            this.lblTitle.ForeColor =
                Color.FromArgb(25, 25, 25);

            this.lblTitle.BackColor =
                Color.White;

            this.flow.Dock =
                DockStyle.Fill;

            this.flow.FlowDirection =
                FlowDirection.LeftToRight;

            this.flow.WrapContents =
                true;

            this.flow.AutoScroll =
                true;

            this.flow.Padding =
                new Padding(25, 35, 25, 25);

            this.flow.BackColor =
                Color.FromArgb(245, 245, 245);

            this.btnTangVP =
                B(
                    "Tầng - Văn phòng",
                    btnTangVP_Click
                );

            this.btnKH =
                B(
                    "Khách hàng",
                    btnKH_Click
                );

            this.btnHD =
                B(
                    "Hợp đồng thuê",
                    btnHD_Click
                );

            this.btnTT =
                B(
                    "Thanh toán tiền thuê",
                    btnTT_Click
                );

            this.btnDV =
                B(
                    "Dịch vụ",
                    btnDV_Click
                );

            this.btnHDDV =
                B(
                    "Hóa đơn dịch vụ",
                    btnHDDV_Click
                );

            this.btnGH =
                B(
                    "Gia hạn",
                    btnGH_Click
                );

            this.btnNV =
                B(
                    "Nhân viên văn phòng",
                    btnNV_Click
                );

            this.btnThe =
                B(
                    "Thẻ giữ xe",
                    btnThe_Click
                );

            this.btnKT =
                B(
                    "Kiểm tra phòng",
                    btnKT_Click
                );

            this.flow.Controls.AddRange(
                new Control[]
                {
                    this.btnTangVP,
                    this.btnKH,
                    this.btnHD,

                    this.btnTT,
                    this.btnDV,
                    this.btnHDDV,

                    this.btnGH,
                    this.btnNV,
                    this.btnThe,

                    this.btnKT
                }
            );

            this.Controls.Add(
                this.flow
            );

            this.Controls.Add(
                this.lblTitle
            );
        }
    }
}