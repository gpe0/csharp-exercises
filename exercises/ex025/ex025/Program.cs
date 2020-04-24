using System;

namespace ex025
{
    //Constructor is a special member method that is executed whenever a new object of that class is created.
    class Person
    {
        private string name;
        private int age;
        public Person(string nm, int a) //Here i'm saying that whenever a nre object is created, the user need to input the person's name and age.
        {
            name = nm;
            age = a;
        }
        public void GetName()
        {
            Console.WriteLine("Name: {0}", name);
        }
        public void GetAge()
        {
            Console.WriteLine("Age: {0}", age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John", 20);
            p1.GetName();
            p1.GetAge();
        }
    }
}
