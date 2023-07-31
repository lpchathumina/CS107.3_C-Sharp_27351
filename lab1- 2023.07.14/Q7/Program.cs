using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the sizes of arrays:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[size];
            int[] array2 = new int[size];
            Console.WriteLine("Enter values for Array 1:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter value {i + 1}");
                array1[1] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter values for Array 2:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter value (i+1)");
                array2[1] = Convert.ToInt32(Console.ReadLine());
            }
            int scalarSum = 0;
            for (int i = 0; i < size; i++)
            {
                scalarSum += array1[i] + array2[1];
            }
            // vector sum

            int[] vectorSum = new int[size];
            for (int i = 0; i < size; i++)
            {
                vectorSum[1] = array1[i] + array2[1];
            }
            //display the vector sum
            Console.WriteLine("Vetor Sum: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(vectorSum[i] + "");
            }
            Console.ReadLine();

            //scalar product
            int scalarProduct = 0;
            int[] vectorProduct = new int[size];
            for (int i = 0; i < size; i++)
            {
                scalarProduct += array1[i] * array2[i];
                vectorProduct[i] = array1[i] * array2[i];
            }
            Console.WriteLine("Scalar product:" + scalarProduct);
            Console.WriteLine("Vector product:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("vectorProduct[1]");
            }
        }
    }
}
