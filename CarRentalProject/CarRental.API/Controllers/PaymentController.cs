using Microsoft.AspNetCore.Mvc;
using CarRental.API.Data;
using CarRental.API.Models;

namespace CarRental.API.Controllers
{
    [ApiController]
    [Route("api/payments")]
    public class PaymentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PaymentController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult ProcessPayment(Payment payment)
        {
            _context.Payments.Add(payment);
            _context.SaveChanges();
            return Ok("Payment processed successfully");
        }
    }
}
