using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class Program
    {
        static void Main(string[] args)
        {
            string chessSquare;
            for (int rows = 0; rows < 8; rows++)
            {
                for (int cols = 0; cols < 8; cols++)
                {
                    if ((rows % 2 == 0) ^ (cols % 2 == 0))
                    {
                        chessSquare = "O";
                    }

                    else
                    {
                        chessSquare = "X";
                    }

                    Console.Write(chessSquare);
                }
                Console.WriteLine();
            }

        }
    }
}
