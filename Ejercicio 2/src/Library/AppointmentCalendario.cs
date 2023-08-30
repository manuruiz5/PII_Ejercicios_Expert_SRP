using System;
using System.Text;

namespace Library
{
    public class AppointmentCalendario
    {
        private readonly ValidateAppointment _validator;

        public AppointmentCalendario(ValidateAppointment validate)
        {
            _validator = validate;
        }

        public string Calendario(AppointmentService appointment)
        {
            if (_validator.Validate(appointment))
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