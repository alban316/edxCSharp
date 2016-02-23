using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Program
    {

        static void Main(string[] args)
        {


            /*
            Teacher[] teacher = new Teacher[]
            {
                new Teacher("William", "Hanna", "7/14/1910", "3400 Cahuenga Blvd. West", "", "Hollywood", "CA", "90028", "USA"),
                new Teacher("Joseph", "Barbera", "3/24/1911", "3400 Cahuenga Blvd. West", "", "Hollywood", "CA", "90028", "USA")
            };



            Course course = new Course("Programming with C#", student, teacher); 
            Degree degree = new Degree("Bachelor", course); 
            UProgram program = new UProgram("Information Technology", degree); 

            Console.WriteLine("The {0} program contains the {1} degree\n", program.ProgramTitle, program.Degree.DegreeTitle); 
            Console.WriteLine("The {0} degree contains the course {1}\n", degree.DegreeTitle, degree.Course.CourseTitle); 
            Console.WriteLine("The {0} course contains {1} student(s)", degree.Course.CourseTitle, Student.StudentCount);

            Console.WriteLine("\nInstructors such as {0} may perform the following...", degree.Course.Teacher[0].FullName);
            Teacher.GradeTest();

            Console.WriteLine("\nStudents such as {0} may perform the following...", degree.Course.Student[0].FullName);
            Student.TakeTest();
            */


            Student student1 = new Student("Fred", "Flintstone", "9/30/1960", "301 Cobblestone Way", "", "Bedrock", "LA", "70777", "USA");
            Student student2 = new Student("Barney", "Rubble", "9/30/1960", "301 Cobblestone Way", "", "Bedrock", "LA", "70777", "USA");
            Student student3 = new Student("Wilma", "Flintstone", "9/30/1960", "301 Cobblestone Way", "", "Bedrock", "LA", "70777", "USA");

            student1.Grades.Push(75);
            student1.Grades.Push(80);
            student1.Grades.Push(99);
            student1.Grades.Push(100);
            student1.Grades.Push(98);

            student2.Grades.Push(77);
            student2.Grades.Push(78);
            student2.Grades.Push(79);
            student2.Grades.Push(80);
            student2.Grades.Push(81);

            student3.Grades.Push(90);
            student3.Grades.Push(85);
            student3.Grades.Push(80);
            student3.Grades.Push(75);
            student3.Grades.Push(70);

            Course course = new Course("Programming with C#");
            course.Student.Add(student1);
            course.Student.Add(student2);
            course.Student.Add(student3);

            course.ListStudents();

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();

        }
    }
}
