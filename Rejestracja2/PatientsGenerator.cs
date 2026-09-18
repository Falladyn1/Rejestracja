using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Rejestracja2
{
    // klasa pomocnicza służąca do generowania sztucznych danych testowych
    public static class PatientsGenerator
    {
        public static void GenerateData(int n)
        {
            string[] imionaM = { "Jan", "Piotr", "Michał", "Tomasz", "Krzysztof", "Marcin", "Andrzej", "Paweł", "Marek", "Łukasz" };
            string[] imionaK = { "Anna", "Katarzyna", "Agnieszka", "Magdalena", "Maria", "Karolina", "Ewa", "Monika", "Joanna", "Marta" };
            string[] nazwiska = { "Kowalski", "Nowak", "Wiśniewski", "Wójcik", "Kowalczyk", "Kamiński", "Lewandowski", "Zieliński", "Szymański", "Dąbrowski" };
            string[] miasta = { "Bydgoszcz", "Toruń", "Włocławek", "Grudziądz", "Inowrocław", "Gdańsk", "Poznań" };
            string[] ulice = { "Długa", "Krótka", "Polna", "Leśna", "Słoneczna", "Szkolna", "Główna", "Kwiatowa", "Kościelna", "Lipowa" };
            string[] lekarze = { "dr Jan Kowalski", "dr Anna Nowak", "dr Piotr Wiśniewski" };

            Random rnd = new Random();

            List<string> patientsLines = new List<string>();
            List<string> appointmentsLines = new List<string>();

            DateTime appDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            int daysInMonth = DateTime.DaysInMonth(appDate.Year, appDate.Month);

            TimeSpan appTime = new TimeSpan(8, 0, 0);
            int doctorIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (appDate.Month != DateTime.Now.Month) break;

                bool isMale = rnd.Next(2) == 0;
                string FirstName = isMale ? imionaM[rnd.Next(imionaM.Length)] : imionaK[rnd.Next(imionaK.Length)];
                string LastName = nazwiska[rnd.Next(nazwiska.Length)];

                if (!isMale && LastName.EndsWith("i")) LastName = LastName.Substring(0, LastName.Length - 1) + "a";

                string pesel = $"{rnd.Next(50, 99)}{rnd.Next(1, 12).ToString("D2")}{rnd.Next(1, 28).ToString("D2")}{rnd.Next(10000, 99999)}";
                string phone = $"{rnd.Next(500, 800)}{rnd.Next(100, 999)}-{rnd.Next(100, 999)}";
                string cities = miasta[rnd.Next(miasta.Length)];
                string streets = ulice[rnd.Next(ulice.Length)];
                string home = rnd.Next(1, 150).ToString();
                string code = $"{rnd.Next(10, 99)}-{rnd.Next(100, 999)}";

                patientsLines.Add($"{FirstName};{LastName};{pesel};{phone};{cities};{code};{streets};{home}");

                string dateStr = appDate.ToString("dd.MM.yyyy");
                string timeStr = appTime.ToString(@"hh\:mm");
                string doctor = lekarze[doctorIndex];

                appointmentsLines.Add($"{pesel};{doctor};{dateStr};{timeStr}");

                appTime = appTime.Add(TimeSpan.FromMinutes(30));

                if (appTime.Hours >= 16)
                {
                    appTime = new TimeSpan(8, 0, 0);
                    doctorIndex++;

                    if (doctorIndex >= lekarze.Length)
                    {
                        doctorIndex = 0;
                        appDate = appDate.AddDays(1);

                        if (appDate.DayOfWeek == DayOfWeek.Saturday) appDate = appDate.AddDays(2);
                        if (appDate.DayOfWeek == DayOfWeek.Sunday) appDate = appDate.AddDays(1);
                    }
                }
            }

            File.WriteAllLines("patients.txt", patientsLines);
            File.WriteAllLines("appointments.txt", appointmentsLines);
        }
    }
}