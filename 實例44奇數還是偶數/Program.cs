using System;

namespace 實例44奇數還是偶數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string input = Console.ReadLine();
            bool b = uint.TryParse(input, out uint number);
            if (b && number>0)
            {
                Console.WriteLine($"轉型為數值成功！{number}");

                if((number % 2) == 0)
                {
                    Console.WriteLine($"你輸入的{number} 是偶數");
                }
                else
                {
                    Console.WriteLine($"你輸入的{number} 是奇數");
                }
            }
            else
            {
                Console.WriteLine($"轉型失敗！你輸入的內容無效");
            }
        }
    }
}
