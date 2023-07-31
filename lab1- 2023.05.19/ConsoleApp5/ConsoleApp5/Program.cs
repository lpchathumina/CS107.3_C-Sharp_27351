using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NumberOfInputs = 10;

            Console.WriteLine("Enter 10 numbers:");

            for (int i = 1; i <= NumberOfInputs; i++)
            {
                Console.Write($"Number {i}: ");
                string inputStr = Console.ReadLine();

                if (int.TryParse(inputStr, out int number))
                {
                    string evenOrOdd = IsEven(number) ? "even" : "odd";
                    Console.WriteLine($"The number {number} is {evenOrOdd}.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    i--; // Decrement the counter to allow the user to re-enter the number.
                }
            }Console.ReadLine();
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;

        }
    }
}
