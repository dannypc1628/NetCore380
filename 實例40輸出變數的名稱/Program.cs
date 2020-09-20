using System;

namespace 實例40輸出變數的名稱
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string strvar = "hello";
            int intvar = 3600;
            var singlevar = 7.115f;
            var longvar = 6560000L;

            Console.WriteLine($"變數{nameof(strvar)}的值為{strvar}");
            Console.WriteLine($"變數{nameof(intvar)}的值為{intvar}");
            Console.WriteLine($"變數{nameof(singlevar)}的值為{singlevar}");
            Console.WriteLine($"變數{nameof(longvar)}的值為{longvar}");
            Console.WriteLine($"變數longva的值為{longvar}");


        }
    }
}
