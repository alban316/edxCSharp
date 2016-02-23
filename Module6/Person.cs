using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Person
    {
        private DateTime _birthDate;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostal { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; }

        public Person(
            string firstName, 
            string lastName, 
            string birthDate, 
            string addressLine1,
            string addressLine2, 
            string city, 
            string stateProvince, 
            string zipPostal, 
            string country
            )
        {
            FirstName = firstName;
            LastName = lastName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            StateProvince = stateProvince;
            ZipPostal = zipPostal;
            Country = country;

            SetBirthDate(birthDate);
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public void SetBirthDate(string birthDate)
        {
            if (DateTime.TryParse(birthDate, out _birthDate)) { };
        }
    }
}
