using System;

namespace ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int n1;
            int n2;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.Write("Hello {0}, type a number: ", name);
            n1 = Convert.ToInt32(Console.ReadLine()); //Converting the string value to Integer
            Console.Write("Now type another number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
            Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
            Console.WriteLine("{0} x {1} = {2}", n1, n2, n1 * n2);
            Console.WriteLine("{0} / {1} = {2}", n1, n2, n1 / n2); // The result will be a integer!!
            Console.WriteLine("The reminder of {0} / {1} is {2}", n1, n2, n1 % n2);
            n1++; //increment by 1
            n2--; //decrement by 1
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
