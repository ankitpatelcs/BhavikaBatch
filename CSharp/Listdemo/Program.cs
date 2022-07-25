using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
            li.Add(23);
            li.Add(36);
            li.Add(98);
            li.Add(75);

            List<string> names = new List<string>();
            names.Add("Shankar");
            names.Add("Bhavika");
            names.Add("Disha");
            names.Add("Vrunda");

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }


            foreach (int item in li)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}
