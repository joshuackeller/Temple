using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Temple.Models.ViewModels
{
    public class AppointmentsViewModel
    {
        public IQueryable<Appointment>Appointments { get; set; }
    }
}
