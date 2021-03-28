using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Welcome to the C# calculator");

                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.WriteLine("Enter Your First Number");
                double firstNum = inputConverter.convertToNumeric(Console.ReadLine());

                Console.WriteLine("Enter You Second Number");
                double secondNum = inputConverter.convertToNumeric(Console.ReadLine());

                Console.WriteLine("Enter The Operation:\nAdd/+\nSubtract/-\nMultiply/*\nDivide//");
                string operation = Console.ReadLine();

                double result = calculatorEngine.calculate(operation, firstNum, secondNum);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
