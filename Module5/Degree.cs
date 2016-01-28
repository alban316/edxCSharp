using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Degree
    {
        private string degreeTitle;
        private Course course;

        public string DegreeTitle
        {
            get
            {
                return degreeTitle;
            }

            set
            {
                degreeTitle = value;
            }
        }

        internal Course Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }

        public Degree(string degreeTitle, Course course)
        {
            DegreeTitle = degreeTitle;
            Course = course;
        }
    }
}
