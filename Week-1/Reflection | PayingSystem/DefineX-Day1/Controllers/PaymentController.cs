using System.Linq;
using DefineX_Day1.Data;
using DefineX_Day1.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DefineX_Day1.Controllers
{
    public class PaymentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentController()
        {
            _context = new ApplicationDbContext();
        }

        public IActionResult Index()
        {
            var paymentTypes = _context.PaymentMethods.Select(p => p.Name).ToList();

            paymentTypes.ForEach(paymentName => PaymentClassGenerator.GeneratePaymentClass(paymentName));

            ViewBag.PaymentTypes = paymentTypes;
            return View();
        }

        public IActionResult ProcessPayment(string paymentType, decimal price)
        {
            var paymentInstance = PaymentClassGenerator.CreateInstance(paymentType);
            TempData["Result"] = $"{paymentInstance.Pay(price)} {paymentType} ile ödendi.";

            return RedirectToAction("Index");
        }
    }
}
