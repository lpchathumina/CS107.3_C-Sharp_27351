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
            Console.WriteLine("Enter the radius of the circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            FindValues finder = new FindValues();
            double area = finder.FindArea(radius);
            double circumference = finder.FindCircumference(radius);

            Console.WriteLine($"Area of the circle: {area:F2}");
            Console.WriteLine($"Circumference of the circle: {circumference:F2}");
        }
    }
}
namespace CircleAreaAndCircumference
{
    public class FindValues
    {
        public double FindArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double FindCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
    }
}
