using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            int size = 10;
            ArrayOperations arrayOps = new ArrayOperations();

            int[] array = arrayOps.InputValues(size);

            int min = arrayOps.FindMinimum(array);
            Console.WriteLine($"Minimum value: {min}");

            int max = arrayOps.FindMaximum(array);
            Console.WriteLine($"Maximum value: {max}");

            double average = arrayOps.FindAverage(array);
            Console.WriteLine($"Average value: {average}");

            int[] reversedArray = arrayOps.ReverseArray(array);
            Console.WriteLine("Reversed array:");
            foreach (int num in reversedArray)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        } 
    }
}
public class ArrayOperations
{
    public int[] InputValues(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    public int FindMinimum(int[] array)
    {
        int min = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    public int FindMaximum(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }

    public double FindAverage(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        return (double)sum / array.Length;
    }

    public int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i];
        }
        return reversedArray;
    }
}
