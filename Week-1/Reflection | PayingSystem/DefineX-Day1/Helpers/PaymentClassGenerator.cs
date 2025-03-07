using System.IO;
using System.Reflection;

namespace DefineX_Day1.Helpers
{

    public static class PaymentClassGenerator
    {
        private static readonly string HelpersPath = Path.Combine(Directory.GetCurrentDirectory(), "Helpers/PaymentMethods");

        public static void GeneratePaymentClass(string paymentName)
        {

            string filePath = Path.Combine(HelpersPath, $"{paymentName}.cs");

            string code = $@"
using DefineX_Day1.Helpers;

namespace Helpers.PaymentMethods
{{
    public class {paymentName} : IPayment
    {{
        public string Pay(decimal price)
        {{
            return $""Ödeme işlemi başarılı: {{price}}"";
        }}
    }}
}}";

            File.WriteAllText(filePath, code);
        }

        public static IPayment CreateInstance(string className)
        {
            var newClass = Assembly.GetAssembly(typeof(IPayment)).CreateInstance($"Helpers.PaymentMethods.{className}");

            return (IPayment)newClass;
        }
    }
}
