using System;

namespace ex040
{
    //Constructors in base and derived classes
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal is created");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog is created");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog(); //As you an see, both constructors are called
            // Note that the base class constructor is called first and the derived class constructor is called next.
        }
    }
}
