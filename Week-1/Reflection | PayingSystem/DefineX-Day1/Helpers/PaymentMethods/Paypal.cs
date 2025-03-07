
using DefineX_Day1.Helpers;

namespace Helpers.PaymentMethods
{
    public class Paypal : IPayment
    {
        public string Pay(decimal price)
        {
            return $"Ödeme işlemi başarılı: {price}";
        }
    }
}