using System;
using Microsoft.EntityFrameworkCore;

namespace Temple.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext(DbContextOptions<AppointmentContext> options) : base(options)
        {

        }

        public DbSet<Appointment> Appointment { get; set; }

        //(year, month, day, hour, minute, second) Format for Datetime


        protected override void OnModelCreating(ModelBuilder appointment)
        {
            appointment.Entity<Appointment>().HasData(

                // Day 1
                new Appointment
                {
                    AppointmentId = 1,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 8, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 2,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 9, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 3,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 10, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 4,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 11, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 5,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 12, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 6,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 13, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 7,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 14, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 8,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 15, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 9,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 16, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 10,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 17, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 11,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 18, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 12,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 19, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 13,
                    Available = true,
                    Date = new DateTime(2022, 3, 22, 20, 0, 0),

                },

                // Day 2
                new Appointment
                {
                    AppointmentId = 14,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 8, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 15,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 9, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 16,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 10, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 17,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 11, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 18,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 12, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 19,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 13, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 20,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 14, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 21,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 15, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 22,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 16, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 23,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 17, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 24,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 18, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 25,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 19, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 26,
                    Available = true,
                    Date = new DateTime(2022, 3, 23, 20, 0, 0),

                },

                // Day 3
                new Appointment
                {
                    AppointmentId = 27,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 8, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 28,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 9, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 29,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 10, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 30,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 11, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 31,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 12, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 32,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 13, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 33,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 14, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 34,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 15, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 35,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 16, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 36,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 17, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 37,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 18, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 38,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 19, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 39,
                    Available = true,
                    Date = new DateTime(2022, 3, 24, 20, 0, 0),

                },

                // Day 4
                new Appointment
                {
                    AppointmentId = 40,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 8, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 41,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 9, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 42,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 10, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 43,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 11, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 44,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 12, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 45,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 13, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 46,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 14, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 47,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 15, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 48,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 16, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 49,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 17, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 50,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 18, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 51,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 19, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 52,
                    Available = true,
                    Date = new DateTime(2022, 3, 25, 20, 0, 0),

                },

                // Day 5
                new Appointment
                {
                    AppointmentId = 53,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 8, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 54,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 9, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 55,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 10, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 56,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 11, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 57,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 12, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 58,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 13, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 59,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 14, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 60,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 15, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 61,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 16, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 62,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 17, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 63,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 18, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 64,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 19, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 65,
                    Available = true,
                    Date = new DateTime(2022, 3, 26, 20, 0, 0),

                },

                // Day 6
                new Appointment
                {
                    AppointmentId = 66,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 8, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 67,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 9, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 68,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 10, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 69,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 11, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 70,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 12, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 71,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 13, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 72,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 14, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 73,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 15, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 74,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 16, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 75,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 17, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 76,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 18, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 77,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 19, 0, 0),

                },
                new Appointment
                {
                    AppointmentId = 78,
                    Available = true,
                    Date = new DateTime(2022, 3, 27, 20, 0, 0),

                }
                );
            
        }
    }
}
