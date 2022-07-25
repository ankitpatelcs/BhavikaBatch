using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticclass
{
    static class MyClass
    {
        public static int id;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass.id = 90;

            Console.WriteLine(MyClass.id);
            Console.Read();
        }
    }
}
