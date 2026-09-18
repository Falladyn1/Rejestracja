using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rejestracja2
{
    // klasa statyczna dlatego zeby nie tworzyć obiektów tej klasy jest to poto aby mieć łatwy dostęp do metod tej klasy
    public static class UserDatabase
    {

        private static readonly string filePath = "users.txt";

        // metoda do odczytania użytkowników z bazy txt
        public static List<User> LoadUsers()
        {
            List<User> users = new List<User>();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] data = line.Split(';');

                // dodajemy tylko objekty które mają tylko 2 elementy żeby nie dodawały się niechciane elementy
                if (data.Length == 2)
                {
                    users.Add(new User(data[0], data[1]));
                }
                
            }

            return users;
        }

        // metoda do zapisu ( w sumie nie uzywana, ale był plan tworzenia nowych użytkowników)
        //public static void SaveUsers(List<User> users)
        //{
        //    List<string> lines = new List<string>();

        //    foreach (User user in users)
        //    {
        //        lines.Add($"{user.Username};{user.Password}");
        //    }

        //    File.WriteAllLines(filePath, lines);
        //}

    }
}
