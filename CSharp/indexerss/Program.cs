using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexerss
{
    class MyClass
    {
        string[] name = new string[5];
        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m[0] = "Shankar";
            m[2] = "Bhavika";
            m[4] = "Disha";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Value[{0}] : {1}",i,m[i]);
            }
            Console.Read();
        }
    }
}
