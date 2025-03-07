
using DefineX_Day1.Helpers;

namespace Helpers.PaymentMethods
{
    public class Bitcoin : IPayment
    {
        public string Pay(decimal price)
        {
            return $"Ödeme işlemi başarılı: {price}";
        }
    }
}