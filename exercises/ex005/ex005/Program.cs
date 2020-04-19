using System;

namespace ex005
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            Console.Write("Write a number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write another number: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2) // if n1 is equal to n2
            {
                Console.WriteLine("{0} is equal to {1}", n1, n2);
            } 
            else if (n1 > n2) // else, if n1 is greater than n2
            {
                Console.WriteLine("{0} is greater than {1}", n1, n2);
            }
            else // else, n1 is less than n2
            {
                Console.WriteLine("{0} is less than {1}", n1, n2);
            }
            Console.WriteLine("Finishing program!");
        }
    }
}
