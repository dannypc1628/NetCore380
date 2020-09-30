using System;
using System.Numerics;

namespace 實例69_綁定多個方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //dx = M1;
            //dx = dx + M2;
            //dx += M2;

            MyFunction del = null;
            del += Output2;//依加入的先後順序執行
            del += Output1;

            del();
        }

        delegate void MyFunction();

        static void Output1()
        {
            Console.WriteLine("第一個方法");
        }
        static void Output2()
        {
            Console.WriteLine("第二個方法");
        }
    }
}
