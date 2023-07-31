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
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            double area = CalculateArea(radius);
            double circumference = CalculateCircumference(radius);

            Console.WriteLine($"Area: {area:F2}");
            Console.WriteLine($"Circumference: {circumference:F2}");

            Console.ReadLine();
        }

        static double CalculateArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
    }
}
