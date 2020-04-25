using System;

namespace ex027
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays | They are objects used to store multiple values
            int[] a1 = new int[5]; // i created a array that stores 5 integer values.
            a1[0] = 3; //the first index is 0, not 1.
            Console.WriteLine(a1[0]);
            // you can create arrays and setting values with curly brackets.
            // int[] a2 = new int[3] {3, 4, 2}
            // or
            // int[] a2 = new int[] {3, 4, 2}
            // or 
            int[] a2 = { 3, 4, 2 };
            Console.WriteLine(a2[2]); // All meaning the same.
        }
    }
}
