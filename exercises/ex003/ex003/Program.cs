using System;

namespace ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Gonçalo"; //variables declared with var keyword must be initialized with a value
            const double pi = 3.14; //const variables can't be changed
            int start = 0;
            int finish = 1;
            Console.WriteLine(Convert.ToBoolean(start)); //Converting the start variable's value to Boolean
            Console.WriteLine(Convert.ToBoolean(finish));
        }
    }
}
