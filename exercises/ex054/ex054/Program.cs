using System;
using System.Collections.Generic;

namespace ex054
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections | Dictionaries | Keys and Values
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("Hello", 30);
            dic.Add("Hi", 100);
            dic.Add("Sup", 3);
            Console.WriteLine(dic.Count);
            dic.Remove("Sup"); //Removing the "3" value.
            foreach(string n in dic.Keys)
            {
                Console.WriteLine("{0}: {1}", n, dic[n]);
            }
            //Collections | Hash Sets
            HashSet<int> hs = new HashSet<int>();
            hs.Add(4);
            hs.Add(100);
            hs.Add(1);
            hs.Add(50);
            Console.WriteLine(hs.Count);
            foreach(int n in hs)
            {
                Console.Write("{0} ", n);
            }
            HashSet<int> hs2 = new HashSet<int>();
            hs2.Add(4);
            hs2.Add(1);
            Console.WriteLine("\n{0}", hs2.IsSubsetOf(hs));
        }
    }
}
