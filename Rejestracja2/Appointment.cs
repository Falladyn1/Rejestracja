using System;

namespace Rejestracja2
{
    public class Appointment
    {
        public string PatientPesel { get; set; }
        public string Doctor { get; set; }
        public string AppDate { get; set; }
        public string AppTime { get; set; }

        public Appointment(string patientPesel, string doctor, string appDate, string appTime)
        {
            PatientPesel = patientPesel;
            Doctor = doctor;
            AppDate = appDate;
            AppTime = appTime;
        }
    }
}