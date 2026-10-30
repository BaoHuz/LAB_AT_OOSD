using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmNhanVien
    {
        TextBox txtMa,
            txtTen,
            txtCV;
        ComboBox cboKH,
            cboVP;
        DateTimePicker dtNgay;
        CheckBox chkDang;
        PictureBox pic;
        Button btnAnh,
            btnThem,
            btnSua,
            btnNghi;
        DataGridView dgv;

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
            Text = "Nhân viên văn phòng";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1100, 680);
            Font = new Font("Segoe UI", 10F);
            txtMa = new TextBox
            {
                Left = 140,
                Top = 20,
                Width = 160,
            };
            cboKH = new ComboBox
            {
                Left = 140,
                Top = 60,
                Width = 300,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            cboVP = new ComboBox
            {
                Left = 140,
                Top = 100,
                Width = 220,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            txtTen = new TextBox
            {
                Left = 560,
                Top = 20,
                Width = 250,
            };
            txtCV = new TextBox
            {
                Left = 560,
                Top = 60,
                Width = 220,
            };
            dtNgay = new DateTimePicker
            {
                Left = 560,
                Top = 100,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            chkDang = new CheckBox
            {
                Left = 560,
                Top = 140,
                Text = "Đang làm việc",
                Checked = true,
            };
            pic = new PictureBox
            {
                Left = 850,
                Top = 20,
                Width = 180,
                Height = 140,
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            btnAnh = new Button
            {
                Text = "Chọn ảnh",
                Left = 850,
                Top = 170,
                Width = 100,
            };
            btnAnh.Click += btnAnh_Click;
            btnThem = new Button
            {
                Text = "Thêm",
                Left = 140,
                Top = 160,
                Width = 100,
            };
            btnThem.Click += btnThem_Click;
            btnSua = new Button
            {
                Text = "Sửa",
                Left = 250,
                Top = 160,
                Width = 100,
            };
            btnSua.Click += btnSua_Click;
            btnNghi = new Button
            {
                Text = "Nghỉ việc",
                Left = 360,
                Top = 160,
                Width = 100,
            };
            btnNghi.Click += btnNghi_Click;
            dgv = new DataGridView
            {
                Left = 20,
                Top = 230,
                Width = 1040,
                Height = 390,
            };
            dgv.CellClick += dgv_CellClick;
            Controls.AddRange(
                new Control[]
                {
                    L("Mã NV", 20, 24),
                    txtMa,
                    L("Công ty", 20, 64),
                    cboKH,
                    L("Văn phòng", 20, 104),
                    cboVP,
                    L("Họ tên", 440, 24),
                    txtTen,
                    L("Chức vụ", 440, 64),
                    txtCV,
                    L("Ngày bắt đầu", 440, 104),
                    dtNgay,
                    chkDang,
                    pic,
                    btnAnh,
                    btnThem,
                    btnSua,
                    btnNghi,
                    dgv,
                }
            );
        }
    }
}
