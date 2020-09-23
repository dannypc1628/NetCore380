using System;

namespace 實例45使用for循環輸出文字
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int n = 1; n<=5; n++)
            {
                Console.WriteLine($"這是第{n}行的文字");
            }
        }
    }
}
