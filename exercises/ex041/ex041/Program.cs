using System;

namespace ex041
{
    //Polymorphism | means that a single method can have a number of different implementations.
    class Animal
    {
        public virtual void Sound() //As you can see, i used "virtual keyword" | Virtual methods enable you to work with groups of related objects in a uniform way.
        {
            Console.WriteLine("Base sound");
        }
    }
    class Dog : Animal
    {
        public override void Sound() //Now, we can derive different Animal classes that define their own sound methods using the override keyword.
        {
            Console.WriteLine("Woof!");
        }
    }
    class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Meow!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Dog d1 = new Dog();
            Cat c1 = new Cat();
            a1.Sound();
            d1.Sound();
            c1.Sound();
        }
    }
}
