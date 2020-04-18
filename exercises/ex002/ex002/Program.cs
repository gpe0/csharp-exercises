using System;

namespace ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName; //Creates a variable of string type
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine(); //Reads user's input
            Console.WriteLine("Hello, {0}!", yourName); // Formatted string, 0 means the first element
        }
    }
}
