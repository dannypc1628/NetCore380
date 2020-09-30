using System;

namespace 實例68_委派實例如何綁定方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            DoSomething dele = RueHere;// 等同於 DoSomething dele = new DoSomething(RueHere);

            double result = dele(16, 27.67d); //新版的寫法
            double result2 = dele.Invoke(16, 27.67d); // C#1.0的寫法
        }

        delegate double DoSomething(int x,double y);

        static double RueHere(int a , double b)
        {
            return a + b;
        }
    }
}
