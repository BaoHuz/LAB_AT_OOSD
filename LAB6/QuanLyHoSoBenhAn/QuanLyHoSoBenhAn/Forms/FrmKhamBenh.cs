using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmKhamBenh : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True";

        public FrmKhamBenh()
        {
            InitializeComponent();
        }

        private void btnLuuPhieuKham_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaHoSo.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã hồ sơ bệnh án!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO PHIEUKHAM (MaHoSo, NgayKham, TrieuChung, ChanDoan, TrangThai) 
                                    VALUES (@MaHoSo, GETDATE(), @TrieuChung, @ChanDoan, N'Đang khám');
                                    SELECT SCOPE_IDENTITY();";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaHoSo", txtMaHoSo.Text.Trim());
                    cmd.Parameters.AddWithValue("@TrieuChung", txtTrieuChung.Text.Trim());
                    cmd.Parameters.AddWithValue("@ChanDoan", txtChanDoan.Text.Trim());

                    int maPhieuKham = Convert.ToInt32(cmd.ExecuteScalar());
                    txtMaPhieuKham.Text = maPhieuKham.ToString();

                    MessageBox.Show("Tạo phiếu khám thành công! Mã phiếu: " + maPhieuKham, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tạo phiếu khám: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}