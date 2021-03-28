using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcomeMessage = "Welcome to the C# calculator";

            string inputNumberOne = Console.ReadLine();
            int convertedInputNumberOne;
            int.TryParse(inputNumberOne, out convertedInputNumberOne);
            
        }
    }
}
