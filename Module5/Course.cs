using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Course
    {
        private string courseTitle;
        private Student[] _student = new Student[3];
        private Teacher[] _teacher = new Teacher[3];

        public Course(string courseTitle, Student[] student, Teacher[] teacher)
        {
            this.CourseTitle = courseTitle;
            
            if(student.Length <= 3)
            {
                Array.Copy(student, this._student, student.Length);
            }

            else
            {
                throw new Exception("Course can have a max of 3 students.");
            }

            if(teacher.Length <=3)
            {
                Array.Copy(teacher, this._teacher, teacher.Length);
            }

            else
            {
                throw new Exception("Course can have a max of 3 teachers and/or aides.");
            }
        }

        public string CourseTitle
        {
            get
            {
                return courseTitle;
            }

            set
            {
                courseTitle = value;
            }
        }

        public Student[] Student
        {
            get
            {
                return _student;
            }

            set
            {
                _student = value;
            }
        }

        private Teacher[] Teacher
        {
            get
            {
                return _teacher;
            }

            set
            {
                _teacher = value;
            }
        }
    }
}
