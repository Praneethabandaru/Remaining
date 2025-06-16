using CarRentalApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRentalApp.Controllers
{
    public class CarAppController : Controller
    {
        CarRentaldbContext ob = new CarRentaldbContext();
        public IActionResult Home()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Customer c)
        {
            var res = (from t in ob.Customers
                       where t.Username == c.Username && t.Pwd == c.Pwd
                       select t).FirstOrDefault();
            if (res != null)
            {
                HttpContext.Session.SetString("uid", res.CustomerId.ToString());
                return RedirectToAction("ViewCars");
            }
            else
            {
                ViewData["err"] = "Invalid Username or Password";
                ModelState.Clear();
                return View();
            }
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Customer c)
        {
            if (ModelState.IsValid)
            {
                ob.Customers.Add(c);
                ob.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
        public IActionResult ViewCars()
        {
            var vehicles = ob.Vehicles.ToList(); // Fetch all vehicles from the database
            return View(vehicles);
        }

        // GET: CarApp/Rent/{id}
        [HttpGet]
        public IActionResult Rent(int id)
        {
            var vehicle = ob.Vehicles.FirstOrDefault(v => v.VehicleId == id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        // POST: CarApp/AddRentalToBase
        [HttpPost]
        public IActionResult AddRentalToBase(int vehicleId, DateOnly startDate, DateOnly? endDate)
        {
            var userIdString = HttpContext.Session.GetString("uid");
            if (string.IsNullOrEmpty(userIdString) || !int.TryParse(userIdString, out int userId))
            {
                return RedirectToAction("Login");
            }
            return RedirectToAction("confirm");
        }
       
        public IActionResult confirm()
        {
            var userIdString = HttpContext.Session.GetString("uid");
            if (string.IsNullOrEmpty(userIdString) || !int.TryParse(userIdString, out int userId))
            {
                return RedirectToAction("Login");
            }

            var rental = ob.Rentals
                .Where(r => r.CustomerId == userId)
                .OrderByDescending(r => r.RentalId)
                .FirstOrDefault();

            if (rental == null || rental.VehicleId == null)
            {
                return RedirectToAction("ViewCars");
            }

            var vehicle = ob.Vehicles.FirstOrDefault(v => v.VehicleId == rental.VehicleId);
            if (vehicle == null || vehicle.Rentperday == null)
            {
                return RedirectToAction("ViewCars");
            }

            int days = rental.EndDate.HasValue
                ? (rental.EndDate.Value.DayNumber - rental.StartDate.DayNumber) + 1
                : 1;

            int pricePerDay = vehicle.Rentperday.Value;
            int totalPrice = days * pricePerDay;

            ViewBag.TotalPrice = totalPrice;
            ViewBag.Days = days;
            ViewBag.PricePerDay = pricePerDay;
            ViewBag.Rental = rental;
            ViewBag.Vehicle = vehicle;

            return View();
        }
        [HttpPost]
        public IActionResult ProcessPayment(int rentalId, decimal amount, string paymentMethod)
        {
            var rental = ob.Rentals.FirstOrDefault(r => r.RentalId == rentalId);
            if (rental == null)
            {
                return RedirectToAction("ViewCars");
            }

            var payment = new Payment
            {
                RentalId = rentalId,
                Amount = amount,
                PaymentDate = DateOnly.FromDateTime(DateTime.Now),
                PaymentMethod = paymentMethod
            };

            ob.Payments.Add(payment);
            ob.SaveChanges();

            ViewBag.Message = "Payment successful!";
            return View("ProcessPayment");
        }
    }
}
