using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter the operation number: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please choose a valid operation.");
                return;
            }

            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            CalculateValues calculator = new CalculateValues();

            int result;
            switch (choice)
            {
                case 1:
                    result = calculator.Addition(num1, num2);
                    break;
                case 2:
                    result = calculator.Subtraction(num1, num2);
                    break;
                case 3:
                    result = calculator.Multiplication(num1, num2);
                    break;
                case 4:
                    result = calculator.Division(num1, num2);
                    break;
                default:
                    result = 0;
                    break;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
public class CalculateValues
{
    public int Addition(int num1, int num2)
    {
        return num1 + num2;
    }

    public int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }

    public int Division(int num1, int num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return 0;
        }

        return num1 / num2;
    }
}
