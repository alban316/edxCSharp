using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerCheck
{
    public class UProgram
    {
        private string ProgramName;

        public string ProgramName1
        {
            get { return ProgramName; }
            set { ProgramName = value; }
        }
        private string DepartmentHead;

        public string DepartmentHead1
        {
            get { return DepartmentHead; }
            set { DepartmentHead = value; }
        }
        private Degree Degrees;

        public Degree Degrees1
        {
            get { return Degrees; }
            set { Degrees = value; }
        }
    }
}
