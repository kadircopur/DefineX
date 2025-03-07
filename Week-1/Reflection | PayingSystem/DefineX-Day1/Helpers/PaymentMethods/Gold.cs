
using DefineX_Day1.Helpers;

namespace Helpers.PaymentMethods
{
    public class Gold : IPayment
    {
        public string Pay(decimal price)
        {
            return $"Ödeme işlemi başarılı: {price}";
        }
    }
}