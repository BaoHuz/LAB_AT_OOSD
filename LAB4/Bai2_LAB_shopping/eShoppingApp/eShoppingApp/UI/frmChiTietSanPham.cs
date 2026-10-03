using System;
using System.Data;
using System.Windows.Forms;
using eShoppingApp.Services;

namespace eShoppingApp.UI
{
    public partial class frmChiTietSanPham : Form
    {
        private string maSP;
        private ProductAdapter productAdapter = new ProductAdapter();

        public frmChiTietSanPham(string id)
        {
            InitializeComponent();
            this.maSP = id;
        }

        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            DataTable dt = productAdapter.GetProductDetails(maSP);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                lblTenSP.Text = "Tên sản phẩm: " + dr["TenSP"].ToString();
                lblNhaSX.Text = "Nhà sản xuất: " + dr["NhaSanXuat"].ToString();
                decimal gia = Convert.ToDecimal(dr["GiaBanHienHang"]);
                lblGiaBan.Text = $"Giá bán hiện tại: {gia:N0} VNĐ";
                bool status = Convert.ToBoolean(dr["TinhTrang"]);
                lblTinhTrang.Text = "Tình trạng: " + (status ? "Còn hàng" : "Hết hàng");
                txtMoTa.Text = dr["MoTa"].ToString();
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}