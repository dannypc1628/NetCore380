using System;

namespace 實例48退出循環的方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            while (true)
            {
                Console.WriteLine("請按E來退出迴圈");

                // false：顯示使用者按的鍵
                // true ：不顯示使用者按的鍵
                if (Console.ReadKey(false).Key == ConsoleKey.E)
                {
                    break;
                }
            }
        }
    }
}
