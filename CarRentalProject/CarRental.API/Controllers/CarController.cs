using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using CarRental.API.Data;
using CarRental.API.Models;

namespace CarRental.API.Controllers
{
    [ApiController]
    [Route("api/cars")]
    public class CarController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCars()
        {
            return Ok(_context.Cars.Where(c => c.Availability).ToList());
        }

        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
            return Ok("Car added successfully");
        }
    }
}
