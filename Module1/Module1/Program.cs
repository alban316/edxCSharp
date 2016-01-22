using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            //per HW instructions, this will be converted to a class in a later module

            string firstName;
            string lastName;
            string birthDate; //considered DateTime but it's not a primitive type
            string addressLine1;
            string addressLine2;
            string city;
            string stateProvince;
            string zipPostal; //zip, phone, and SSN are examples of numeric strings, not numbers
            string country;

            firstName = "Walt";
            lastName = "Disney";
            birthDate = "December 5, 1901";
            addressLine1 = "1313 S Disneyland Dr";
            addressLine2 = "";
            city = "Anaheim";
            stateProvince = "CA";
            zipPostal = "92802";
            country = "United States";

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthDate);
            Console.WriteLine(addressLine1);
            Console.WriteLine(addressLine2);
            Console.WriteLine(city);
            Console.WriteLine(stateProvince);
            Console.WriteLine(zipPostal);
            Console.WriteLine(country);
        }
    }
}
