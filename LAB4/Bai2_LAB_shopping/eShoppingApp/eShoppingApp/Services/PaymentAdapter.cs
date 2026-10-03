using System;

namespace eShoppingApp.Services
{
    public class PaymentAdapter
    {
        public bool VerifyAndPay(string cardType, string cardNumber, string expiryDate, string cardHolder, string csv, decimal amount, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (cardType == "VISA" || cardType == "Master" || cardType == "Discover")
            {
                if (cardNumber.Length != 16)
                {
                    errorMessage = $"Thẻ {cardType} yêu cầu số thẻ phải đúng 16 chữ số!";
                    return false;
                }
                if (csv.Length != 3)
                {
                    errorMessage = $"Thẻ {cardType} yêu cầu mã CSV phải đúng 3 chữ số!";
                    return false;
                }
            }
            else if (cardType == "Amex")
            {
                if (cardNumber.Length != 15)
                {
                    errorMessage = "Thẻ Amex yêu cầu số thẻ phải đúng 15 chữ số!";
                    return false;
                }
                if (csv.Length != 4)
                {
                    errorMessage = "Thẻ Amex yêu cầu mã CSV phải đúng 4 chữ số!";
                    return false;
                }
            }
            else
            {
                errorMessage = "Loại thẻ tín dụng không hợp lệ!";
                return false;
            }

            return true;
        }
    }
}