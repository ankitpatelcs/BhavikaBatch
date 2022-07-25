using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    abstract class Employee
    {
        virtual public void Display()
        {
            Console.WriteLine("Calling from Employee");
        }
    }
    class Payroll:Employee
    {
        override public void Display()
        {
            Console.WriteLine("Calling from Payroll");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Payroll();
            p.Display();

            Console.Read();
        }
    }
}
