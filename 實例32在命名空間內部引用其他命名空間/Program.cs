using System;

namespace 實例32在命名空間內部引用其他命名空間
{
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> list1 = new List<int> { 100, 200, 300 };

            System.Collections.Generic.List<int> list2 = new System.Collections.Generic.List<int> { 100, 200, 300 };
        }
    }
}
