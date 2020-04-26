using System;
using System.Linq;

namespace ex031
{
    class Program
    {
        static void Main(string[] args)
        {
            //Some properties and methods of the array. 
            int[] arr = { 4, 65, 1, 20, 5 };
            Console.WriteLine(arr.Length); // Outputs the number of elements (5)
            Console.WriteLine(arr.Rank); // Outputs the dimensions of the array (1)
            Console.WriteLine(arr.Min()); // Outputs the minimum number of the array (1)
            Console.WriteLine(arr.Max()); // Outputs the maximum number of the array (65)
            Console.WriteLine(arr.Sum()); // Outputs the sum of the array (95)
        }
    }
}
