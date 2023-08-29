using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public string Id { get; set; }
        public DateTime Date { get; set; }
        public string Lugar { get; set; }
        public Doctor Doctor{ get; set; }
        public Paciente Paciente{ get; set; }
    }

}
