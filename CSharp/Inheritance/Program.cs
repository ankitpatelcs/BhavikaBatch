using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        int id;
        string name;
        protected void GetEmp()
        {
            id = 50;
            name = "Shankar";
        }
        protected void ShowEmp()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
        }
    }

    class Payroll : Employee
    {
        int salary;
        internal void Getdata()
        {
            GetEmp();
            salary = 45000;
        }
        internal void ShowData()
        {
            ShowEmp();
            Console.WriteLine("Salary: "+salary);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Payroll p = new Payroll();
            p.Getdata();
            p.ShowData();

            Console.Read();

        }
    }
}
