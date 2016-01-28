using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Teacher
    {
        private string firstName;
        private string lastName;

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

        public Teacher()
        {
            Console.Write("Enter the teacher's First name: ");
            FirstName = Console.ReadLine();

            Console.Write("Enter the teacher's Last name: ");
            LastName = Console.ReadLine();
        }
    }
}
