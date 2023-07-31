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
            double centimeters = 150;
            ConversionUtility conversionUtility = new ConversionUtility();
            double meters = conversionUtility.CentimetersToMeters(centimeters);
            Console.WriteLine($"{centimeters} centimeters is equal to {meters} meters.");
            Console.ReadLine();
        }
    }
}
class ConversionUtility
{
    public double CentimetersToMeters(double centimeters)
    {
        double meters = centimeters / 100.0;
        return meters;
    }
}
