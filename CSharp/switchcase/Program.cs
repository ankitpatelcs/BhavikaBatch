using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'e';

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("{0} is a Vowel",ch);
                    break;
                case 'e':
                    Console.WriteLine("{0} is a Vowel", ch);
                    break;
                case 'i':
                    Console.WriteLine("{0} is a Vowel", ch);
                    break;
                case 'o':
                    Console.WriteLine("{0} is a Vowel", ch);
                    break;
                case 'u':
                    Console.WriteLine("{0} is a Vowel", ch);
                    break;

                default:
                    Console.WriteLine("{0} is a Consonent", ch);
                    break;
            }

            Console.Read();
        }
    }
}
