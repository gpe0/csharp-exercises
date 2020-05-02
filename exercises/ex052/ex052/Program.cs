using System;
using System.Collections.Generic; //First, we need to import the Generic collections, there are Non-Generic, but we should use the generic ones.
using System.Collections;

namespace ex052
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections | Lists
            List<int> list = new List<int>();
            list.Add(30);
            list.Add(1);
            list.Insert(0, 5);
            list.Sort();
            Console.WriteLine(list.Contains(6));
            foreach (int n in list)
            {
                Console.Write("{0} ", n);
            }
            //Collections | SortedLists | Keys, Values
            SortedList<string, int> slist = new SortedList<string, int>();
            slist.Add("Hello", 98);
            slist.Add("World", 4);
            Console.WriteLine("\n");
            foreach(string n in slist.Keys)
            {
                Console.WriteLine("{0}: {1}", n, slist[n]);
            }
            //Collections | BitArrays | Collection of bits
            BitArray ba = new BitArray(4);
            ba.SetAll(false);
            ba.Set(1, true);
            Console.WriteLine("\nba:");
            foreach (bool n in ba.Not())
            {
                Console.Write("{0} ", n);
            }
            Console.WriteLine("\nNOT ba:");
            foreach (bool n in ba.Not())
            {
                Console.Write("{0} ", n);
            }
        }
    }
}
