using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {

        class Course
        {
            private string teacherName;
            private string courseTitle;
            private string programTitle;

            public void GetCourseInformation()
            {
                Console.Write("Enter course title: ");
                courseTitle = Console.ReadLine();

                Console.Write("Enter course instructor name: ");
                teacherName = Console.ReadLine();

                Console.Write("Enter program name, e.g. 'Computer Science': ");
                programTitle = Console.ReadLine();
            }

            public string TeacherName
            {
                get
                {
                    return teacherName;
                }

            }
            public string CourseTitle
            {
                get
                {
                    return courseTitle;
                }
            }

            public string ProgramTitle
            {
                get
                {
                    return programTitle;
                }
            }

        }

        class Student
        {
            private string firstName;
            private string lastName;
            private DateTime birthDate;
            private Course course;

            public void ValidateStudentBirthdate()
            {
                throw new NotImplementedException();
            }


            public void GetStudentInformation()
            {
                Console.Write("Enter the student's First name: ");
                firstName = Console.ReadLine();

                Console.Write("Enter the student's Last name: ");
                lastName = Console.ReadLine();

                Console.Write("Enter the student's Date of Birth: ");
                birthDate = Convert.ToDateTime(Console.ReadLine());

                course = new Course();
                course.GetCourseInformation();
            }

            public void PrintStudentDetails()
            {
                Console.WriteLine("{0} {1}, born {2}, is taking course {3}, instructed by {4} in the {5} program.", firstName, lastName, birthDate.ToShortDateString(), course.CourseTitle, course.TeacherName, course.ProgramTitle);
            }

        }


        static void Main(string[] args)
        {

            try
            {
                Student student = new Student();
                student.GetStudentInformation();

                student.PrintStudentDetails();

                student.ValidateStudentBirthdate(); // should throw exception since it is not implemented
            }

            catch(Exception e)
            {
                Console.WriteLine("Caught exception {0}", e);
            }

            finally
            {
                Console.WriteLine("Press Enter to exit...");
                Console.ReadLine();
            }
        }
    }
}
