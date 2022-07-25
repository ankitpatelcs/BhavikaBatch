using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    class Employee
    {
        public int empid { get; set; }
        public string fname { get; set; }
        public string mobile { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> li = new List<Employee>();
            li.Add(new Employee { empid=1, fname="Bhavika", mobile="136879" });
            li.Add(new Employee { empid=2, fname="Shankar", mobile="98654" });
            li.Add(new Employee { empid=3, fname="Bhavika", mobile="136879" });
            li.Add(new Employee { empid=4, fname="Shankar", mobile="687635" });

            Console.WriteLine("Employee Data: ");
            foreach (var item in li)
            {
                Console.WriteLine("\nID: {0}",item.empid);
                Console.WriteLine("name: {0}",item.fname);
                Console.WriteLine("mobile: {0}",item.mobile);
            }

            Console.Read();
        }
    }
}
