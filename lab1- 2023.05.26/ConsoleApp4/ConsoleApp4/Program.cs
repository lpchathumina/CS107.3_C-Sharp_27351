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
            Console.WriteLine("Enter a positive integer:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int n) && n > 0)
            {
                int sum = 0;
                for (int i = 1; i <= n; i += 2)
                {
                    sum += i;
                }

                Console.WriteLine($"The sum of all odd numbers from 1 to {n} is: {sum}");
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter a positive integer.");
            }
            Console.ReadLine();
        }
    }
}
