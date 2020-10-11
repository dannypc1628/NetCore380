using System;

namespace 實例100_逐位元平移
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int x = 305;
            int y = 1060;
            Console.WriteLine($"{Convert.ToString(x,8)} 向左移動3位數，" +
                $"獲得{Convert.ToString( x << 3, 2)}");
            Console.WriteLine($"{Convert.ToString(y, 16)} 向右移動4位數，" +
                $"獲得{Convert.ToString(y >> 4, 2)}");
        }
    }
}
