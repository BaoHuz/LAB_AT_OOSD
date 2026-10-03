using System;
using System.Data;
using System.Data.SqlClient;
using eShoppingApp.Data;

namespace eShoppingApp.Services
{
    public class AccountService
    {
        public static string CurrentMaKH = "";
        public static string CurrentHoTen = "";

        public bool Login(string username, string password, out string msg)
        {
            msg = "";
            string query = "SELECT MaKH, HoTen FROM KhachHang WHERE TenDangNhap = @User AND MatKhau = @Pass";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@User", username),
                new SqlParameter("@Pass", password)
            };

            DataTable dt = Db.ExecuteQuery(query, parameters);
            if (dt.Rows.Count > 0)
            {
                CurrentMaKH = dt.Rows[0]["MaKH"].ToString();
                CurrentHoTen = dt.Rows[0]["HoTen"].ToString();
                msg = "Đăng nhập thành công!";
                return true;
            }
            msg = "Tên đăng nhập hoặc mật khẩu không chính xác!";
            return false;
        }

        public bool Register(string hoTen, string username, string password, string email, string phone, string address, out string msg)
        {
            msg = "";
            try
            {
                string maKH = "KH" + DateTime.Now.ToString("fffss");
                string sql = @"INSERT INTO KhachHang (MaKH, HoTen, TenDangNhap, MatKhau, Email, DienThoai, DiaChi) 
                               VALUES (@MaKH, @HoTen, @User, @Pass, @Email, @Phone, @Addr)";

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaKH", maKH),
                    new SqlParameter("@HoTen", hoTen),
                    new SqlParameter("@User", username),
                    new SqlParameter("@Pass", password),
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Addr", address)
                };

                using (SqlConnection conn = Db.GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddRange(parameters);
                    cmd.ExecuteNonQuery();
                }

                msg = "Đăng ký tài khoản thành công!";
                return true;
            }
            catch (Exception ex)
            {
                msg = "Lỗi đăng ký: " + ex.Message;
                return false;
            }
        }
    }
}