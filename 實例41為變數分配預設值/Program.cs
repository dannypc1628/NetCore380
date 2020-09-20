using System;

namespace 實例41為變數分配預設值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int v = default;
            string s = default;
            string nu = null;
            Console.WriteLine($"int 類型的預設值:{v}");
            Console.WriteLine(nu);
            Console.WriteLine($"string 類型的預設值:{s??"這是null"}");

        }
    }
}
