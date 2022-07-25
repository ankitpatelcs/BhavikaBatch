using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            arr[0] = 34;
            arr[1] = 78;
            arr[2] = 65;
            arr[3] = 19;
            arr[4] = 65;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array[{0}]: {1}",i,arr[i]);
            }

            Console.Read();
        }
    }
}
