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
            ConvertValues converter = new ConvertValues();
            converter.kilometerTOmeter();
        }
    }
}

namespace KilometerToMeterConverter
{
    class ConvertValues
    {
        public void kilometerTOmeter()
        {
            Console.Write("Enter the Kilometer value: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out double kilometers))
            {
                double meters = kilometers * 1000;
                Console.WriteLine($"{kilometers} Kilometers is equal to {meters} Meters.");
            }
            Console.ReadLine();
        }
    }
}
