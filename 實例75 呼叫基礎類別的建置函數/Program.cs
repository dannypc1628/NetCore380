using Microsoft.VisualBasic.CompilerServices;
using System;

namespace 實例75_呼叫基礎類別的建置函數
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            B v = new B();

            Console.WriteLine($"Value 1 = {v.Value1}");
            Console.WriteLine($"Value 2 = {v.Value2}");

        }
    }

    class A
    {
        public int Value1 { get;}

        public int Value2 { get; }
        public A(int v1 ,int v2)
        {
            Value1 = v1;
            Value2 = v2;
            Console.WriteLine("這是A的建構函式");
        }
              
        
    }

    class B : A
    {
        public B():base(900,700)
        {
            Console.WriteLine("這是B的建構函式");
        }
    }
}
