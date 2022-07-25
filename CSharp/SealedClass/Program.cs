using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    sealed class MyClass
    {
        public int id;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.id = 90;
        }
    }
}
