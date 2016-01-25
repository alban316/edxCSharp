using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call GET methods.
            GetStudentInfo();
            GetTeacherInfo();
            GetDegreeInfo();
            GetProgramInfo();
            GetCourseInfo();
        }

        static void GetStudentInfo()
        {
            // Get data.
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday (dd/mm/aaaa): ");
            DateTime birthday = ValidateBirthday(Console.ReadLine());

            // Print data.
            PrintStudentDetails(firstName, lastName, birthday);
        }

        static void PrintStudentDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("The student {0} {1} was born on: {2}.\n", first, last, birthday);
        }

        static void GetTeacherInfo()
        {
            // Get data.
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday: ");
            DateTime birthday = ValidateBirthday(Console.ReadLine());

            // Print data.
            PrintTeacherDetails(firstName, lastName, birthday);
        }

        static void PrintTeacherDetails(string first, string last, DateTime birthday)
        {
            Console.WriteLine("The teacher {0} {1} was born on: {2}.\n", first, last, birthday);
        }

        static void GetDegreeInfo()
        {
            // Get data.
            Console.WriteLine("Enter the name of the degree: ");
            string degreeName = Console.ReadLine();
            Console.WriteLine("Enter the school: ");
            string school = Console.ReadLine();
            Console.WriteLine("Enter the total number of credits: ");
            int totalCredits = Convert.ToInt32(Console.ReadLine());

            // Print data.
            PrintDegreeDetails(degreeName, school, totalCredits);
        }

        static void PrintDegreeDetails(string name, string school, int credits)
        {
            Console.WriteLine("The {0} is imparted at {1}. Credits: {2}.\n", name, school, credits);
        }

        static void GetProgramInfo()
        {
            // Get data.
            Console.WriteLine("Enter the name of the program: ");
            string programName = Console.ReadLine();
            Console.WriteLine("Enter the degrees offered in the program: ");
            string degreesOffered = Console.ReadLine();
            Console.WriteLine("Enter the name of the department head: ");
            string departmentHead = Console.ReadLine();

            // Print data.
            PrintProgramDetails(programName, degreesOffered, departmentHead);
        }

        static void PrintProgramDetails(string name, string dOffered, string departmentH)
        {
            Console.WriteLine("The {0} offer {1} degrees. Department head: {2}.\n", name, dOffered, departmentH);
        }

        static void GetCourseInfo()
        {
            // Get data.
            Console.WriteLine("Enter the name of the course: ");
            string courseName = Console.ReadLine();
            Console.WriteLine("Enter the field of study: ");
            string studyField = Console.ReadLine();
            Console.WriteLine("Enter the course credits: ");
            int courseCredits = Convert.ToInt32(Console.ReadLine());

            // Print data.
            PrintCourseDetails(courseName, studyField, courseCredits);
        }

        static void PrintCourseDetails(string name, string field, int credits)
        {
            Console.WriteLine("Course: {0}. Field of study: {1}. Credits: {2}.\n", name, field, credits);
        }

        static DateTime ValidateBirthday(String date)
        {
            try
            {
                DateTime birthday = DateTime.Parse(date);

                // Check if it is greater than 18 years old.
                if (birthday.AddYears(18).CompareTo(DateTime.Today) > 0)
                {
                    Console.WriteLine("The student's age is less than 18.");
                }

                return birthday;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format.");
                return DateTime.Today;
            }
        }
    }
}