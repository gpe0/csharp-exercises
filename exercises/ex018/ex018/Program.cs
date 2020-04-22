using System;

namespace ex018
{
    class Program
    {
        static void Print(string msg, int rep = 1)
        {
            for (int i = 0; i < rep; i++)
            {
                Console.WriteLine(msg);
            }
        }
        static void Main(string[] args)
        {
            Print(rep: 3, msg: "Hello, my is name is Gonçalo"); //Named parameters | As you can see, u don't need to put the parameters in order when you call the method!
        }       // "name of the variable": "the value"
    }
}
