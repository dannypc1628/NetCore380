using System;

namespace 實例65_按參數名稱來傳值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = Sum(b:1, a: 2);

            int xx = Math.Min(5, 13);

            int yy = Math.Min(val1: 2, val2: 6);

            int zz = Math.Min(val2: 17, val1: 58);

        }
        public static int Sum(int a, int b)
        {
            Console.WriteLine($"a={a}  b={b}");
            return a + b;
        }
    }

}
