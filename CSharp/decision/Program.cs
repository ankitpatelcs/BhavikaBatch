using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 15;
            if (a > 10)
            {
                if (a%5==0)
                {
                    Console.WriteLine("true");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.Read();
        }
    }
}
