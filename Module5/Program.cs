using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Teacher[] teacher = new Teacher[3];     
                Student[] student = new Student[3];

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Enter details for student #{0} of 3 . . .", i + 1);
                    student[i] = new Student(); //#1 of 10: instantiate 3 student objects
                }

                Console.WriteLine("Enter details for the course instructor . . . ");
                teacher[0] = new Teacher(); //#4 of 10: instantiate at least 1 teacher object

                Course course = new Course("Programming with C#", student, teacher); //#2, #3, #5 Instantiate course object, add students & teacher to course
                Degree degree = new Degree("Bachelor", course); //#6, #7 instantiate degree object, add course to degree
                UProgram program = new UProgram("Information Technology", degree); //#8, #9 instantiate UProgram object, add degree to program

                Console.WriteLine("The {0} program contains the {1} degree\n", program.ProgramTitle, program.Degree.DegreeTitle); //#10.1
                Console.WriteLine("The {0} degree contains the course {1}\n", degree.DegreeTitle, degree.Course.CourseTitle); //#10.2
                Console.WriteLine("The {0} course contains {1} student(s)", degree.Course.CourseTitle, Student.StudentCount); //#10.3
                Console.WriteLine("Press any key to continue . . . ");

                Console.ReadKey();
            }

            catch
            {
                throw;
            }

        }
    }
}
