using System;

namespace 實例70_匿名方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test td = null;
            td += delegate (double x, double y)
            {
                Console.WriteLine($"{x} + {y} = {x + y}");
            };

            td += delegate (double x, double y)
            {
                Console.WriteLine($"{x} - {y} = {x - y}");
            };

            td += delegate (double x, double y)
            {
                Console.WriteLine($"{x} X {y} = {x * y}");
            };
            
            td(0.3d, 0.2d);
        }

        delegate void Test(double f, double g);

    }
}
