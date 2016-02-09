using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerCheck
{
    public class Course
    {
        private string CourseName;

        public string CourseName1
        {
            get { return CourseName; }
            set { CourseName = value; }
        }
        private int Credits;

        public int Credits1
        {
            get { return Credits; }
            set { Credits = value; }
        }
        private int DurationInWeeks;

        public int DurationInWeeks1
        {
            get { return DurationInWeeks; }
            set { DurationInWeeks = value; }
        }
        private Student[] studentsArr = new Student[3];

        public Student[] StudentsArr
        {
            get { return studentsArr; }
            set { studentsArr = value; }
        }
        private Teacher[] teachersArr = new Teacher[3];

        public Teacher[] TeachersArr
        {
            get { return teachersArr; }
            set { teachersArr = value; }
        }
        private Degree _Degree;

        public Degree Degree
        {
            get { return _Degree; }
            set { _Degree = value; }
        }

    }
}
