using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumdemo
{
    enum Weekdays
    {
        Sunday=1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Weekdays.Sunday);

            Console.Read();
        }
    }
}
