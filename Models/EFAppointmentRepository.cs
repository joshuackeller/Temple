using System;
using System.Linq;

namespace Temple.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        
        public AppointmentContext context { get; set; }

        public EFAppointmentRepository(AppointmentContext temp)
        {
            context = temp;
        }

        public IQueryable<Appointment> Appointments => context.Appointment;

        public void CreateAppointment(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();
        }

        public void DeleteAppointment(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }

        public void SaveAppointment(Appointment a)
        {
            context.SaveChanges();
        }

        public object Select(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}
