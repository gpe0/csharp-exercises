using System;
using System.Xml.Serialization;

namespace ex043
{
    //Interfaces | An interface is a completely abstract class, which contains only abstract members.
    interface IAnimal // A class can inherit from just one base class, but it can implement multiple interfaces, that's why it is cool.
    {
        void Sound();
    }
    class Dog : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Woof");
        }
    }
    class Cat : IAnimal
    {
        public void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Cat c1 = new Cat();
            d1.Sound();
            c1.Sound();
        }
    }
}
