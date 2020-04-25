using System;

namespace ex026
{
    class Person
    {
        private string name;
        private int age;
        public string Name //This is a property
        {
            get { return name; }
            set { name = value; }
        }
        //You can use logic in your properties
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Invalid Age!");
                }
            }
        }
    }
    class Dog
    {
        //Auto-implemented properties
        public int Age { get; set; } //With the auto-implemented property you don't need to crate a private variable called "age", that is created automatically.
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Name = "John";
            Console.WriteLine(p1.Name);
            p1.Age = -2;
            p1.Age = 20;
            Console.WriteLine(p1.Age);
            Dog d1 = new Dog();
            d1.Age = 3;
            Console.WriteLine(d1.Age);
        }
    }
}
