using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmHopDong
    {
        TextBox txtMaHD,
            txtGhiChu;
        ComboBox cboKH;
        DateTimePicker dtNgayKy,
            dtBatDau;
        NumericUpDown numThang;
        DataGridView dgvTrong,
            dgvChon,
            dgvHD,
            dgvChiTiet;
        Button btnAddVP,
            btnRemoveVP,
            btnLap;

        Label L(string t, int x, int y)
        {
            return new Label
            {
                Text = t,
                Left = x,
                Top = y,
                Width = 120,
            };
        }

        private void InitializeComponent()
        {
            Text = "Lập hợp đồng thuê";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1250, 760);
            Font = new Font("Segoe UI", 10F);
            txtMaHD = new TextBox
            {
                Left = 130,
                Top = 18,
                Width = 150,
            };
            cboKH = new ComboBox
            {
                Left = 130,
                Top = 55,
                Width = 330,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            dtNgayKy = new DateTimePicker
            {
                Left = 130,
                Top = 92,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            dtBatDau = new DateTimePicker
            {
                Left = 600,
                Top = 18,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            numThang = new NumericUpDown
            {
                Left = 600,
                Top = 55,
                Width = 100,
            };
            txtGhiChu = new TextBox
            {
                Left = 600,
                Top = 92,
                Width = 380,
            };
            dgvTrong = new DataGridView
            {
                Left = 20,
                Top = 160,
                Width = 510,
                Height = 200,
            };
            dgvChon = new DataGridView
            {
                Left = 700,
                Top = 160,
                Width = 510,
                Height = 200,
            };
            btnAddVP = new Button
            {
                Text = ">>",
                Left = 565,
                Top = 205,
                Width = 100,
                Height = 40,
            };
            btnAddVP.Click += btnAddVP_Click;
            btnRemoveVP = new Button
            {
                Text = "<<",
                Left = 565,
                Top = 260,
                Width = 100,
                Height = 40,
            };
            btnRemoveVP.Click += btnRemoveVP_Click;
            btnLap = new Button
            {
                Text = "LẬP HỢP ĐỒNG",
                Left = 535,
                Top = 375,
                Width = 180,
                Height = 45,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
            };
            btnLap.Click += btnLap_Click;
            dgvHD = new DataGridView
            {
                Left = 20,
                Top = 440,
                Width = 750,
                Height = 260,
            };
            dgvHD.CellClick += dgvHD_CellClick;
            dgvChiTiet = new DataGridView
            {
                Left = 790,
                Top = 440,
                Width = 420,
                Height = 260,
            };
            Controls.AddRange(
                new Control[]
                {
                    L("Mã hợp đồng", 20, 22),
                    txtMaHD,
                    L("Khách hàng", 20, 59),
                    cboKH,
                    L("Ngày ký", 20, 96),
                    dtNgayKy,
                    L("Ngày bắt đầu", 480, 22),
                    dtBatDau,
                    L("Số tháng thuê", 480, 59),
                    numThang,
                    L("Ghi chú", 480, 96),
                    txtGhiChu,
                    new Label
                    {
                        Text = "Văn phòng còn trống",
                        Left = 20,
                        Top = 135,
                        Width = 200,
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    },
                    new Label
                    {
                        Text = "Văn phòng đã chọn",
                        Left = 700,
                        Top = 135,
                        Width = 200,
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    },
                    dgvTrong,
                    dgvChon,
                    btnAddVP,
                    btnRemoveVP,
                    btnLap,
                    new Label
                    {
                        Text = "Danh sách hợp đồng",
                        Left = 20,
                        Top = 415,
                        Width = 200,
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    },
                    new Label
                    {
                        Text = "Chi tiết văn phòng",
                        Left = 790,
                        Top = 415,
                        Width = 200,
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    },
                    dgvHD,
                    dgvChiTiet,
                }
            );
        }
    }
}
