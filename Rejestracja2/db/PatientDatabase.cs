using System;
using System.Collections.Generic;
using System.IO;

namespace Rejestracja2
{
    // klasa statyczna dlatego zeby nie tworzyć obiektów tej klasy jest to poto aby mieć łatwy dostęp do metod tej klasy
    public static class PatientDatabase
    {
        private static readonly string filePath = "patients.txt";

        // metoda do odczytania pacjentów z pliku txt
        public static List<Patient> LoadPatients()
        {
            List<Patient> patients = new List<Patient>();
            if (!File.Exists(filePath)) File.Create(filePath).Close();

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(';');

                // dodajemy tylko objekty które mają tylko 8 elementów żeby nie dodawały się niechciane elementy
                if (data.Length == 8)
                {
                    patients.Add(new Patient(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]));
                }
            }
            return patients;
        }

        // metoda do zapisu
        public static void SavePatients(List<Patient> patients)
        {
            List<string> lines = new List<string>();
            foreach (Patient p in patients)
            {
                lines.Add($"{p.FirstName};{p.LastName};{p.Pesel};{p.PhoneNumber};{p.City};{p.PostCode};{p.Street};{p.HomeNum}");
            }
            File.WriteAllLines(filePath, lines);
        }
    }
}