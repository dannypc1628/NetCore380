using System;

namespace 實例29使用namespace關鍵字
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test.Car c = new Test.Car();
            c.Run();

            Console.ReadLine();
        }
    }
}

namespace Test
{
    public class Car
    {
        public void Run()
        {
            Console.WriteLine("開車拉");
        }
    }
}