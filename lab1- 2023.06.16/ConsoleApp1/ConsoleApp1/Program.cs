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
            MyClass myObject = new MyClass();
            myObject.SayHelloExternally(); // This will work fine and print "Hello, world!" to the console.

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
public class MyClass
{
    private void sayHello()
    {
        Console.WriteLine("Hello, world!");
    }

    public void SayHelloExternally()
    {
        sayHello(); // You can call the private sayHello() method within a public method of the same class.
    }
}
public class MyClasss
{
    private void sayHello()
    {
        Console.WriteLine("Hello, world!");
    }

    public void SayHelloExternally()
    {
        sayHello(); // You can call the private sayHello() method within a public method of the same class.
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
public class MyClasses
{
    private void sayHello()
    {
        Console.WriteLine("Hello, world!");
    }
}




