using System;

namespace ex015
{
    class Program
    {
        //Methods!! || Methods have many advantages, including:
        //- Reusable code.
        //- Easy to test.
        //- Modifications to a method do not affect the calling program.
        //- One method can accept many different inputs.
        static void SayHi()
        {
            Console.WriteLine("Hi!");
        }
        static int Sum(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            int result;
            SayHi();
            SayHi();
            SayHi();
            result = Sum(5, 6);
            Console.WriteLine(result);
            //Outputs 11
        }
    }
}
