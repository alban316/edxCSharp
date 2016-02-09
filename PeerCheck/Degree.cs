using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerCheck
{
    public class Degree
    {
        private string DegreeName;

        public string DegreeName1
        {
            get { return DegreeName; }
            set { DegreeName = value; }
        }
        private int CreditsRequiiered;

        public int CreditsRequiiered1
        {
            get { return CreditsRequiiered; }
            set { CreditsRequiiered = value; }
        }

        private Course _Course;

        internal Course Course
        {
            get { return _Course; }
            set { _Course = value; }
        }
    }
}
