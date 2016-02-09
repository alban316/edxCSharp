using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerCheck
{
    public class Student
    {
        private string FirstName;

        public string FirstName1
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        private string LastName;

        public string LastName1
        {
            get { return LastName; }
            set { LastName = value; }
        }
        private DateTime Birthdate;

        public DateTime Birthdate1
        {
            get { return Birthdate; }
            set { Birthdate = value; }
        }
        private string AddressLine1;

        public string AddressLine11
        {
            get { return AddressLine1; }
            set { AddressLine1 = value; }
        }
        private string AddressLine2;

        public string AddressLine21
        {
            get { return AddressLine2; }
            set { AddressLine2 = value; }
        }
        private string City;

        public string City1
        {
            get { return City; }
            set { City = value; }
        }
        private string StateOrProvince;

        public string StateOrProvince1
        {
            get { return StateOrProvince; }
            set { StateOrProvince = value; }
        }
        private int ZipOrPostal;

        public int ZipOrPostal1
        {
            get { return ZipOrPostal; }
            set { ZipOrPostal = value; }
        }
        private string Country;

        public string Country1
        {
            get { return Country; }
            set { Country = value; }
        }
        private static int studentsNum = 0;

        public static int StudentsNum
        {
            get { return Student.studentsNum; }
            set { Student.studentsNum = value; }
        }

        public Student()
        {
            Student.StudentsNum++;
        }
    }
}
