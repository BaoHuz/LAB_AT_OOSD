using System;
using System.Data;
using System.Data.SqlClient;
using eShoppingApp.Data;

namespace eShoppingApp.Services
{
    public class ProductAdapter
    {
        public DataTable GetProductDetails(string maSP)
        {
            string query = @"SELECT sp.MaSP, sp.TenSP, sp.NhaSanXuat, sp.HinhAnh, sp.MoTa, 
                                   sp.GiaBanHienHang, sp.TinhTrang, nsp.TenNhom 
                            FROM SanPham sp 
                            JOIN NhomSanPham nsp ON sp.MaNhom = nsp.MaNhom 
                            WHERE sp.MaSP = @MaSP";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MaSP", maSP)
            };
            return Db.ExecuteQuery(query, parameters);
        }
    }
}