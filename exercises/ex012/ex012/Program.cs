using System;

namespace ex012
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 7;
            if (!(x < 7)) //Logical Operations | NOT - !
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong");
            }
            //Outputs "Correct!", because  the NOT operation change the logical value of the statement, if the statement was false, now it is true.
        }
    }
}
