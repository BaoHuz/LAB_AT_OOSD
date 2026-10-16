using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuanLyHoSoBenhAn.Data;
using QuanLyHoSoBenhAn.Services;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmLapToa : Form
    {
        private DataTable dtDongThuoc;
        private ToaThuocService toaThuocService = new ToaThuocService();

        // Constructor nhận mã phiếu khám truyền vào
        public FrmLapToa(string maPhieuKham = "PK01", string maBS = "BS01", string chanDoan = "Viêm phế quản cấp")
        {
            InitializeComponent();
            txtMaPhieuKham.Text = maPhieuKham;
            txtMaBS.Text = maBS;
            txtChanDoan.Text = chanDoan;
            txtMaToa.Text = "TOA" + DateTime.Now.ToString("ddHHmmss");
        }

        private void FrmLapToa_Load(object sender, EventArgs e)
        {
            KhoiTaoDataTableSchema();
            NapDanhSachThuocVaoComboBox();
        }

        /// <summary>
        /// Tạo Schema khớp 100% với User-Defined Table Type: dbo.DongToaThuoc
        /// (MaThuoc: string, SoLuong: int, LieuDung: string, CachDung: string)
        /// </summary>
        private void KhoiTaoDataTableSchema()
        {
            dtDongThuoc = new DataTable();
            dtDongThuoc.Columns.Add("MaThuoc", typeof(string));
            dtDongThuoc.Columns.Add("TenThuoc", typeof(string)); // Cột hỗ trợ hiển thị trên Grid
            dtDongThuoc.Columns.Add("SoLuong", typeof(int));
            dtDongThuoc.Columns.Add("LieuDung", typeof(string));
            dtDongThuoc.Columns.Add("CachDung", typeof(string));

            dgvChiTietToa.DataSource = dtDongThuoc;

            // Đổi tên tiêu đề cột DataGridView
            if (dgvChiTietToa.Columns["MaThuoc"] != null) dgvChiTietToa.Columns["MaThuoc"].HeaderText = "Mã Thuốc";
            if (dgvChiTietToa.Columns["TenThuoc"] != null) dgvChiTietToa.Columns["TenThuoc"].HeaderText = "Tên Thuốc";
            if (dgvChiTietToa.Columns["SoLuong"] != null) dgvChiTietToa.Columns["SoLuong"].HeaderText = "Số Lượng";
            if (dgvChiTietToa.Columns["LieuDung"] != null) dgvChiTietToa.Columns["LieuDung"].HeaderText = "Liều Dùng";
            if (dgvChiTietToa.Columns["CachDung"] != null) dgvChiTietToa.Columns["CachDung"].HeaderText = "Cách Dùng";
        }

        /// <summary>
        /// Tải danh mục thuốc đang sử dụng từ CSDL lên ComboBox
        /// </summary>
        private void NapDanhSachThuocVaoComboBox()
        {
            try
            {
                using (SqlConnection cn = Db.CreateConnection())
                using (SqlCommand cmd = new SqlCommand("SELECT MaThuoc, TenThuoc, DonViTinh FROM Thuoc WHERE DangSuDung = 1", cn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cboThuoc.DataSource = dt;
                    cboThuoc.DisplayMember = "TenThuoc";
                    cboThuoc.ValueMember = "MaThuoc";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh mục thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemThuoc_Click(object sender, EventArgs e)
        {
            if (cboThuoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc từ danh mục!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maThuoc = cboThuoc.SelectedValue.ToString();
            string tenThuoc = cboThuoc.Text;
            int soLuong = (int)numSoLuong.Value;
            string lieuDung = txtLieuDung.Text.Trim();
            string cachDung = txtCachDung.Text.Trim();

            if (string.IsNullOrEmpty(lieuDung) || string.IsNullOrEmpty(cachDung))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ liều dùng và cách dùng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng thuốc trong toa
            foreach (DataRow row in dtDongThuoc.Rows)
            {
                if (row["MaThuoc"].ToString() == maThuoc)
                {
                    MessageBox.Show("Thuốc này đã có trong toa thuốc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            // Thêm vào DataTable
            dtDongThuoc.Rows.Add(maThuoc, tenThuoc, soLuong, lieuDung, cachDung);

            // Reset ô nhập liệu
            txtLieuDung.Clear();
            txtCachDung.Clear();
            numSoLuong.Value = 10;
        }

        private void btnXoaThuoc_Click(object sender, EventArgs e)
        {
            if (dgvChiTietToa.CurrentRow != null && !dgvChiTietToa.CurrentRow.IsNewRow)
            {
                dgvChiTietToa.Rows.RemoveAt(dgvChiTietToa.CurrentRow.Index);
            }
        }

        private void btnLuuToa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaToa.Text) || string.IsNullOrWhiteSpace(txtMaPhieuKham.Text))
            {
                MessageBox.Show("Mã toa và mã phiếu khám không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtDongThuoc.Rows.Count == 0)
            {
                MessageBox.Show("Toa thuốc phải có ít nhất một loại thuốc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnLuuToa.Enabled = false;

                // Chuẩn bị DataTable đúng chuẩn TVP (bỏ cột TenThuoc dư)
                DataTable dtTVP = new DataTable();
                dtTVP.Columns.Add("MaThuoc", typeof(string));
                dtTVP.Columns.Add("SoLuong", typeof(int));
                dtTVP.Columns.Add("LieuDung", typeof(string));
                dtTVP.Columns.Add("CachDung", typeof(string));

                foreach (DataRow dr in dtDongThuoc.Rows)
                {
                    dtTVP.Rows.Add(dr["MaThuoc"], dr["SoLuong"], dr["LieuDung"], dr["CachDung"]);
                }

                // Gọi Service thực thi Stored Procedure sp_LapToaThuoc trong Transaction
                toaThuocService.LapToaThuoc(
                    txtMaToa.Text.Trim(),
                    txtMaPhieuKham.Text.Trim(),
                    txtMaBS.Text.Trim(),
                    txtDanDo.Text.Trim(),
                    dtTVP
                );

                MessageBox.Show("Lập toa thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnInToa.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu toa thuốc: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLuuToa.Enabled = true;
            }
        }

        private void btnInToa_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Đang in toa thuốc [{txtMaToa.Text}] cho phiếu [{txtMaPhieuKham.Text}]...", "In toa thuốc", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}