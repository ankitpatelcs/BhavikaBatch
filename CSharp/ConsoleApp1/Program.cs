using System;

namespace ConsoleApp1
{
    class Order
    {
        protected int[] num = new int[10];

        public void GetValue()
        {
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    class AssendingO : Order
    {
        public AssendingO()
        {
            GetValue();
            Order o = new Order();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 values : ");
            AssendingO ao = new AssendingO();
            ao.GetValue();
            Console.ReadLine();
        }
    }
}
