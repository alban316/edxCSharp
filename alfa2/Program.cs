using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
TODO: Build a graphical windows app using D3D or SharpDX and, sigh, C++


    C:\Users\jbrugger\repo\edxCSharp\alfa2\bin\Debug>alfa2
Enter your guess: GGAA
You have 1 exact and 2 partial matches. Try again. <<<<<< 3rd A was exact. What where the partials??? Actual value had C,T, and no G!!
Enter your guess: GCAA
You have 1 exact and 3 partial matches. Try again.
Enter your guess: GAAC
You have 1 exact and 3 partial matches. Try again.
Enter your guess: hint
C---
Enter your guess: CGGA
You have 1 exact and 3 partial matches. Try again.
Enter your guess: hint
CT--
Enter your guess: CTGA
You have 2 exact and 2 partial matches. Try again.
Enter your guess: CTAG
You have 3 exact and 1 partial matches. Try again.
Enter your guess: CTAA
You have 3 exact and 1 partial matches. Try again.
Enter your guess: hint
CTA-
Enter your guess: CTAT
Congratulations! You Win!

    */


namespace alfa2
{
    class Program
    {

        class Game
        {
            
            class Phrase
            {
                public const int PhraseSize = 4;
                public class CCount
                {
                    public int G;
                    public int A;
                    public int T;
                    public int C;

                    public CCount(int g = 0, int a = 0, int t = 0, int c = 0)
                    {
                        G = g; A = a; T = t; C = c;
                    }
                }


                private string _value;
                private CCount _count;

                public string Value
                {
                    get
                    {
                        return _value;
                    }
                }

                public CCount Count
                {
                    get
                    {
                        return _count;
                    }
                }
                
                public char[] CharValue()
                {
                    return Value.ToCharArray(0, PhraseSize);
                }

                public Phrase(string phrase = null)
                {
                    if (string.IsNullOrEmpty(phrase))
                    {
                        _value = "";
                        Random random = new Random();

                        for (int i = 0; i < PhraseSize; i++)
                        {
                            switch (random.Next(0,4))
                            {
                                case 0:
                                    _value += "G";
                                    break;
                                case 1:
                                    _value += "A";
                                    break;
                                case 2:
                                    _value += "T";
                                    break;
                                case 3:
                                    _value += "C";
                                    break;
                            }
                        }

                    }

                    else
                    {
                        _value = phrase; //TODO also check the length!!!
                    }

                    _count = new CCount();
                    if (!SetCheckLetterCounts())
                    {
                        //TODO: invalid Phrase passed
                    }

                }

                private bool SetCheckLetterCounts()
                {

                    bool result = true;

                    foreach (char letter in this.CharValue())
                    {
                        switch (letter)
                        {
                            case 'G':
                                _count.G++;
                                break;
                            case 'A':
                                _count.A++;
                                break;
                            case 'T':
                                _count.T++;
                                break;
                            case 'C':
                                _count.C++;
                                break;
                            default:
                                result = false;
                                break;
                        }
               
                    }

                    return result;
                }


                public bool Compare(Phrase compare, out int exactMatch, out int partialMatch)
                {
                    bool result = false;

                    CCount matchCount = new CCount();

                    char[] outer = this.CharValue();
                    char[] inner = compare.CharValue();

                    // this outer
                    for (int i = 0; i < PhraseSize; i++)
                    {
                        // compare inner
                        for (int j = 0; j < PhraseSize; j++)
                        {
                            //exact match
                            if (outer[i] == inner[j] && i == j)
                            {
                                switch (outer[i])
                                {
                                    case 'G':
                                        matchCount.G++;
                                        break;
                                    case 'A':
                                        matchCount.A++;
                                        break;
                                    case 'T':
                                        matchCount.T++;
                                        break;
                                    case 'C':
                                        matchCount.C++;
                                        break;
                                }
                            }
                        }
                    }

                    exactMatch = matchCount.G + matchCount.A + matchCount.T + matchCount.C;

                    // (if actual > 0 ? ((if guess >= actual ? actual : guess) - matchcount) : 0) + ...
                    partialMatch = (this.Count.G > 0 ? (compare.Count.G >= this.Count.G ? this.Count.G : compare.Count.G) - matchCount.G : 0) +
                        (this.Count.A > 0 ? (compare.Count.A >= this.Count.A ? this.Count.A : compare.Count.A) - matchCount.A : 0) +
                        (this.Count.T > 0 ? (compare.Count.T >= this.Count.G ? this.Count.T : compare.Count.T) - matchCount.T : 0) +
                        (this.Count.C > 0 ? (compare.Count.C >= this.Count.C ? this.Count.C : compare.Count.C) - matchCount.C : 0);

                    if (exactMatch == PhraseSize)
                    {
                        result = true;
                    }

                    return result;
                }
            }

            public static void GameLoop()
            {
                int exactMatch = 0;
                int partialMatch = 0;
                int hint = 1;
                bool gameOver = false;
                string guessString;
                Phrase actual = new Phrase();

                while (!gameOver)
                {
                    Console.Write("Enter your guess: ");
                    guessString = Console.ReadLine();

                    if (guessString == "hint")
                    {
                        string padding = new string('-', Phrase.PhraseSize - hint);
                        Console.WriteLine("{0}{1}", actual.Value.Substring(0, hint), padding);

                        // begin -- for debugging only
                        Console.WriteLine("{0} G x {1}", actual.Value, actual.Count.G);
                        Console.WriteLine("{0} A x {1}", actual.Value, actual.Count.A);
                        Console.WriteLine("{0} T x {1}", actual.Value, actual.Count.T);
                        Console.WriteLine("{0} C x {1}", actual.Value, actual.Count.C);
                        // end -- for debugging only

                        if (hint < Phrase.PhraseSize)
                        {
                            hint++;
                        }

                        else
                        {
                            Console.WriteLine("No more hints! Game Over.");
                            gameOver = true;
                        }
                    }

                    else
                    {
                        Phrase guess = new Phrase(guessString);
                        if (!actual.Compare(guess, out exactMatch, out partialMatch))
                        {
                            Console.WriteLine("You have {0} exact and {1} partial matches. Try again.", exactMatch, partialMatch);
                        }

                        else
                        {
                            Console.WriteLine("Congratulations! You Win!");
                            gameOver = true;
                        }

                    }

                }
               
            }

        }


        static void Main(string[] args)
        {
            Game.GameLoop();
        }
    }
}
