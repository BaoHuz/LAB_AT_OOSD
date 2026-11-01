using System;
using System.Collections.Generic;
using System.Windows.Forms;
using eShoppingApp.Services;

namespace eShoppingApp.UI
{
    public partial class frmThanhToan : Form
    {
        private List<CartItem> cartItems;
        private OrderService orderService;

        public frmThanhToan(List<CartItem> items)
        {
            InitializeComponent();
            this.cartItems = items;
            this.orderService = new OrderService();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            cbLoaiPhieu.SelectedIndex = 1; 
            cbKhuVuc.SelectedIndex = 0;    
            cbLoaiThe.SelectedIndex = 0;    

            TinhTongTien();
        }

        private void TinhTongTien()
        {
            decimal cartTotal = 0;
            foreach (var item in cartItems)
            {
                cartTotal += item.ThanhTien;
            }

            string loaiPhieu = cbLoaiPhieu.SelectedItem?.ToString() ?? "CPN";
            string khuVuc = cbKhuVuc.SelectedItem?.ToString() ?? "NoiThanh";

            decimal phiGiao = orderService.CalculateShippingFee(cartTotal, loaiPhieu, khuVuc);
            decimal grandTotal = cartTotal + phiGiao;

            lblTongTien.Text = $"TỔNG THANH TOÁN: {grandTotal:N0} VNĐ (Phí giao: {phiGiao:N0}đ)";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
   
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin người nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoThe.Text) ||
                string.IsNullOrWhiteSpace(txtCSV.Text) ||
                string.IsNullOrWhiteSpace(txtChuThe.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thẻ tín dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = AccountService.CurrentMaKH;

            if (string.IsNullOrWhiteSpace(maKH))
            {
                MessageBox.Show(
                    "Vui lòng đăng nhập trước khi đặt hàng.",
                    "Yêu cầu đăng nhập",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            bool isSuccess = orderService.ProcessOrder(
                maKH,
                cartItems,
                txtHoTen.Text.Trim(),
                txtDiaChi.Text.Trim(),
                txtSDT.Text.Trim(),
                cbLoaiPhieu.SelectedItem.ToString(),
                cbKhuVuc.SelectedItem.ToString(),
                cbLoaiThe.SelectedItem.ToString(),
                txtSoThe.Text.Trim(),
                txtExpiry.Text.Trim(),
                txtChuThe.Text.Trim(),
                txtCSV.Text.Trim(),
                txtEmail.Text.Trim(),
                out string resultMsg
            );

            if (isSuccess)
            {
                MessageBox.Show(resultMsg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(resultMsg, "Lỗi thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}