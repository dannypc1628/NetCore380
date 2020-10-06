using System;

namespace 實例88_宣告列舉類型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Options a = Options.OneWay;
            Options b = Options.TwoWay;
            Options c = Options.MixWay;

            Console.WriteLine($"常數名：{a},常數值：{(int)a}");
            Console.WriteLine($"常數名：{b},常數值：{(int)b}");
            Console.WriteLine($"常數名：{c},常數值：{(int)c}");

            //.NET 內建星期enum
            DayOfWeek d0 = DayOfWeek.Sunday;
            DayOfWeek d1 = DayOfWeek.Monday;
            DayOfWeek d2 = DayOfWeek.Tuesday;
            DayOfWeek d3 = DayOfWeek.Wednesday;
            DayOfWeek d4 = DayOfWeek.Thursday;
            DayOfWeek d5 = DayOfWeek.Friday;
            DayOfWeek d6 = DayOfWeek.Saturday;

            Console.WriteLine();
            Console.WriteLine($"常數名：{d0},常數值：{(int)d0}");
            Console.WriteLine($"常數名：{d1},常數值：{(int)d1}");
            Console.WriteLine($"常數名：{d2},常數值：{(int)d2}");
            Console.WriteLine($"常數名：{d3},常數值：{(int)d3}");
            Console.WriteLine($"常數名：{d4},常數值：{(int)d4}");
            Console.WriteLine($"常數名：{d5},常數值：{(int)d5}");
            Console.WriteLine($"常數名：{d6},常數值：{(int)d6}");
            
            Console.WriteLine();

            var today = DateTime.Now.DayOfWeek;
            if(today == DayOfWeek.Sunday)
            {
                Console.WriteLine("今天是星期天");
            }
            else
            {
                Console.WriteLine("今天不是星期天");
            }

        }
    }
    enum Options
    {
        OneWay = 1,
        TwoWay = 2,
        MixWay = 3
    }
}
