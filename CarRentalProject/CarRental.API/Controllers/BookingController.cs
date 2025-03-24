using Microsoft.AspNetCore.Mvc;
using System.Linq;
using CarRental.API.Data;
using CarRental.API.Models;

namespace CarRental.API.Controllers
{
    [ApiController]
    [Route("api/bookings")]
    public class BookingController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BookingController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult BookCar(Booking booking)
        {
            var car = _context.Cars.Find(booking.CarId);
            if (car == null || !car.Availability)
                return BadRequest("Car not available");

            _context.Bookings.Add(booking);
            car.Availability = false;
            _context.SaveChanges();
            return Ok("Car booked successfully");
        }
    }
}
