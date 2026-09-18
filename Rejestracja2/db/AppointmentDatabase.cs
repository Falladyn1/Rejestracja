using System;
using System.Collections.Generic;
using System.IO;

namespace Rejestracja2
{
    // klasa statyczna dlatego zeby nie tworzyć obiektów tej klasy jest to poto aby mieć łatwy dostęp do metod tej klasy
    public static class AppointmentDatabase
    {
        private static readonly string filePath = "appointments.txt";

        //metoda do wyciągania wizyt z pliku txt 
        public static List<Appointment> LoadAppointments()
        {
            List<Appointment> appointments = new List<Appointment>();

            if (!File.Exists(filePath)) File.Create(filePath).Close();

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(';');

            // dodajemy tylko objekty które mają tylko 4 elementy żeby nie dodawały się niechciane elementy
                if (data.Length == 4)
                {
                    appointments.Add(new Appointment(data[0], data[1], data[2], data[3]));
                }
            }
            return appointments;
        }

        // metoda do zapisywania 
        public static void SaveAppointments(List<Appointment> appointments)
        {
            List<string> lines = new List<string>();
            foreach (Appointment a in appointments)
            {
                lines.Add($"{a.PatientPesel};{a.Doctor};{a.AppDate};{a.AppTime}");
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}