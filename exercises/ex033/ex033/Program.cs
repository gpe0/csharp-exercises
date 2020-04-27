using System;

namespace ex033
{
    //Static keyword | the properties and methods belong to the class itself, not to the objects
    class Dog
    {
        static public int dogs = 0;
        public Dog()
        {
            dogs++;
        }
        public static void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            Dog d2 = new Dog();
            Dog.Bark(); // As you can see, we are calling the class, not the object
            Console.WriteLine(Dog.dogs);
        }
    }
}
