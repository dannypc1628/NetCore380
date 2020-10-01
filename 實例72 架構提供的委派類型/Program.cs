using System;
using System.Dynamic;
using System.IO;

namespace 實例72_架構提供的委派類型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Action<string, int> d1 = TestA;
            d1("Bod", 28);
            Action<string> d2 = TestB;
            d2("Jim");

            Func<DateTime, int> d3 = TestC;
            Console.WriteLine("今年是{0}年",d3(DateTime.Now));

            Func<int, int, long> d4 = TestD;
            long result = d4(2, 4);
            Console.WriteLine("計算結果：{0}", result);
        }

        static void TestA(string name,int age)
        {
            Console.WriteLine($"{name}今年{age}歲了。");
        }
        static void TestB(string name)
        {
            Console.WriteLine("你好 {0}",name);

        }

        static int TestC(DateTime dt)
        {
            return dt.Year;
        }
        static long TestD(int start, int end)
        {
            long r = 1L;
            int cur = start;

            while (cur <= end)
            {
                r *= cur; //等同於r = r * cur;
                cur++;
            }
            return r;
        }
    }
}
