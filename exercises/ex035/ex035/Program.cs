using System;
using System.Runtime.CompilerServices;

namespace ex035
{
    //This and readonly
    class Dog
    {
        private string name;
        public Dog(string name)
        {
            this.name = name; //this refers to the current instance of the class
        }
        public void GetName()
        {
            Console.WriteLine(this.name);
        }
    }
    class Money
    {
        readonly string name; //readonly can be modified only when you declare it or from within a constructor.
        public Money(string name)
        {
            this.name = name;
        }
        public void GetName()
        {
            Console.WriteLine(this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog("Max");
            d1.GetName();
            Money m1 = new Money("John");
            m1.GetName();
        }
    }
}
