using System;

namespace ex022
{
    class Program
    {
        // Challenge: Create a method that creates a pyramid by getting an input of the row's number.
        static void MakePyramid(int n)
        {
            Console.WriteLine("Generating a pyramid with {0} rows\n", n);
            int sum;
            int before;
            for(int i = 1; i <= n; i++)
            {
                sum = 2 * i - 1;
                for (int c = 1; c <= (2*n - 1); c++)
                {
                    before = (2 * n - 1 - sum) / 2;
                    if (c <= before)
                    {
                        Console.Write(" ");
                    }
                    else if (sum > 0)
                    {
                        sum--;
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            MakePyramid(7);
        }
    }
}
