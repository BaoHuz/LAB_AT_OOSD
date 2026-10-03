using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using eShoppingApp.Data;

namespace eShoppingApp.Services
{
    public class CartItem
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }

    public class OrderService
    {
        public decimal CalculateShippingFee(decimal cartTotal, string deliveryType, string area)
        {
            if (cartTotal >= 5000000) return 0;
            if (cartTotal >= 1000000 && deliveryType == "CPN") return 0;

            decimal baseFee = (area == "NoiThanh") ? 20000 : 45000;
            if (deliveryType == "CPN") baseFee += 15000;
            if (deliveryType == "CPN_TRONG_NGAY") baseFee += 35000;

            return baseFee;
        }

        public bool ProcessOrder(string maKH, List<CartItem> cart, string receiverName, string receiverAddr,
                            string receiverPhone, string deliveryType, string area, string cardType,
                            string cardNumber, string expiry, string cardHolder, string csv,
                            string customerEmail, out string resultMsg)
        {
            resultMsg = "";
            decimal cartTotal = 0;
            foreach (var item in cart) cartTotal += item.ThanhTien;

            decimal shippingFee = CalculateShippingFee(cartTotal, deliveryType, area);
            decimal grandTotal = cartTotal + shippingFee;

            PaymentAdapter paymentAdapter = new PaymentAdapter();
            if (!paymentAdapter.VerifyAndPay(cardType, cardNumber, expiry, cardHolder, csv, grandTotal, out string payError))
            {
                resultMsg = "Thanh toán thất bại: " + payError;
                return false;
            }

            using (SqlConnection conn = Db.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    string maDH = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss");
                    string maskedCard = "**** **** **** " + cardNumber.Substring(cardNumber.Length - 4);

                    string sqlDonHang = @"INSERT INTO DonHang (MaDH, MaKH, NguoiNhanHoTen, NguoiNhanDiaChi, NguoiNhanDienThoai, 
                                        LoaiPhieuDat, ChiPhiGiaoHang, TongTriGia, LoaiTheThanhToan, SoTheMasked) 
                                        VALUES (@MaDH, @MaKH, @NguoiNhan, @DiaChi, @SDT, @LoaiPhieu, @PhiGiao, @TongTien, @LoaiThe, @SoThe)";

                    SqlCommand cmdDH = new SqlCommand(sqlDonHang, conn, trans);
                    cmdDH.Parameters.AddWithValue("@MaDH", maDH);
                    cmdDH.Parameters.AddWithValue("@MaKH", maKH);
                    cmdDH.Parameters.AddWithValue("@NguoiNhan", receiverName);
                    cmdDH.Parameters.AddWithValue("@DiaChi", receiverAddr);
                    cmdDH.Parameters.AddWithValue("@SDT", receiverPhone);
                    cmdDH.Parameters.AddWithValue("@LoaiPhieu", deliveryType);
                    cmdDH.Parameters.AddWithValue("@PhiGiao", shippingFee);
                    cmdDH.Parameters.AddWithValue("@TongTien", grandTotal);
                    cmdDH.Parameters.AddWithValue("@LoaiThe", cardType);
                    cmdDH.Parameters.AddWithValue("@SoThe", maskedCard);
                    cmdDH.ExecuteNonQuery();

                    foreach (var item in cart)
                    {
                        string sqlCT = @"INSERT INTO ChiTietDonHang (MaDH, MaSP, SoLuong, DonGia) 
                                        VALUES (@MaDH, @MaSP, @SoLuong, @DonGia)";
                        SqlCommand cmdCT = new SqlCommand(sqlCT, conn, trans);
                        cmdCT.Parameters.AddWithValue("@MaDH", maDH);
                        cmdCT.Parameters.AddWithValue("@MaSP", item.MaSP);
                        cmdCT.Parameters.AddWithValue("@SoLuong", item.SoLuong);
                        cmdCT.Parameters.AddWithValue("@DonGia", item.DonGia);
                        cmdCT.ExecuteNonQuery();
                    }

                    trans.Commit();

                    if (!string.IsNullOrEmpty(customerEmail))
                    {
                        EmailAdapter.SendOrderConfirmation(customerEmail, maDH, grandTotal, receiverName);
                    }

                    resultMsg = $"Đặt hàng thành công! Mã đơn hàng: {maDH}";
                    return true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    resultMsg = "Lỗi ghi nhận CSDL: " + ex.Message;
                    return false;
                }
            }
        }
    }
}