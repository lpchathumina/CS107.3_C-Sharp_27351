﻿using System;
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
            double num1, num2;
            Console.WriteLine("Enter your first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Second number: ");
            num2 = double.Parse(Console.ReadLine());

            double sum;
            sum = num1 + num2;

            Console.WriteLine("sum is: " + sum);
            Console.ReadLine();
        }
    }
}
