using System;

namespace ex011
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 7;
            if (x < 7 || y > 2) //Logical Operations | OR - ||
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            //Outputs "Correct!", because  the result of an OR operation is only false when both statements are false.
        }
    }
}
