using System;

namespace ex047
{
    class Program
    {
        static void Main(string[] args)
        {
            // exception handling | try-catch
            int x = 0;
            bool isInt = true;
            while (true)
            {
                try
                {
                    isInt = true;
                    Console.Write("Write an Integer Number: ");
                    x = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException e) //You can write use multiple catch.
                {
                    Console.WriteLine("Write an Integer.");
                    isInt = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR!");
                    isInt = false;
                }
                if (isInt)
                {
                    break;
                }
            }
            Console.WriteLine("You wrote the number {0}", x);

        }
    }
}
