using System;

namespace Rejestracja2
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " +LastName;
            }
        }
        public string Pesel { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string HomeNum { get; set; }
        public string PostCode { get; set; }

        public string Address
        {
            get
            {
                return PostCode + " " + City + " " + Street + " " + HomeNum;
            }
        }

        public Patient(string firstName, string lastName, string pesel, string phoneNumber, string city, string postCode, string street, string homeNum)
        {
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
            PhoneNumber = phoneNumber;
            City = city;
            PostCode = postCode;
            Street = street;
            HomeNum = homeNum;

        }
    }
}