using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    mastermind puzzle w/ GATC letters (e.g. the 4-nucleobases of DNA, e.g. "Gattaca")

    enter your guess GATC

    return assessment XO-

    Colors: Orange, Green, Pink, Purple (or actually any pallette I choose)

    Given:
    G = 00 (0)
    A = 01 (1)
    T = 10 (2)
    C = 11 (3)
*/



namespace Alfabits
{

    enum Dna { G, A, T, C };
    class Program
    {

        class Game
        {

            public static int PhraseValue(string phraseString)
            {
                char[] phraseChar = phraseString.ToCharArray(0, 4);
                int result = 0;
                for (int i = 0; i < 4; i++)
                {
                    result += DigitValue(phraseChar[i], i);
                }

                return result;
            }


            public static void PhraseDigitValue(string phraseString, out int digit1, out int digit2, out int digit3, out int digit4)
            {
                char[] phraseChar = phraseString.ToCharArray(0, 4);
                digit1 = DigitValue(phraseChar[0], 0);
                digit2 = DigitValue(phraseChar[1], 1);
                digit3 = DigitValue(phraseChar[2], 2);
                digit4 = DigitValue(phraseChar[3], 3);
            }


            public static int DigitValue(char digitChar, int digitPlace)
            {
                int theExponent = (3 - digitPlace) * 2;

                switch (digitChar)
                {
                    case 'G':
                        return (int)Dna.G * (int)Math.Pow(2, theExponent);

                    case 'A':
                        return (int)Dna.A * (int)Math.Pow(2, theExponent);

                    case 'T':
                        return (int)Dna.T * (int)Math.Pow(2, theExponent);

                    case 'C':
                        return (int)Dna.C * (int)Math.Pow(2, theExponent);

                    default:
                        return -1;
                }

            }


            public static void DigitCompare(string firstPhrase, string secondPhrase, out int exactMatch, out int partialMatch)
            {
                char[] phraseOuter = firstPhrase.ToCharArray(0, 4);
                char[] phraseInner = secondPhrase.ToCharArray(0, 4);
                exactMatch = 0;
                partialMatch = 0;

                for (int outerDigitPlace = 0; outerDigitPlace < 4; outerDigitPlace++)
                {
                    int outerDigitValue = DigitValue(phraseOuter[outerDigitPlace], outerDigitPlace);

                    for (int innerDigitPlace = 0; innerDigitPlace < 4; innerDigitPlace++)
                    {
                        int innerDigitValue = DigitValue(phraseInner[innerDigitPlace], innerDigitPlace);

                        Console.Write("{0} ({1}) vs {2} ({3})...", phraseOuter[outerDigitPlace], outerDigitValue, phraseInner[innerDigitPlace], innerDigitValue);

                        //exact match
                        if ((outerDigitValue == innerDigitValue) && (outerDigitPlace == innerDigitPlace))
                        {
                            exactMatch++;

                            Console.WriteLine("Exact match!");
                        }

                        //partial match
                        else if (outerDigitValue == innerDigitValue) 
                        {
                            partialMatch++;

                            Console.WriteLine("Partial match!");
                        }

                        else
                        {
                            Console.WriteLine("No match!");
                        }
                    }
                }
            }

        }



        static void Main(string[] args)
        {
            //generate an array of permutations, from 00|00|00|00 to 11|11|11|11, aka GGGG to CCCC
            //string[] letters = { "G", "A", "T", "C" };


            //convert a solution to an integer
            //int theSolution = (int)Dna.G * 64 + (int)Dna.A * 16 + (int)Dna.T * 4 + (int)Dna.C;
            //int theSolution = (int)Dna.G * 64 + (int)Dna.G * 16 + (int)Dna.A * 4 + (int)Dna.C;
            //Console.WriteLine(theSolution);

            //convert an integer to a solution string


            //convert a string solution to an integer
            //string playerInput = "GATC";
            //string playerInput = "GGTC";

            //Console.WriteLine(Game.PhraseValue(playerInput));

            //int exactMatch = 0;
            //int partialMatch = 0;

            //Game.DigitCompare("GATC", "CTAG", out exactMatch, out partialMatch);

            //Console.WriteLine("GATC vs CTAG contains {0} exact matches and {1} partial matches", exactMatch, partialMatch);

            string phrase = "GATC";
            int digit1, digit2, digit3, digit4;
            Game.PhraseDigitValue(phrase, out digit1, out digit2, out digit3, out digit4);

            Console.WriteLine("GATC = ");



            /*
            char[] playerGuess = playerInput.ToCharArray(0, 4);

            int theNumber = 0;
            for (int i = 0; i < 4; i++)
            {
                int theExponent = (3 - i) * 2;

                switch (playerGuess[i])
                {
                    case 'G':
                        theNumber += (int)Dna.G * (int)Math.Pow(2, theExponent);
                        break;

                    case 'A':
                        theNumber += (int)Dna.A * (int)Math.Pow(2, theExponent);
                        break;

                    case 'T':
                        theNumber += (int)Dna.T * (int)Math.Pow(2, theExponent);
                        break;

                    case 'C':
                        theNumber += (int)Dna.C * (int)Math.Pow(2, theExponent);
                        break;

                }
            }

            Console.WriteLine(theNumber);

            //compare two entries
            if # = # then win
            else
            check 


            check for exact matches
            check for match wrong place

            */


        }
    }
}
