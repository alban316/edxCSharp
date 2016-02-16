using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6
{
    class Program
    {

        abstract class Employee
        {
            public abstract void SomeMethod();

            public virtual void AnotherMethod()
            {
                // do some stuff
            }

            public void YetAnotherMethod()
            {
                // do other stuff
            }

        }

        sealed class Manager : Employee
        {
            public Manager()
            {

            }

            public override void SomeMethod()
            {
                throw new NotImplementedException();
            }


        }


        static void Main(string[] args)
        {


        }
    }
}
