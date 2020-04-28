using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Specialized;
using System.Dynamic;

namespace ex037
{
    //Operator overloading
    class Box
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Box(double w, double h)
        {
            this.Width = w;
            this.Height = h;
        }
        static public Box operator+ (Box a, Box b)
        {
            double w = a.Width + b.Width;
            double h = a.Height + b.Height;
            Box c = new Box(w, h);
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box b1 = new Box(5, 4);
            Box b2 = new Box(9, 8);
            Box b3 = b1 + b2;
            Console.WriteLine(b3.Width);
        }
    }
}
