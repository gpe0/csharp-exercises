using System;

namespace ex019
{
    class Program
    {
        // There are 3 ways to pass parameters
        // - By value
        // - By reference
        // - As output
        static void Double(int x)
        {
            x *= 2;
            Console.WriteLine(x);
        }
        static void Double_v2(ref int x)
        {
            x *= 2;
            Console.WriteLine(x);
        }
        static void GetValue(out int x)
        {
            x = 6;
        }
        static void Main(string[] args)
        {
            int n1 = 5;
            int n2 = 3;
            int n3;
            Console.WriteLine("'n1' value before: {0}", n1);
            Double(n1);
            Console.WriteLine("'n1' value after: {0}", n1); // By value | As you can see, "n1" didn't change
            Console.WriteLine("\n'n2' value before: {0}", n2);
            Double_v2(ref n2);
            Console.WriteLine("'n2' value after: {0}", n2); // By reference | Now "n2" changed, from 3 to 6.
            Console.WriteLine("\n'n3' value before: not assigned");
            GetValue(out n3);
            Console.WriteLine("'n3' value after: {0}", n3); // As output | Now "n3" has a value, 6.
        }
    }
}
