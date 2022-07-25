using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{
    delegate void FirstDelegate();
    delegate string SecondDelegate(string fname, int salary);
    class MyClass
    {
        internal void display()
        {
            Console.WriteLine("calling display function");
        }
        internal void show()
        {
            Console.WriteLine("calling show function");
        }

        public string ShowData(string fname, int salary)
        {
            return $"the student {fname} is having salary {salary}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            FirstDelegate d1 = new FirstDelegate(m.display);
            //multicasting
            d1 += new FirstDelegate(m.show);
            d1.Invoke();

            d1 -= new FirstDelegate(m.show);
            d1.Invoke();

            Console.WriteLine("=================");
            SecondDelegate d2 = new SecondDelegate(m.ShowData);
            string data= d2.Invoke("Bhavika", 36000);
            Console.WriteLine(data);

            Console.Read();
        }
    }
}
