using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Student : Person
    {
        private static int _studentCount;
        private Stack<decimal> _grades = new Stack<decimal>();

        public Student(
            string firstName, 
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
            _studentCount++;
        }

        public static void TakeTest()
        {
            Console.WriteLine("Take a test.");
        }

        public static int StudentCount
        {
            get { return _studentCount; }
        }

        public Stack<decimal> Grades
        {
            get { return _grades; }
        }
    }
}
