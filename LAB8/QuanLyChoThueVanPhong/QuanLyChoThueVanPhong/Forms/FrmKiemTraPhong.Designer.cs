using System.Drawing;
using System.Windows.Forms;

namespace QuanLyChoThueVanPhong.Forms
{
    partial class FrmKiemTraPhong
    {
        TextBox txtMa,
            txtTT,
            txtKN,
            txtNguoi;
        ComboBox cboVP;
        DateTimePicker dtNgay;
        CheckBox chkDoi;
        NumericUpDown numPhat;
        Button btnThem,
            btnSua,
            btnXoa;
        DataGridView dgv;

        Label L(string t, int x, int y)
        {
            return new Label
            {
                Text = t,
                Left = x,
                Top = y,
                Width = 140,
            };
        }

        private void InitializeComponent()
        {
            Text = "Kiểm tra phòng";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(1100, 680);
            Font = new Font("Segoe UI", 10F);
            txtMa = new TextBox
            {
                Left = 160,
                Top = 20,
                Width = 160,
            };
            cboVP = new ComboBox
            {
                Left = 160,
                Top = 60,
                Width = 240,
                DropDownStyle = ComboBoxStyle.DropDownList,
            };
            dtNgay = new DateTimePicker
            {
                Left = 160,
                Top = 100,
                Width = 170,
                Format = DateTimePickerFormat.Short,
            };
            txtTT = new TextBox
            {
                Left = 160,
                Top = 140,
                Width = 380,
                Height = 70,
                Multiline = true,
            };
            chkDoi = new CheckBox
            {
                Left = 700,
                Top = 20,
                Text = "Có thay đổi kết cấu",
            };
            numPhat = new NumericUpDown
            {
                Left = 700,
                Top = 60,
                Width = 200,
                Maximum = 1000000000,
                ThousandsSeparator = true,
            };
            txtKN = new TextBox
            {
                Left = 700,
                Top = 100,
                Width = 330,
                Height = 55,
                Multiline = true,
            };
            txtNguoi = new TextBox
            {
                Left = 700,
                Top = 165,
                Width = 260,
            };
            btnThem = new Button
            {
                Text = "Thêm",
                Left = 160,
                Top = 225,
                Width = 100,
            };
            btnThem.Click += btnThem_Click;
            btnSua = new Button
            {
                Text = "Sửa",
                Left = 270,
                Top = 225,
                Width = 100,
            };
            btnSua.Click += btnSua_Click;
            btnXoa = new Button
            {
                Text = "Xóa",
                Left = 380,
                Top = 225,
                Width = 100,
            };
            btnXoa.Click += btnXoa_Click;
            dgv = new DataGridView
            {
                Left = 20,
                Top = 290,
                Width = 1040,
                Height = 330,
            };
            dgv.CellClick += dgv_CellClick;
            Controls.AddRange(
                new Control[]
                {
                    L("Mã kiểm tra", 20, 24),
                    txtMa,
                    L("Văn phòng", 20, 64),
                    cboVP,
                    L("Ngày kiểm tra", 20, 104),
                    dtNgay,
                    L("Tình trạng", 20, 144),
                    txtTT,
                    chkDoi,
                    L("Mức phạt", 560, 64),
                    numPhat,
                    L("Kiến nghị sửa chữa", 560, 104),
                    txtKN,
                    L("Người kiểm tra", 560, 169),
                    txtNguoi,
                    btnThem,
                    btnSua,
                    btnXoa,
                    dgv,
                }
            );
        }
    }
}
