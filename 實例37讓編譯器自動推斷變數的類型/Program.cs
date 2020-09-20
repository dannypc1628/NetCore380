using System;

namespace 實例37讓編譯器自動推斷變數的類型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var a = 123;
            var d = 3.141d;
            var f = 3.141f;
            var m = 3.141m;
            
            d = (double)a;

            Console.WriteLine($"變數a的類型為：{a.GetType().FullName}");
        }
    }
}
