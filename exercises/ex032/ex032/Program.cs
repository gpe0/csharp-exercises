using System;

namespace ex032
{
    class Program
    {
        static void Main(string[] args)
        {
            //In c#, strings are objects.
            string str = "Word";
            Console.WriteLine(str.Length); //Show length.
            Console.WriteLine(str.IndexOf("r")); //Show the index of the first occurrence of the value within the string.
            str = str.Insert(str.Length, "!");//Insert the value in a certain index.
            Console.WriteLine(str);
            str = str.Remove(2); // removes all characters in the string after the specified index.
            Console.WriteLine(str);
            str = str.Replace("W", "R"); //replaces the specified value in the string.
            Console.WriteLine(str);
            str = str.Substring(0, 1); //returns a substring of the specified length, starting from the specified index. If length is not specified, the operation continues to the end of the string.
            Console.WriteLine(str);
            Console.WriteLine(str.Contains("W")); //returns true if the string contains the specified value.
        }

    }
}
