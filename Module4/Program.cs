using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Module4
    {
        public struct Student
        {
            public Student(string firstName, string lastName, string address, string city)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Address = address;
                this.City = city;
            }

            public string FirstName;
            public string LastName;
            public string Address;
            public string City;
        }

        public struct Teacher
        {
            public Teacher(string firstName, string lastName, string department)
            {
                this.FirstName = firstName;
                this.LastName = lastName;
                this.Department = department;
            }

            public string FirstName;
            public string LastName;
            public string Department;
        }

        public struct Program
        {
            public Program(string programName)
            {
                this.ProgramName = programName;
            }

            public string ProgramName;
        }

        public struct Course
        {
            public Course(string courseTitle, int numCredits)
            {
                this.CourseTitle = courseTitle;
                this.NumCredits = numCredits;
            }

            public string CourseTitle;
            public int NumCredits;
        }


        static void Main(string[] args)
        {
            Student[] student = new Student[5];
            student[0] = new Student("Pebbles", "Flintstone", "55 Cobblestone Rd", "Bedrock");

            Console.WriteLine("{0} {1}", student[0].FirstName, student[0].LastName);
            Console.WriteLine("{0}", student[0].Address);
            Console.WriteLine("{0}", student[0].City);
        }
    }
}
