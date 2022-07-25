using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class Employee
    {
        int id;
        string name;

        public Employee(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        internal void Getdata()
        {
            id = 90;
            name = "Bhavika";
        }

        internal void ShowData()
        {
            Console.WriteLine("Employee ID: " + id);
            Console.WriteLine("Employee Name: " + name);
        }

        ~Employee()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(45, "Shankar");
            //e.Getdata();
            e.ShowData();

            Console.Read();
        }
    }
}
