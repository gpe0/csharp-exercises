using System;

namespace ex006
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Pick a number between 1 and 10: ");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n) // switch is a different type of condicional statements
            {
                case 1:
                    Console.WriteLine("One");
                    break; //break is fundamental here, or this will be stuck in a loop!!
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                default: //Default case, if "n" doesn't match any of the those above.
                    Console.WriteLine("Not between 1 and 10!");
                    break;
            }
        }
    }
}
