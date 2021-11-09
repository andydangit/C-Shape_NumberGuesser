using System;

//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
           //Entry Point Method
        static void Main(string[] args)
        {

            // Set app vars
            var appName = "Number Guesser";
            var appVersion = "1.0.0";
            var appAuthor = "Andy Dang";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor );

            // reset text color 
            Console.ResetColor();

            // Ask the user name
            Console.WriteLine("What is your name?");

            // get user input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", input );

            // Init correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");


        }
    }
}
