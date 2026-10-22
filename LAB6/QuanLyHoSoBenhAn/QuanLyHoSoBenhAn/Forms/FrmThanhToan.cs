using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmThanhToan : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True";

        public FrmThanhToan()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhieuKham.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu khám cần thanh toán!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO HOADON (MaPhieuKham, NgayLap, TongTien, TrangThai) 
                                    VALUES (@MaPhieuKham, GETDATE(), @TongTien, N'Đã thanh toán');";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MaPhieuKham", Convert.ToInt32(txtMaPhieuKham.Text.Trim()));
                    cmd.Parameters.AddWithValue("@TongTien", Convert.ToDecimal(txtTongTien.Text.Trim()));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lập hóa đơn thanh toán: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}