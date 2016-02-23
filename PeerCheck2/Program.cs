using System;
using System.Collections;
namespace Module5
{
    class Student
    {
        private string fName;
        private string lName;
        private string bDate;
        private string address;
        private string city;
        private string state;
        private string country;
        private int zipCode;
        private Stack Grades = new Stack();
        public static int count;

        public string FName
        {
            get
            {
                return fName;
            }

            set
            {
                fName = value;
            }
        }

        public string LName
        {
            get
            {
                return lName;
            }

            set
            {
                lName = value;
            }
        }

        public Student()
        {
            count++;
        }
        public Student(string firstName, string lastName)
        {
            this.fName = firstName;
            this.lName = lastName;
        }
        public void getGrades()
        {
            Console.WriteLine("Enter student grades: ");
            for (int i = 0; i < 5; i++)
                Grades.Push(Int32.Parse(Console.ReadLine()));
        }

    }

    class Teacher
    {
        private string fName;
        private string lName;
        private string bDate;
        private string address;
        private string city;
        private string state;
        private string country;
        private int zipCode;

    }

    class UProgram
    {
        private string pName;
        private string head;
        private string degrees;
        private Degree degreeObject;

    }

    class Degree
    {
        private string dName;
        private int credits;
        private Course courseObject;

    }

    class Course
    {
        private string cName;
        private int credits;
        private int dWeeks;
        private string teacher;

        private Teacher teacherObject;
        public ArrayList studentsObject = new ArrayList();

        public void addStudentList(Student[] students)
        {
            for (int i = 0; i < students.Length; i++)
                studentsObject.Add(students[i]);
        }

        public void ListStudents()
        {

            foreach (Student student in studentsObject)
            {
                Console.WriteLine("First Name: {0} Last Name: {1}", student.FName, student.LName);
            }
        }

    }

    class HW
    {
        static void Main(string[] args)
        {

            Student[] students = new Student[3];
            students[0] = new Student("Shailesh", "Gupta");
            students[1] = new Student("Karan", "Sharma");
            students[2] = new Student("Vedant", "Sharma");
            students[1].getGrades();
            students[1].getGrades();
            students[1].getGrades();

            Course course = new Course();
            course.addStudentList(students);

            course.ListStudents();

        }
    }
}