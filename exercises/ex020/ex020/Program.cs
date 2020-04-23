using System;

namespace ex020
{
    class Program
    {
        // Method overloading | same method name, diferent parameters' types
        static void Print(int x)
        {
            Console.WriteLine("You wrote {0}, a integer number.", x);
        }
        static void Print(double x)
        {
            Console.WriteLine("You wrote {0}, a double number.", x);
        }
        static void Print(string x)
        {
            Console.WriteLine("You wrote '{0}', that is a string.", x);
        }
        static void Main(string[] args)
        {
            Print(1);
            Print(1.23);
            Print("Hello");
        }
    }
}
