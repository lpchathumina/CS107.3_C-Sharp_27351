using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            DistanceConverter converter = new DistanceConverter();

            Console.Write("Enter the distance in kilometers: ");
            double kmValue = Convert.ToDouble(Console.ReadLine());

            converter.ConvertKmToMiles(kmValue);
        }
    }
}

class DistanceConverter
{
    public void ConvertKmToMiles(double km)
    {
        double miles = km * 0.621371;
        Console.WriteLine($"{km} kilometers is equal to {miles} miles.");
        Console.ReadLine();
    }
}

