using System;

namespace ex008
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (true) // WHILE Loop | It is an infinite loop | Only stops when a break "break" occurs  
            {
                Console.Write(" {0}", x);
                x++;
                if (x == 11) 
                {
                    Console.Write(" Finishing!");
                    break; // Stopping after looping for 10 times.
                }
            }
        }
    }
}
