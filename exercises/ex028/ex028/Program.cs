using System;

namespace ex028
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iterate through the elements of an array.
            int[] a = new int[10];
            for (int x = 0; x < 10; x++)
            {
                a[x] = x + 1;
            } //setting 10 values in a int array. | from 1 to 10
            //now, you can use for or foreach to print the values.
            foreach (int n in a)
            {
                Console.Write("{0} ", n);
            }

        }
    }
}
