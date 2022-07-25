using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaryss
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, object> dic = new Dictionary<string, object>();
            dic.Add("ID",509);
            dic.Add("Name","Bhavika");
            dic.Add("Salary",50900.5);
            dic.Add("Gender",'F');

            foreach (var item in dic)
            {
                Console.WriteLine(item.Key+" : "+item.Value);
            }
            Console.Read();
        }
    }
}
