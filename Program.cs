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
            string name = "Andy Dang";
            int age = 25;
            var mood = "happy";

            //Start Here //
            Console.WriteLine(name + " is " + age);
            Console.WriteLine("{0} is {1} and is {2}", name,age,mood);
        }
    }
}
