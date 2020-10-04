using System;
using System.Threading;

namespace 實例82_解構函數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Test();
            Console.WriteLine("Test()執行結束");
            
            Thread.Sleep(3000);//休息3000毫秒再執行下去
            GC.Collect();
        }

        static void Test()
        {
            Example ex = new Example();

        }
    }

    class Example
    {
        public Example()
        {
            Console.WriteLine("建構函式被呼叫");
        }

        ~Example()
        {
            Console.WriteLine("解構函式被呼叫");
        }
    }
}
