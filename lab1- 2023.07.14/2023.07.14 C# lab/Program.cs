using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023._07._14_C__lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Display();

            Dog dog = new Dog();
            dog.DisplayDog();
            dog.DisplayDog();
        }
    }
}
