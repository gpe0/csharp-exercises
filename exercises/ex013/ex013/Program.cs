using System;
using System.Security.Cryptography.X509Certificates;

namespace ex013
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string msg;
            Console.Write("Your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            msg = age >= 18 ? "Welcome!" : "Sorry!"; // Conditional operator, the "?:" operator.
            Console.WriteLine(msg); //If the statement is true, the output is "Welcome!"
                                    //If the statement is false, the output is "Sorry!"
        }
    }
}
