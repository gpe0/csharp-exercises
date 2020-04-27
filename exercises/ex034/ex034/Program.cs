using System;

namespace ex034
{
    //Static classes | Can only have static members | Like Math, String, Array and DateTime classes
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI);
            string s1 = "One";
            string s2 = "Two";
            Console.WriteLine(String.Concat(s1, s2));
            int[] a = { 4, 6, 3, 8, 20, 1 };
            Array.Sort(a);
            foreach (int i in a)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine(DateTime.Now.Hour);
        }
    }
}
