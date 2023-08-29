using System;
using System.Text;

namespace Library
{
    public class ValidateAppointment
    {
        public bool Validate (AppointmentService appointmentService)
        {
             if (string.IsNullOrEmpty(appointmentService.Id))
            {
                return false;
            }
            if (appointmentService.Date == default)
            {
                return false;
            }
            if (string.IsNullOrEmpty(appointmentService.Lugar))
            {
                return false;
            }
            if (appointmentService.Paciente == null || appointmentService.Paciente.Edad <= 0 ||
                string.IsNullOrEmpty(appointmentService.Paciente.Nombre) ||
                string.IsNullOrEmpty(appointmentService.Paciente.Id) ||
                string.IsNullOrEmpty(appointmentService.Paciente.Telefono))
                {
                    return false;
                }
            if (appointmentService.Doctor == null || 
            string.IsNullOrEmpty(appointmentService.Doctor.Nombre) ||
            string.IsNullOrEmpty(appointmentService.Doctor.Especialidad))
            {
                return false;
            }
            return true;

        }
         private bool ValidatePaciente(Paciente paciente)
        {
            return !string.IsNullOrEmpty(paciente.Nombre) &&
                   !string.IsNullOrEmpty(paciente.Id) &&
                   !string.IsNullOrEmpty(paciente.Telefono) &&
                   paciente.Edad > 0;
        }

        private bool ValidateDoctor(Doctor doctor)
        {
            return !string.IsNullOrEmpty(doctor.Nombre) &&
                   !string.IsNullOrEmpty(doctor.Especialidad);
        }
    }
}