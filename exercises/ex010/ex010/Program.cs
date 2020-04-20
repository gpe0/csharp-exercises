using System;

namespace ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 7;
            if (x < 7 && y > 2) //Logical Operations | AND - &&
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            //Outputs "Wrong", because  the result of an AND operation is only true when both statements are true.
        }
    }
}
