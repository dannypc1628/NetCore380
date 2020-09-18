using System;
using static System.Console;
using static System.Math;
namespace 實例35使用using_static_指令
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");

            WriteLine($"5的平方為：{Pow(5d, 2d)}");
            WriteLine($"-650的絕對值為：{Abs(-650)}");
            WriteLine($"16,33中最小值是多少：{Min(16, 33)}");

            Console.WriteLine($"5的平方為：{Math.Pow(5d, 2d)}");
            Console.WriteLine("5的平方為：" + Math.Pow(5d, 2d));

            Console.WriteLine($"-650的絕對值為：{Math.Abs(-650)}");
            Console.WriteLine($"16,33中最小值是多少：{Math.Min(16, 33)}");
        }
    }
}
