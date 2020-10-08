using System;

namespace 實例91_自動產生的常數值
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine($"{Type.Run} => {(int)Type.Run}");
            Console.WriteLine($"{Type.Stop} => {(int)Type.Stop}");
            Console.WriteLine($"{Type.Close} => {(int)Type.Close}");

            Example y = Example.ItemA;
            Console.WriteLine($"{y} = {(int)y}");
            y = Example.ItemB;
            Console.WriteLine($"{y} = {(int)y}");
            y = Example.ItemD;
            Console.WriteLine($"{y} = {(int)y}");
            Console.WriteLine($"{Example.ItemE} = {(int)Example.ItemE}");
        }
    }

    enum Example
    {
        ItemA = 3,
        ItemB,
        ItemC = 10,
        ItemD,
        ItemE,
    }

    enum Type
    {
        Run,
        Stop = 3,
        Close
    }
}
