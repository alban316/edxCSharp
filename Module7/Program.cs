using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7
{
    class Person
    {
        private DateTime _birthDate;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string ZipPostal { get; set; }
        public string Country { get; set; }
        public DateTime BirthDate { get; }

        public Person(
            string firstName,
            string lastName,
            string birthDate,
            string addressLine1,
            string addressLine2,
            string city,
            string stateProvince,
            string zipPostal,
            string country
            )
        {
            FirstName = firstName;
            LastName = lastName;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            City = city;
            StateProvince = stateProvince;
            ZipPostal = zipPostal;
            Country = country;

            SetBirthDate(birthDate);
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public void SetBirthDate(string birthDate)
        {
            if (DateTime.TryParse(birthDate, out _birthDate)) { };
        }
    }

    class Student : Person
    {
        private static int _studentCount;
        private Stack<decimal> _grades = new Stack<decimal>();      /* Grading criteria 2 of 5 - See also public accessor, Grades */

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


    class Course
    {
        private ArrayList _student = new ArrayList();               /* Grading criteria 1 of 5 - ArrayList inside Course object */

        public string CourseTitle { get; set; }

        public Course(string courseTitle)
        {
            this.CourseTitle = courseTitle;
        }

        public ArrayList Student
        {
            get { return _student; }
        }

        public void ListStudents()
        {                                                           /* Grading criteria 4 of 5 - foreach loop */
            foreach (Student student in _student)                   /* Grading criteria 5 of 5 - implicit cast to Student inside loop */
            {                                   
                Console.WriteLine("Student name: {0}", student.FullName);
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
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
            course.Student.Add(student1);                           /* Grading criteria 3 of 5 - Add 3 students using ArrayList method */
            course.Student.Add(student2);
            course.Student.Add(student3);

            course.ListStudents();

            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
