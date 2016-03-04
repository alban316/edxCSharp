// ######################## COURSE CLASS #############
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ModuleSevenAssignment
{
    class Course
    {
        private string _name;
        private int _credits;
        private double _weeks;
        private string _teacher;
        //private ArrayList _students = new ArrayList();
        private List<Student> _students = new List<Student>(3);
        private int _teacherCourseCount = 0;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Credits
        {
            get { return _credits; }
            set { _credits = value; }
        }

        public double Weeks
        {
            get { return _weeks; }
            set { _weeks = value; }
        }

        public string Teacher
        {
            get { return _teacher; }
            set { _teacher = value; }
        }

        public int TeacherCourseCount
        {
            get { return _teacherCourseCount; }
        }

        public int StudentCourseCount
        {
            get { return _students.Count; }
        }

        public void AddStudentToCourse(Student _studentCourse)
        {
            _students.Add(_studentCourse);
        }

        public void ListStudents()
        {
            foreach (object std in _students)
            {
                Student student = (Student)std;
                Console.WriteLine("{0},{1}", student.StudentLastName, student.StudentFirstName);
            }

        }
    }
}

// ######################## STUDENT CLASS #############
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ModuleSevenAssignment
{
    class Student
    {
        private string _studentFirstName = "";
        private string _studentLastName = "";
        private DateTime _studentBirthDate;
        private string _studentAddressLine1 = "";
        private string _studentAddressLine2 = "";
        private string _studentCity = "";
        private string _studentState = "";
        private string _studentCountry = "";
        private int _studentZipCode;
        //private Stack _grades = new Stack();
        private Stack<double> _grades = new Stack<double>(5);

        public string StudentFirstName
        {
            get { return _studentFirstName; }
            set { _studentFirstName = value; }
        }

        public string StudentLastName
        {
            get { return _studentLastName; }
            set { _studentLastName = value; }
        }

        public DateTime StudentBirthDate
        {
            get { return _studentBirthDate; }
            set { _studentBirthDate = value; }
        }

        public string StudentAddressLine1
        {
            get { return _studentAddressLine1; }
            set { _studentAddressLine1 = value; }
        }

        public string StudentAddressLine2
        {
            get { return _studentAddressLine2; }
            set { _studentAddressLine2 = value; }
        }

        public string StudentCity
        {
            get { return _studentCity; }
            set { _studentCity = value; }
        }

        public string StudentState
        {
            get { return _studentState; }
            set { _studentState = value; }
        }

        public string StudentCountry
        {
            get { return _studentCountry; }
            set { _studentCountry = value; }
        }

        public int StudentZipCode
        {
            get { return _studentZipCode; }
            set { _studentZipCode = value; }
        }

        public void AddGrades(double _score1, double _score2, double _score3, double _score4, double _score5)
        {
            this._grades.Push(_score1);
            this._grades.Push(_score2);
            this._grades.Push(_score3);
            this._grades.Push(_score4);
            this._grades.Push(_score5);
        }

    }
}

// ######################## PROGRAM CLASS #############
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.StudentFirstName = "John";
            student1.StudentLastName = "Lennon";
            student1.StudentBirthDate = DateTime.Parse("19/02/1945");
            student1.StudentCity = "Liverpool";
            student1.StudentCountry = "United Kingdom";
            student1.AddGrades(10, 9.8, 8.7, 9, 8);


            Student student2 = new Student();
            student2.StudentFirstName = "Paul";
            student2.StudentLastName = "Mcartney";
            student2.StudentBirthDate = DateTime.Parse("10/06/1951");
            student2.StudentCity = "Liverpool";
            student2.StudentCountry = "United Kingdom";
            student2.AddGrades(8, 10, 9.9, 10, 9.5);

            Student student3 = new Student();
            student3.StudentFirstName = "George";
            student3.StudentLastName = "Harrison";
            student3.StudentBirthDate = DateTime.Parse("22/09/1956");
            student3.StudentCity = "Manchester";
            student3.StudentCountry = "United Kingdom";
            student3.AddGrades(9, 10, 10, 10, 8.5);

            Course programmingWithC = new Course();
            programmingWithC.Name = "Programming with C #";
            programmingWithC.AddStudentToCourse(student1);
            programmingWithC.AddStudentToCourse(student2);
            programmingWithC.AddStudentToCourse(student3);

            Console.WriteLine("The {0} course contains {1} student(s)", programmingWithC.Name, programmingWithC.StudentCourseCount.ToString());
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Students in {0} course:", programmingWithC.Name);
            programmingWithC.ListStudents();
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}