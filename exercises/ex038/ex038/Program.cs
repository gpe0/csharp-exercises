using System;

namespace ex038
{
    //Inheritance
    class Animal //This is a base class
    {
        public int Legs { get; set; }
        public void Info()
        {
            Console.WriteLine("Animal class");
        }
    }
    class Dog : Animal //This is a derived class
    {
        public Dog()
        {
            Legs = 4;
        }
        public void Bark()
        {
            Console.WriteLine("Woof!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal(); //This animal can't bark, because it is not from Dog class
            Dog d = new Dog(); //But this one can use "Info()" because it is an instance of a derived class of Animal class.
            a.Info();
            d.Bark();
            d.Info();

        }
    }
}
