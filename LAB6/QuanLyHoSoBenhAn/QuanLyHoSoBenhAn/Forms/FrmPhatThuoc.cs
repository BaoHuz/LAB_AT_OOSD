using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmPhatThuoc : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True";

        public FrmPhatThuoc()
        {
            InitializeComponent();
        }

        private void btnPhatThuoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaToaThuoc.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã toa thuốc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"UPDATE TOATHUOC 
                                    SET TrangThai = N'Đã phát thuốc' 
                                    WHERE MaToaThuoc = @MaToaThuoc";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaToaThuoc", Convert.ToInt32(txtMaToaThuoc.Text.Trim()));

                    int rows = cmd.ExecuteNonQuery();
                    if (rows > 0)
                    {
                        MessageBox.Show("Xác nhận phát thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã toa thuốc không tồn tại hoặc chưa thanh toán!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xác nhận phát thuốc: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}