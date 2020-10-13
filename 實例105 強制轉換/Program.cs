using System;

namespace 實例105_強制轉換
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double dd = 1.23;
            int k = (int)dd;

            double a = 5.10985d;
            int b = (int)a;
            Console.WriteLine($"{a,-15}{b,-15}");

            double c = 12.8155d;
            int d = (int)c;
            Console.WriteLine($"{c,-15}{d,-15}");
        }
    }
}
