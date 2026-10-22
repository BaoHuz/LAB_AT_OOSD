using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn.Forms
{
    public partial class FrmHoSo : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True";

        public FrmHoSo()
        {
            InitializeComponent();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTuKhoa.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoa))
            {
                MessageBox.Show("Vui lòng nhập Mã hồ sơ, Họ tên hoặc Số điện thoại để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT hs.MaHoSo, bn.MaBenhNhan, bn.HoTen, bn.NgaySinh, bn.DienThai, hs.NgayCap, hs.HanDongPhi 
                                    FROM HOSOBENHAN hs 
                                    JOIN BENHNHAN bn ON hs.MaBenhNhan = bn.MaBenhNhan 
                                    WHERE hs.MaHoSo LIKE @TK OR bn.HoTen LIKE @TK OR bn.DienThai LIKE @TK";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@TK", "%" + tuKhoa + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvHoSo.DataSource = dt;
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không tìm thấy hồ sơ bệnh án phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}