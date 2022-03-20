using System;
using System.Linq;

namespace Temple.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get;  }

        object Select(Func<object, object> p);

        public void SaveAppointment(Appointment a);

        public void CreateAppointment(Appointment a);

        public void DeleteAppointment(Appointment a);

    }
}
