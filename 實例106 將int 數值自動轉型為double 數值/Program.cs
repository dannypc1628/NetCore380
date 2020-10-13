using System;

namespace 實例106_將int_數值自動轉型為double_數值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 28, y = 66, z = 312;
            int i = 12;

            double e = x, f = y, g = z;
            double j = (double)i;

            Console.WriteLine($"{x,-15} {e,-15}");
            Console.WriteLine($"{y,-15} {f,-15:0.000}");
            Console.WriteLine($"{z,-15} {g,-15:0.000}");


        }
    }
}
