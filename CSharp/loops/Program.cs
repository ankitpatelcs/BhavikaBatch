using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("====While Loop====");
            while (i<5)
            {
                Console.WriteLine("while loop");
                i++;
            }
            Console.WriteLine("=====Do-While=====");
            i = 6;
            do
            {
                Console.WriteLine("do-while loop");
                i++;
            } while (i<5);
            Console.WriteLine("===for loop===");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("for: "+i);
            }

            Console.Read();
        }
    }
}
