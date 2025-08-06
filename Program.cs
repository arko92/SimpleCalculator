using SimpleCalculator.Services;
using SimpleCalculator.Interfaces;
namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A simple calculator application");

            double number1 = 1;
            double number2 = 2;

            // Create an instance of the calculator service
            ICalculator calculator = new Calculator();

            // Perform calculations
            double additionResult = calculator.Add(number1, number2);
            double exponentResult = calculator.Power(number1, number2);

            // Display the result
            Console.WriteLine($"Addition of {number1} and {number2} is: {additionResult}");
            Console.WriteLine($"{number1}^{number2} = {exponentResult}");
        }
    }
}
