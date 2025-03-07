
using DefineX_Day1.Helpers;

namespace Helpers.PaymentMethods
{
    public class Cash : IPayment
    {
        public string Pay(decimal price)
        {
            return $"Ödeme işlemi başarılı: {price}";
        }
    }
}