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
            Console.WriteLine("Welcome to the Salary Calculator!");

            Console.Write("Enter employee's salary: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal salary))
            {
                Console.WriteLine("Invalid input. Please enter valid salary.");
                return;
            }

            Console.Write("Enter tax rate (): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal taxRate))
            {
                Console.WriteLine("Invalid input. Please enter valid tax rate.");
                return;
            }

            decimal taxAmount = (salary * taxRate) / 100;
            decimal salaryAfterTax = salary - taxAmount;

            Console.WriteLine($"Salary after tax deduction: {salaryAfterTax:C}");
        }
    }
}
