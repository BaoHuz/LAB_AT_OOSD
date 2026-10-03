using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using eShoppingApp.Data;
using eShoppingApp.Services;

namespace eShoppingApp.UI
{
    public partial class frmDanhSachSanPham : Form
    {
        private List<CartItem> cart = new List<CartItem>();

        public frmDanhSachSanPham()
        {
            InitializeComponent();
        }

        private void frmDanhSachSanPham_Load(object sender, EventArgs e)
        {
            LoadNhomSanPham();
            LoadSanPham();
        }

        private void LoadNhomSanPham()
        {
            try
            {
                DataTable dt = Db.ExecuteQuery("SELECT MaNhom, TenNhom FROM NhomSanPham");
                cbNhomSP.DataSource = dt;
                cbNhomSP.DisplayMember = "TenNhom";
                cbNhomSP.ValueMember = "MaNhom";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhóm sản phẩm: " + ex.Message);
            }
        }

        private void LoadSanPham()
        {
            try
            {
                string maNhom = cbNhomSP.SelectedValue?.ToString();
                string query = "SELECT MaSP, TenSP, GiaBanHienHang, TinhTrang FROM SanPham";
                if (!string.IsNullOrEmpty(maNhom) && maNhom != "System.Data.DataRowView")
                {
                    query += $" WHERE MaNhom = '{maNhom}'";
                }
                dgvSanPham.DataSource = Db.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message);
            }
        }

        private void cbNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSanPham();
        }

        private void btnThemGio_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                string maSP = dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();
                string tenSP = dgvSanPham.CurrentRow.Cells["TenSP"].Value.ToString();
                decimal donGia = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["GiaBanHienHang"].Value);

                var item = cart.Find(x => x.MaSP == maSP);
                if (item != null)
                {
                    item.SoLuong++;
                }
                else
                {
                    cart.Add(new CartItem { MaSP = maSP, TenSP = tenSP, SoLuong = 1, DonGia = donGia });
                }

                CapNhatGioHang();
            }
        }

        private void btnXoaKhoiGio_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow != null)
            {
                string maSP = dgvGioHang.CurrentRow.Cells["MaSP"].Value.ToString();
                cart.RemoveAll(x => x.MaSP == maSP);
                CapNhatGioHang();
            }
        }

        private void CapNhatGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = cart;

            decimal tong = 0;
            foreach (var item in cart) tong += item.ThanhTien;
            lblTongTien.Text = $"Tổng cộng: {tong:N0} VNĐ";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn sản phẩm trước khi tính tiền.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển sang Form Thanh toán (nếu chưa có FormThanhToan, bạn thêm lớp này vào UI)
            frmThanhToan frmThanhToan = new frmThanhToan(cart);
            frmThanhToan.ShowDialog();
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow != null)
            {
                string maSP = dgvSanPham.CurrentRow.Cells["MaSP"].Value.ToString();
                frmChiTietSanPham frm = new frmChiTietSanPham(maSP);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}