using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCPractice
{
    class Calculator : IDisposable
    {
        private bool disposed = false;

        public Calculator()
        {
            Console.WriteLine("Calculator being created");
        }

        public int Divide(int numerator, int denominator)
        {
            return numerator / denominator;
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator being finalized");
            this.Dispose();
        }

        public void Dispose()
        {
            if (!this.disposed)
            {
                Console.WriteLine("Calculator being disposed");
            }

            this.disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
