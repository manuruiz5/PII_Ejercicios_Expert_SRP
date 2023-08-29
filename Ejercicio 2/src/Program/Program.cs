using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1 = new Paciente{Nombre = "Steven Jhonson",Id = "986782342",Telefono 
            = "5555-555-555",Edad = 30};
             Doctor doctor1 = new Doctor{Nombre = "Armand",Especialidad = "Cardiología"};

            AppointmentService appointment1 = new AppointmentService{ Id = "123", Date = 
            DateTime.Now, Lugar = "Wall Street", Paciente = paciente1,Doctor = doctor1 };
            ValidateAppointment validator = new ValidateAppointment();

            AppointmentCalendario calendario = new AppointmentCalendario(validator);

            string appointmentResult1 = calendario.Calendario(appointment1);
            Console.WriteLine(appointmentResult1);
        }
    }
}
