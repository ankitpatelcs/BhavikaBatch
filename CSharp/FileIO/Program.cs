using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class MyClass
    {
        internal void WriteFile(string filename)
        {
            StreamWriter sw = File.CreateText(filename);
            Console.Write("Enter text to write: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("Write success.");
        }
        internal void ReadFile(string filename)
        {
            StreamReader sr = File.OpenText(filename);
            string data = sr.ReadToEnd();
            Console.WriteLine("\nText from File: {0}",data);
            sr.Close();
            Console.WriteLine("Read Success.");
        }
        internal void AppendFile(string filename)
        {
            StreamWriter sw = File.AppendText(filename);
            Console.Write("\nEnter text to append: ");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Close();
            Console.WriteLine("Append success.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            string filename = @"C:\Ankit Patel\Shankar.txt";
            m.WriteFile(filename);
            m.ReadFile(filename);
            m.AppendFile(filename);
            m.ReadFile(filename);

            Console.Read();
        }
    }
}
