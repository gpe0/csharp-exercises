using System;

namespace ex009
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 40;
            do // similar to WHILE Loop, DO-WHILE Loop is guaranteed to execute at least one time.
            {
                Console.WriteLine(x++);
            } while (x <= 10);
            Console.WriteLine("-------------------");
            int y = 1;
            do
            {
                Console.WriteLine(y++);
            } while (y <= 10);
        }
    }
}
