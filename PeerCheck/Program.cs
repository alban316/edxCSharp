using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerCheck
{

    class Program
    {
        public void Main()
        {
            Student std1 = new Student();

            std1.FirstName1 = "Alex";
            std1.LastName1 = "Mann";
            std1.Birthdate1 = new DateTime(1990, 10, 10);
            std1.AddressLine11 = "122 1st Ave";
            std1.AddressLine21 = "";
            std1.City1 = "Champaign";
            std1.StateOrProvince1 = "Illinois";
            std1.ZipOrPostal1 = 12545;
            std1.Country1 = "US";

            Student std2 = new Student();

            std2.FirstName1 = "Alexis";
            std2.LastName1 = "Mann";
            std2.Birthdate1 = new DateTime(1991, 10, 10);
            std2.AddressLine11 = "122 1st Ave";
            std2.AddressLine21 = "";
            std2.City1 = "Champaign";
            std2.StateOrProvince1 = "Illinois";
            std2.ZipOrPostal1 = 12545;
            std2.Country1 = "US";

            Student std3 = new Student();

            std3.FirstName1 = "Alexa";
            std3.LastName1 = "Mann";
            std3.Birthdate1 = new DateTime(1992, 10, 10);
            std3.AddressLine11 = "122 1st Ave";
            std3.AddressLine21 = "";
            std3.City1 = "Champaign";
            std3.StateOrProvince1 = "Illinois";
            std3.ZipOrPostal1 = 12545;
            std3.Country1 = "US";

            Teacher tcr1 = new Teacher();

            tcr1.FirstName1 = "Alexandr";
            tcr1.LastName1 = "Mann";
            tcr1.Birthdate1 = new DateTime(1992, 10, 10);
            tcr1.AddressLine11 = "122 1st Ave";
            tcr1.AddressLine21 = "";
            tcr1.City1 = "Champaign";
            tcr1.StateOrProvince1 = "Illinois";
            tcr1.ZipOrPostal1 = 12545;
            tcr1.Country1 = "US";

            Course crs1 = new Course();
            crs1.CourseName1 = "Programming with C#";

            crs1.StudentsArr[0] = std1;
            crs1.StudentsArr[1] = std2;
            crs1.StudentsArr[2] = std3;

            crs1.TeachersArr[0] = tcr1;

            Degree dgr1 = new Degree();
            dgr1.DegreeName1 = "Bachelor";
            dgr1.Course = crs1;

            UProgram prg1 = new UProgram();
            prg1.ProgramName1 = "Information Technology";
            prg1.Degrees1 = dgr1;

            Console.WriteLine("The " + prg1.ProgramName1 + " program contains the " + prg1.Degrees1.DegreeName1 + " degree");
            Console.WriteLine("The " + prg1.Degrees1.DegreeName1 + " degree contains the course " + prg1.Degrees1.Course.CourseName1);
            Console.WriteLine("The " + prg1.Degrees1.Course.CourseName1 + " course contains " + prg1.Degrees1.Course.StudentsArr.Length + "student(s)");

        }
    }

    
}