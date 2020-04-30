using System;

namespace ex042
{
    //Abstract methods and classes
    abstract class Animal //Abstract classes can only have abstract methods. They can't be instantiated.
    {
        public abstract void Sound();
    }
    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Woof");
        }
    }
    class Cat : Animal
    {
        public override void Sound()
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
