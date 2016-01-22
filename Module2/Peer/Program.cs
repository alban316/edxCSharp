// C# code for chessboard
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.Design;

namespace ChessBoard
{
    class Program
    {
        // Print out a 8x8 chessboard pattern using X and O
        static void Main(string[] args)
        {
            char[] square = { 'X', 'O' };

            // loop through rows
            for (int i = 0; i < 8; i++)
            {
                // loop through columns
                for (int j = 0; j < 8; j++)
                {
                    // print X or O 
                    Console.Write(square[(i + j) % 2]);
                }
                // go to next row
                Console.WriteLine();
            }
            // press Enter to continue
            Console.ReadLine();
        }
    }
}