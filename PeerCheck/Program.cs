using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edxCSharp
{
    public struct Student
    {
        public string firstName;
        public string lastName;
        public string birthDate;
        public string[,] myClass;
        public int count;

        public Student(string fName, string lName, string bDate)
        {
            count = 0;
            this.firstName = fName;
            this.lastName = lName;
            this.birthDate = bDate;
            myClass = new string[,] { { this.firstName, this.lastName, this.birthDate } };
        }


    }

    public struct Teacher
    {
        public string firstName;
        public string lastName;
        public string birthDate;

        public Teacher(string fName, string lName, string bDate)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.birthDate = bDate;
        }
    }

    public struct Program
    {
        public string programName;
        public string deptHead;
        public int degrees;

        public Program(string pName, string dHead, int Dgrees)
        {
            this.programName = pName;
            this.deptHead = dHead;
            this.degrees = Dgrees;
        }
    }

    public struct Course
    {
        public string courseName;
        public string credits;
        public string durationInWeeks;
        public string nameOfTeacher;

        public Course(string cName, string kredit, string dInWeeks, string nOfTeacher)
        {
            this.courseName = cName;
            this.credits = kredit;
            this.durationInWeeks = dInWeeks;
            this.nameOfTeacher = nOfTeacher;
        }
    }

    public class Mod4Assign
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("John", "Michel", "10/03/1985");
            Student student2 = new Student("Obi", "John", "10/03/1978");
            Student student3 = new Student("Michel", "Obi", "10/25/1989");
            Console.WriteLine("\t\tSTUDENT DETAILS");
            Console.WriteLine("S/N\tFirstName\tLastName\tBirthdate");
            Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}", i + 1, student1.firstName, student1.lastName, student1.birthdate);
            Console.WriteLine("{0}\t{1}\t\t{2}\t\t{3}", i + 2, student2.firstName, student2.lastName, student2.birthdate);
            Console.Write("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}