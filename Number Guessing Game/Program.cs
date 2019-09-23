using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class Program
    {
        static int yourNumber = 0;
        static int numberGuess;
        static int numberGuessMin = 0;
        static int numberGuessMax = 101;
        static string choice = "";
        static int guess = 0;
        static string yn = "";
        static string range = "";
        static void Main(string[] args)
        {
            Random random = new Random();


            //intro
            Console.WriteLine("Hello There. I want you to pick a number (0-100) and I'm goint to guess what it is. Go ahead and choose a number");
            choice = Console.ReadLine();

            //Console.WriteLine("\n" + choice);

            //converts choice to a number so it can take the >=< stuff
            yourNumber = Convert.ToInt32(choice);





            while (yn != "yes" || yn != "Yes")
            {
                //number guesser
                numberGuess = random.Next(numberGuessMin, numberGuessMax);
                Console.WriteLine("\nGuesses: " + guess);
                Console.WriteLine("Your number is between " + numberGuessMin + " and " + numberGuessMax);
                Console.WriteLine("Is your number " + numberGuess + "? (yes/no)");
                yn = Console.ReadLine();
                guess++;


                if (yn == "no" || yn == "No")
                {
                    Console.WriteLine("Dang. Is your number higher or lower than " + numberGuess + "? (Higher/Lower)\n");
                    range = Console.ReadLine();

                    //higher
                    if (range == "higher" || range == "Higher")
                    {
                        if (numberGuess >= yourNumber)
                        {
                            Console.WriteLine("\nDon't lie to me");
                        }
                        else if (numberGuess < yourNumber)
                        {

                            numberGuessMin = numberGuess;

                            
                        }
                    }
                    //lower
                    if (range == "lower" || range == "Lower")
                    {
                        if (numberGuess <= yourNumber)
                        {
                            Console.WriteLine("\nDon't lie to me");
                        }
                        else
                        {

                            numberGuessMax = numberGuess;
                            
                        }
                    }

                   

                    }

                if (yn == "yes" || yn == "Yes")
                {
                    if (numberGuess != yourNumber)
                    {
                        Console.WriteLine("\nDont lie to me");
                    }
                    else if (numberGuess == yourNumber)
                    {
                        Console.WriteLine("I Won! I won in " + guess + " guesses!");
                    }                       



                }


                Console.ReadKey();

            }


        }
    }
}
