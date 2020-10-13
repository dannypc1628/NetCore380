using System;

namespace 實例108_將位元組陣列轉為字串
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte[] buffer = { 3, 12, 5, 92, 7, 61, 18, 53, 135 };

            string str = BitConverter.ToString(buffer);

            Console.WriteLine(str);
        }
    }
}
