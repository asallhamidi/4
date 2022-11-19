using System;

namespace _4
{
    class Program
    {
        static void Main()
        {
            int a = 0, b = 0;
            int bmm = 0, kmm = 0;
            int x1 = 0, x2 = 0, x3 = 0, k1 = 0, k2 = 0;
            Console.Write("enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter b:");
            b = Convert.ToInt32(Console.ReadLine());
            x1 = (a % b);
            x2 = (b % x1);
            x3 = (x1 % x2);
            if (x3 == 0)
            {
                bmm = x2;
                k1 = (a / bmm);
                k2 = (k1 * b);
                kmm = k2;
            }
            Console.WriteLine("bmm is {0} and kmm is{1}", bmm, kmm);
        }
    }
}
