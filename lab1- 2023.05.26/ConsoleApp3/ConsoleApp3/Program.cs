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
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sumOfDigits = 0;

            for (int num = number; num != 0; num /= 10)
            {
                int digit = num % 10;
                sumOfDigits += digit;
            }

            Console.WriteLine($"The sum of the digits of {number} is: {sumOfDigits}");
            Console.ReadLine();
        }
    }
}
