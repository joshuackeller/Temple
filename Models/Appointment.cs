using System;
using System.ComponentModel.DataAnnotations;

namespace Temple.Models
{
    
    public class Appointment
    {

        [Key]
        [Required]
        public int AppointmentId { get; set; }

        public bool Available { get; set; }

        public DateTime Date { get; set; }

       public string GroupName { get; set; }

        public int GroupSize { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }


    }
}
