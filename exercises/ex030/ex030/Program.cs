using System;

namespace ex030
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jagged arrays | Array of arrays
            int[][] a = new int[][] 
            {
                new int[] {4, 3, 2},
                new int[] {2, 9, 6},
                new int[] {10, 459, 67} // I created an array of 3 arrays
            };
            Console.WriteLine(a[2][1]); // Outputs 459
        }
    }
}
