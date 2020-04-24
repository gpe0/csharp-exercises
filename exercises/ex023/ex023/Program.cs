using System;
using System.Reflection.PortableExecutable;

namespace ex023
{
    //Classes and Objects
    class Person
    {
        public int age; // public is an access modifier that let you access the member from outside the class
        public string name;
        public void SayHi()
        {
            Console.WriteLine("Hi!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.age = 20;
            p1.name = "John";
            Console.WriteLine("name : {0}, age : {1}", p1.name, p1.age);
            p1.SayHi();
        }
    }
}
