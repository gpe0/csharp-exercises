using System;

namespace ex046
{
    //Enums | The enum keyword is used to declare an enumeration. | A type that consists of a set of named constants called the enumerator list.
    //By default, the first enumerator has the value 0, and the value of each successive enumerator is increased by 1.
    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat}
    //           0    1    2    3    4    5    6
    class Program
    {
        static void Main(string[] args)
        {
            int x = (int)Days.Mon;
            Console.WriteLine(x); //Outputs 1
        }
    }
}
