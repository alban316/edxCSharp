using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Teacher : Person
    {
        public Teacher(string firstName,
            string lastName,
            string birthDate,
            string addressLine1,
            string addressLine2,
            string city,
            string stateProvince,
            string zipPostal,
            string country
            ) : base(

            firstName,
            lastName,
            birthDate,
            addressLine1,
            addressLine2,
            city,
            stateProvince,
            zipPostal,
            country
            )
        {
        }

        public static void GradeTest()
        {
            Console.WriteLine("Grade a test.");
        }
    }
}
