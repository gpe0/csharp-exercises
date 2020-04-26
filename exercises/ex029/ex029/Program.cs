using System;

namespace ex029
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multi dimensional arrays
            int[,] a = new int[3, 2]; // This will create 3 rows and 2 columns
                                      //        Column 1    Column 2
                                      // Row 1   [0, 0]      [0, 1]
                                      // Row 2   [1, 0]      [1, 1]
                                      // Row 3   [2, 0]      [2, 1]
            int[,] arr = { { 2, 4 }, { 0, 2 }, { 3, 7 } };
            Console.WriteLine(arr[2, 0]); //Outputs 3
        
        }
    }
}
