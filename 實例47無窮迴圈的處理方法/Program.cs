using System;

namespace 實例47無窮迴圈的處理方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //while 無窮迴圈
            int i = 0;
            while (9 == 9)
            {
                Console.WriteLine($"{DateTime.Now:T} 正在執行循環~~~{i}");
                if (i > 100)
                {
                    break;
                }

                i++;
            }
            //for 無窮迴圈
            //for (; true;)
            //{
            //    Console.WriteLine(123);
            //}
        }
    }
}
