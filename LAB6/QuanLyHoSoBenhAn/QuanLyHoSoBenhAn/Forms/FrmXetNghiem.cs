using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmXetNghiem : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True";

        public FrmXetNghiem()
        {
            InitializeComponent();
        }

        private void btnCapNhatKetQua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaChiDinh.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã chỉ định xét nghiệm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE CHIDINHXETNGHIEM 
                                    SET KetQua = @KetQua, TrangThai = N'DaCoKetQua', NgayThucHien = GETDATE() 
                                    WHERE MaChiDinh = @MaChiDinh";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@KetQua", txtKetQua.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaChiDinh", Convert.ToInt32(txtMaChiDinh.Text.Trim()));

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Cập nhật kết quả xét nghiệm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Mã chỉ định xét nghiệm phù hợp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}