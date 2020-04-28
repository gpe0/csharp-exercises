using System;

namespace ex036
{
    class Program
    {
        //Arrays in Classes
        class Clients
        {
            private string[] names = new string[2];
            public string this[int index]
            {
                get { return names[index]; }
                set { names[index] = value; }
            }
        }
        static void Main(string[] args)
        {
            Clients c = new Clients();
            c[0] = "Jonh";
            c[1] = "Michael";
            Console.WriteLine(c[1]);
        }
    }
}
