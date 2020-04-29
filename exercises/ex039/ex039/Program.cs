using System;

namespace ex039
{
    //protected and sealed keywords
    class Person
    {
        protected string Name { get; set; } //This variable is accessed in this class and it can be accessed in the derived classes.
    }
    class Student : Person
    {
        public Student(string name)
        {
            Name = name;
        }
        public void GetName()
        {
            Console.WriteLine(this.Name);
        }
    }
    sealed class Box //This class prevented other classes from inheriting it.
    {
        private double width;
        private double height;
    }
    // " class Cube : Box " will generate an error.
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("John");
            s1.GetName();
            //" s1.Name " will generate an error.
        }
    }
}
