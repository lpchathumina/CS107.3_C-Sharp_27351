using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            int vowelCount = CountVowels(input);

            Console.WriteLine($"Number of vowels in the given string: {vowelCount}");
        }

        static int CountVowels(string input)
        {
            int count = 0;

            foreach (char c in input)
            {
                if (IsVowel(c))
                {
                    count++;
                }
            }

            return count;
            Console.ReadLine();
        }

        static bool IsVowel(char c)
        {
            char lowerC = char.ToLower(c);
            return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
        }
    }
}
