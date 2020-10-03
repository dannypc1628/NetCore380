using System;

namespace 實例79_實現介面的結構
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ITest v = new TestCal();
            
            int result = v.Add(10, 5);
            Console.WriteLine("計算結果：{0}",result);
        }
    }

    interface ITest
    {
        int Add(int a, int b);
    }

    struct TestCal : ITest
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }

}
