using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (IsEven(number))
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
                Console.ReadLine();
            }
           
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
