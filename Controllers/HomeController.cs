using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Temple.Models;

namespace Temple.Controllers
{
    public class HomeController : Controller
    {
        private IAppointmentRepository repo { get; set; }

        public HomeController(IAppointmentRepository temp)
        {
            repo = temp;
        }

        //private readonly ILogger<HomeController> _logger;
        //private AppointmentContext blahContext { get; set; }

        //public HomeController(ILogger<HomeController> logger, AppointmentContext someName)
        //{
        //    _logger = logger;
        //    blahContext = someName;
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            var appointmentList = repo.Appointments
                .OrderBy(x => x.Date)
                .Where(x => x.Available == true)
                .ToList();

            return View(appointmentList);
        }

        //public IActionResult ReservationForm()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        [HttpGet]
        public IActionResult ReservationForm(int id)
        {
            var appointment = repo.Appointments.FirstOrDefault(x => x.AppointmentId == id);
            return View(appointment);
        }

        [HttpPost]
        public IActionResult ReservationForm(Appointment app)
        {
            if (ModelState.IsValid)
            {
                repo.SaveAppointment(app);
                return RedirectToAction("Success");
            }
            else
            {
                return View();
            }
           
        }

        public IActionResult Success()
        {
            return View();
        }

    }
}