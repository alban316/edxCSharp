using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Course
    {
        private ArrayList _student = new ArrayList();

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
        {
            foreach (Student student in _student)
            {
                Console.WriteLine("Student name: {0}", student.FullName);
            }
        }

    }
}
