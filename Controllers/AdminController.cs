﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Temple.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Temple.Controllers
{
    public class AdminController : Controller
    {
        private AppointmentContext context { get; set; }

        public AdminController(AppointmentContext temp) => context = temp;

        public IActionResult Appointment()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ViewAppointments()
        {
            var blah = context.Appointment
                .Where(x => x.Available == false)
                .OrderBy(x => x.Date)
                .ToList();
           

            return View(blah);
        }
        //public async Task UpdateData()
        //{
        //    AppointmentData =  context.Appointment.ToListAsync();
        //}
    }
}
