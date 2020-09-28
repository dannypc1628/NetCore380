using System;

namespace 實例63_可變個數的方法參數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = new[] { 1, 2, 3, 4 };
            Sample(arr);

            Console.WriteLine("\n\n使用可變個數的方法參數");
            Sample(7, 8, 9, 10);
        }
        static void Sample(params int[] numbers)
        {
            Console.WriteLine("\n參數列表");
            foreach (int i in numbers)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }

}
