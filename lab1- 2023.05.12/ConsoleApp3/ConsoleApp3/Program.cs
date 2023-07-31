using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Summation Application!");
            Console.WriteLine("Please enter two numbers to find their summation.");

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input for the first number. Please enter a valid number.");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input for the second number. Please enter a valid number.");
                return;
            }

            double sum = num1 + num2;
            Console.WriteLine($"The summation of {num1} and {num2} is: {sum}");
        }
    }
}
