using System;
using System.Windows.Forms;
using QuanLyNhanSuDongA.Data;
using QuanLyNhanSuDongA.Services;

namespace QuanLyNhanSuDongA.Forms
{
    public partial class FrmBangLuong : Form
    {
        private readonly LuongService service = new LuongService();

        public FrmBangLuong()
        {
            InitializeComponent();
            FormLayout.Apply(this);
        }

        private void FrmBangLuong_Load(object sender, EventArgs e)
        {
            try
            {
                numThang.Value = DateTime.Today.Month;
                numNam.Value = DateTime.Today.Year;
                LoadMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Không thể nạp dữ liệu: " + ex.Message, "Lỗi dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMaster()
        {
            dgvBangLuong.DataSource = Db.Query("SELECT MaBangLuong, Thang, Nam, NgayLap, NguoiLap FROM BangLuong ORDER BY Nam DESC, Thang DESC");
        }

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            var res = service.TinhLuongThang((int)numThang.Value, (int)numNam.Value, txtNguoiLap.Text);
            MessageBox.Show(res.ThongBao, res.ThanhCong ? "Thông báo" : "Lỗi");
            if (res.ThanhCong) LoadMaster();
        }

        private void dgvBangLuong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBangLuong.CurrentRow != null)
            {
                string ma = dgvBangLuong.CurrentRow.Cells["MaBangLuong"].Value?.ToString();
                if (!string.IsNullOrEmpty(ma))
                {
                    dgvChiTiet.DataSource = Db.Query(@"SELECT c.MaNV, n.HoTen, c.LuongCoBan, c.PhuCapLuong, c.PhuCapDocHai, c.PhuCapChucVu, 
                                                              c.NgayCongThucTe, c.TienTheoCong, c.TienPhuTroi, c.KhauTruBaoHiem, c.KhauTruKyLuat, c.ThucLinh
                                                       FROM ChiTietBangLuong c 
                                                       JOIN NhanVien n ON c.MaNV = n.MaNV 
                                                       WHERE c.MaBangLuong = @m", new System.Data.SqlClient.SqlParameter("@m", ma));
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e) => Close();
    }
}