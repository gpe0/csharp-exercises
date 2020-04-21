using System;

namespace ex014
{
    class Program
    {
        static void Main(string[] args)
        {
            //      Basic Calculator
            int n1 = 0, n2 = 0, choice = 3;
            while (true)
            {
                if (choice == 3)
                {
                    Console.Write("Type a number: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Type another number: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                }
                else if (choice == 1)
                {
                    Console.WriteLine("{0} + {1} = {2}", n1, n2, n1 + n2);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("{0} - {1} = {2}", n1, n2, n1 - n2);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Leaving...");
                    break;
                }
                else
                {
                    Console.WriteLine("Command not found!");
                }
                Console.Write("\n-------------------------------------------\n\n" +
                    "Calculator v1.0 \n" +
                    "[1] - Addition\n" +
                    "[2] - Subtraction\n" +
                    "[3] - Change numbers\n" +
                    "[4] - Exit\n");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }
        }
    }
}
