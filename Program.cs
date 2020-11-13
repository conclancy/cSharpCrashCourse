using System;

namespace traversy_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {
                // Game set-up
                // int correctNumber = 7;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10");

                // Game play
                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    // Validate input is int
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.Red, "Please enter an integer.");
                        continue;
                    }

                    // Cast to int and assign to 'int guess'
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again:");
                    }
                }

                // Correct Guess
                PrintColorMessage(ConsoleColor.Cyan, "You're Correct!!!");

                // Ask player if they want to play again
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Display app information
        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Connor Clancy";

            // Write out App Info
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(appName);
            Console.WriteLine("Version: {0}", appVersion);
            Console.WriteLine("Author: {0}", appAuthor);

            Console.ResetColor();
        }

        // Greet user and get name
        static void GreetUser()
        {
            // Get player's name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0} let's play a game!", inputName);
        }

        // Print a colored message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
