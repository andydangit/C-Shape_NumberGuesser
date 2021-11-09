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
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName );

            // Init correct number
            int correctNumber = 7;

            // Init guess var
            int guess = 0;

            //Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            //while guess is not correct
            while (guess != correctNumber)
            {
                // Get users input
                string input = Console.ReadLine();

                // Make sure its a number
                if(!int.TryParse(input, out guess))
                {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    // Tell user its not a number
                    Console.WriteLine("Input Number only!!");

                    // Reset text color
                    Console.ResetColor();

                    // Keep going 
                    continue;
                }


                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber)
                {
                    //Change text color
                    Console.ForegroundColor = ConsoleColor.DarkYellow;

                    // Tell user it is the wrong number
                    Console.WriteLine("Wrong number, please try again");

                    // Reset text color
                    Console.ResetColor();
                }

            }

            // Output sucess message

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkGray;

            // Tell user it is the correct number
            Console.WriteLine("Good job on guessing the number");

            // Reset text color
            Console.ResetColor();

        }
    }
}
