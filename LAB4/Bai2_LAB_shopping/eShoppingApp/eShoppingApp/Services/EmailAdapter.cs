using System;

namespace eShoppingApp.Services
{
    public class EmailAdapter
    {
        public static bool SendOrderConfirmation(string toEmail, string maDH, decimal totalAmount, string receiverName)
        {
            try
            {

                Console.WriteLine($"[EMAIL SENT]: Đơn hàng {maDH} gửi tới {toEmail}");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}