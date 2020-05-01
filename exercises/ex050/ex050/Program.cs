using System;

namespace ex050
{
    class Program
    {
        //Generic methods
        static void Swap<Type>(ref Type a, ref Type b) //Type is a generic type, it means you can use every type!
        {
            Type t = b;
            b = a;
            a = t;
        }
        static void Main(string[] args)
        {
            int x = 2;
            int y = 5;
            Swap<int>(ref x, ref y);
            Console.WriteLine("x: {0}, y: {1}", x, y);
            string w1 = "Hello";
            string w2 = "World";
            Swap<string>(ref w1, ref w2);
            Console.WriteLine("w1: {0}, w2: {1}", w1, w2);

        }
    }
}
