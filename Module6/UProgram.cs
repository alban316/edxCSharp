using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class UProgram
    {
        private string programTitle;
        private Degree degree;

        public string ProgramTitle
        {
            get
            {
                return programTitle;
            }

            set
            {
                programTitle = value;
            }
        }

        public Degree Degree
        {
            get
            {
                return degree;
            }

            set
            {
                degree = value;
            }
        }

        public UProgram(string programTitle, Degree degree)
        {
            ProgramTitle = programTitle;
            Degree = degree;
        }
    }
}
