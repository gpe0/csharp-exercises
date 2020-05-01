using System;

namespace ex051
{
    //Generic classes | Really similar to generic methods.
    class ArrayCreator<T>
    {
        private int ind = 0;
        private T[] arr;
        public ArrayCreator(int x)
        {
            arr = new T[x];
        }
        public void Add(T x)
        {
            arr[ind++] = x;
        }
        public void Get(int x)
        {
            try
            {
                Console.WriteLine(arr[x]);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayCreator<string> a = new ArrayCreator<string>(2);
            a.Add("Hello");
            a.Add("World");
            a.Get(1);
            a.Get(2);
        }
    }
}
