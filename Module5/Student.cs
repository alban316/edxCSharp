using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string addressLine1;
        private string addressLine2;
        private string city;
        private string stateProvince;
        private string zipPostal;
        private string country;
        private static int studentCount;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public string AddressLine1
        {
            get
            {
                return addressLine1;
            }

            set
            {
                addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return addressLine2;
            }

            set
            {
                addressLine2 = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public string StateProvince
        {
            get
            {
                return stateProvince;
            }

            set
            {
                stateProvince = value;
            }
        }

        public string ZipPostal
        {
            get
            {
                return zipPostal;
            }

            set
            {
                zipPostal = value;
            }
        }

        public string Country
        {
            get
            {
                return country;
            }

            set
            {
                country = value;
            }
        }

        public static int StudentCount
        {
            get
            {
                return studentCount;
            }
        }

        public Student()
        {
            Console.Write("Enter the student's First name: ");
            FirstName = Console.ReadLine();

            Console.Write("Enter the student's Last name: ");
            LastName = Console.ReadLine();

            bool tryAgain = true;
            while (tryAgain)
            {
                Console.Write("Enter the student's Date of Birth: ");
                string birthDateInput = Console.ReadLine();

                if (DateTime.TryParse(birthDateInput, out this.birthDate))
                {
                    tryAgain = false;
                }

                else
                {
                    Console.WriteLine("Invalid entry. Please enter a valid date.");
                }
            }

            Console.Write("Enter the student's Address Line 1: ");
            AddressLine1 = Console.ReadLine();

            Console.Write("Enter the student's Address Line 2: ");
            AddressLine2 = Console.ReadLine();

            Console.Write("Enter the student's City: ");
            City = Console.ReadLine();

            Console.Write("Enter the student's State (Province): ");
            StateProvince = Console.ReadLine();

            Console.Write("Enter the student's Zip (Postal) code: ");
            ZipPostal = Console.ReadLine();

            Console.Write("Enter the student's Country: ");
            Country = Console.ReadLine();

            studentCount++;
        }
    }
}
