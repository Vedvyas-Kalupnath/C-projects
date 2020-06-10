using System;

namespace NumbersRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("*******Lets play*******");

            Boolean loopControl = true;
            Random randGen = new Random();

            while(loopControl)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\nEnter Upper Boundary for the numbers: ");

                Console.ForegroundColor = ConsoleColor.Yellow;
                string input = Console.ReadLine();
                int upperBound = int.Parse(input);


                double compNum = randGen.Next(0, upperBound);
                
                double guessCount = 0.0;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nEnter your guess: ");

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                input = Console.ReadLine();

                double userGuess = double.Parse(input);
                guessCount++;


                while (userGuess != compNum)
                {
                    if (userGuess < compNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Too Low...One more try?");

                        Console.ForegroundColor = ConsoleColor.White;

                        loopControl = true;
                            input = Console.ReadLine();
                            userGuess = double.Parse(input);
                            guessCount++;
                        
                    }

                    else if(userGuess > compNum)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Too High. One more try?");

                        Console.ForegroundColor = ConsoleColor.Gray;

                        input = Console.ReadLine();
                        userGuess = double.Parse(input);
                        guessCount++;

                    }

                }


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nNice try . You got it in " + guessCount + " guesses");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\nPlay Again? (y/n): ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string reLoop = Console.ReadLine();

                if (reLoop.Equals("y"))
                {
                    loopControl = true;
                }
                else
                {
                    loopControl = false;

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Thanks for playing");


                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Press enter to exit");
                }


            }
        }
    }
}
