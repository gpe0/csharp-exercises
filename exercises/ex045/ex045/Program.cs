using System;

namespace ex045
{
    //Structs | They are like classes, but you should use them to represent a simple set of data.
    struct Person
    {
        public string name;
        public int age;
        public void SayHi()
        {
            Console.WriteLine("Hi!");
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //You don't need to use the "new" keyword but when you have a constructor you must do it.
            Person p1 = new Person("John", 20);
            Console.WriteLine(p1.age);
            p1.SayHi();

        }
    }
}
