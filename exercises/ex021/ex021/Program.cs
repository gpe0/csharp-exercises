using System;

namespace ex021
{
    class Program
    {
        // Recursion | A recursive method is a method that calls itself.
        static int Factorial(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            return x * Factorial(x - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5)); // Outputs 120, 5! = 5 x 4 x 3 x 2 x 1 = 120
        }
    }
}
