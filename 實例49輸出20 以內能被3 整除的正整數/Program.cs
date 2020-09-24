using System;

namespace 實例49輸出20_以內能被3_整除的正整數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for (int i = 1; i <=20; i++)
            {
                if( (i%3) != 0)
                    continue;

                Console.Write(" {0}",i);
                Console.Write($" {i}");

            }
        }
    }
}
