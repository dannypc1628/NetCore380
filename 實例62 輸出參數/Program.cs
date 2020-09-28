using System;

namespace 實例62_輸出參數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //double r;
            Work(2.001d, 0.855d, out double r);

            Console.WriteLine($"計算結果：{r}");
        }

        static void Work(double x ,double y, out double result)
        {
            result = x + y;
        }
    }
}
