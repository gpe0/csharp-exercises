using System;

namespace ex016
{
    class Program
    {
        static void Print(string text) //"text" is a parameter
        {
            Console.WriteLine(text);
        }
        static void Person(string name, int age) // 2 parameters
        {
            Console.WriteLine("Person saved! \nName: {0} \nAge: {1}", name, age);
        }
        static void Main(string[] args)
        {
            Print("Hey!");
            Person("Gonçalo", 18);
        }
    }
}
