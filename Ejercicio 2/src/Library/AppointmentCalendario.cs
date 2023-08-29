using System;
using System.Text;

namespace Library
{
    public class AppointmentCalendario
    {
        private readonly ValidateAppointment _validate;

        public AppointmentCalendario(ValidateAppointment validate)
        {
            _validate = validate;
        }

        public string Calendario(AppointmentService appointment)
        {
            if (_validate.Validate(appointment))
            {
                return "Cita programada";
            }
            else
            {
                return "No se pudo programar la cita, los datos son invalidos.";
            }
        }
    }
}