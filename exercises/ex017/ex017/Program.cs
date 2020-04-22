using System;

namespace ex017
{
    class Program
    {
        static void Pow(int x, int m = 2 /* optional parameter, if nothing is written, "m" will be equal to 2 */)
        {
            int sum = 1;
            for (int i = 0; i < m; i++)
            {
                sum *= x;
            }
            Console.WriteLine(sum);
        }
        static void Main(string[] args)
        {
            Pow(5); // m = 2
            Pow(3, 3); // m = 3
        }
    }
}
