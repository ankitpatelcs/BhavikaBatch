using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadings
{
    class Shape
    {
        internal void Area(double r)
        {
            Console.WriteLine("Area of Circle: {0}", 3.14 * r * r);
        }
        internal void Area(int a)
        {
            Console.WriteLine("Area of Square: {0}",a*a);
        }
        internal void Area(int l,int b)
        {
            Console.WriteLine("Area Of Rectangle: {0}",l*b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            s.Area(10.5);
            s.Area(10);
            s.Area(10,20);

            Console.Read();
        }
    }
}
