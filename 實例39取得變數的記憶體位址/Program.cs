using System;

namespace 實例39取得變數的記憶體位址
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 255;

            unsafe
            {
                byte* pb = &b;
            }

            int val = 200;
            unsafe
            {
                int* p = &val;

                IntPtr ptr = (IntPtr)p;
                Console.WriteLine($"變數的地址：{ptr.ToString("x")}");
                Console.WriteLine($"變數的地址：{ptr.ToString()}");

            }
        }
    }
}
